using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using YoutubeExplode;
using YoutubeExplode.Search;
using ATOTIFY.Modeller;

namespace ATOTIFY.Servisler
{
    public class SpotifyServisi
    {
        // Spotify Developer Dashboard'dan (developer.spotify.com) alınması gereken bilgiler:
        private const string ClientId = ""; // BURAYA CLIENT ID GELECEK
        private const string ClientSecret = ""; // BURAYA CLIENT SECRET GELECEK

        private SpotifyClient _spotify;
        private readonly YoutubeClient _youtube = new YoutubeClient();

        public async Task BaslatAsync()
        {
            if (string.IsNullOrEmpty(ClientId) || string.IsNullOrEmpty(ClientSecret))
            {
                // Eğer key girilmediyse, uygulamanın çökmemesi için sahte veriler döndüreceğiz.
                return;
            }

            var config = SpotifyClientConfig.CreateDefault();
            var request = new ClientCredentialsRequest(ClientId, ClientSecret);
            var response = await new OAuthClient(config).RequestToken(request);

            _spotify = new SpotifyClient(config.WithToken(response.AccessToken));
        }

        public async Task<List<Song>> AnaSayfaSarkilariniGetirAsync()
        {
            if (_spotify == null) return GetMockTurkishSongs();

            try
            {
                // Spotify üzerinden "Türkçe Pop" çalma listesini çekme örneği
                var playlist = await _spotify.Playlists.Get("37i9dQZF1DWWEcRhUVtL8n"); // Türkçe Pop Playlist ID
                
                var songs = new List<Song>();
                if (playlist.Tracks?.Items != null)
                {
                    foreach (var item in playlist.Tracks.Items)
                    {
                        if (item.Track is FullTrack track)
                        {
                            songs.Add(new Song
                            {
                                Title = track.Name,
                                Artist = track.Artists.Count > 0 ? track.Artists[0].Name : "Bilinmeyen Sanatçı",
                                CoverUrl = track.Album.Images.Count > 0 ? track.Album.Images[0].Url : "",
                                DurationSeconds = track.DurationMs / 1000,
                                ExternalId = track.Id,
                                SourceType = "Spotify"
                            });
                        }
                    }
                }
                return songs;
            }
            catch
            {
                return GetMockTurkishSongs();
            }
        }

        public async Task<List<Song>> SarkiAraAsync(string query)
        {
            // Spotify bağlı ise Spotify ile ara
            if (_spotify != null)
            {
                try
                {
                    var request = new SearchRequest(SearchRequest.Types.Track, query);
                    var response = await _spotify.Search.Item(request);

                    var songs = new List<Song>();
                    if (response.Tracks?.Items != null)
                    {
                        foreach (var track in response.Tracks.Items)
                        {
                            songs.Add(new Song
                            {
                                Title = track.Name,
                                Artist = track.Artists.Count > 0 ? track.Artists[0].Name : "Bilinmeyen Sanatçı",
                                CoverUrl = track.Album.Images.Count > 0 ? track.Album.Images[0].Url : "",
                                DurationSeconds = track.DurationMs / 1000,
                                ExternalId = track.Id,
                                SourceType = "Spotify"
                            });
                        }
                    }
                    return songs;
                }
                catch { }
            }

            // Spotify yoksa YouTube'dan ara
            return await YouTubeAraAsync(query);
        }

        private async Task<List<Song>> YouTubeAraAsync(string query)
        {
            var songs = new List<Song>();
            try
            {
                // YouTube'da ilk 20 sonucu getir
                await foreach (var result in _youtube.Search.GetResultsAsync(query))
                {
                    if (result is VideoSearchResult video)
                    {
                        // Sanatçı - Başlık formatını ayır (örn: "Duman - Senden İyi Olamam")
                        string title = video.Title;
                        string artist = "YouTube";

                        if (title.Contains(" - "))
                        {
                            var parts = title.Split(new[] { " - " }, 2, StringSplitOptions.None);
                            artist = parts[0].Trim();
                            title = parts[1].Trim();
                        }

                        songs.Add(new Song
                        {
                            Title = title,
                            Artist = artist,
                            CoverUrl = video.Thumbnails.OrderByDescending(t => t.Resolution.Width).FirstOrDefault()?.Url ?? "",
                            DurationSeconds = (int)(video.Duration?.TotalSeconds ?? 0),
                            YoutubeId = video.Id.Value,
                            SourceType = "YouTube"
                        });

                        if (songs.Count >= 20) break;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("YouTube arama hatası: " + ex.Message);
            }
            return songs;
        }

        private List<Song> GetMockTurkishSongs()
        {
            return new List<Song>
            {
                new Song { Title = "S2m Up", Artist = "Şam", CoverUrl = "", YoutubeId = "d6T5g4BZiQA" },
                new Song { Title = "Reankarne", Artist = "Stabil", CoverUrl = "", YoutubeId = "wLgVGYIBb3I" },
                new Song { Title = "Yok Bana Bu Cihanda", Artist = "Maya Perest", CoverUrl = "", YoutubeId = "P4Zi_own3W4" },
                new Song { Title = "Şifa İstemem Balından", Artist = "Grup Abdal", CoverUrl = "", YoutubeId = "IyDhyor2Q4w" },
                new Song { Title = "Yara", Artist = "Kalben", CoverUrl = "", YoutubeId = "-Tj828PqZE0" },
                new Song { Title = "Sorma", Artist = "Kaan Tangöze", CoverUrl = "", YoutubeId = "4smLEYARZ4w" },
                new Song { Title = "Bak", Artist = "Pilli Bebek", CoverUrl = "", YoutubeId = "UP2E-0-cN_U" },
                new Song { Title = "Ending Credits", Artist = "Opeth", CoverUrl = "", YoutubeId = "n-5P6UJNQZU" },
                new Song { Title = "Binlerce Özür", Artist = "Kafabindünya", CoverUrl = "", YoutubeId = "YtCLNlrc_ho" },
                new Song { Title = "Cascade", Artist = "Turkish Delight", CoverUrl = "", YoutubeId = "M5O7DpqWYw0" },
                new Song { Title = "It's Snowing Like", Artist = "Krobak", CoverUrl = "", YoutubeId = "kFUeijXc0iw" },
                new Song { Title = "Bilek Kesme Türküsü", Artist = "Bazen Uçmak İsterim", CoverUrl = "", YoutubeId = "8vBTdUOrpTo" },
                new Song { Title = "Sen Gelmez Oldun", Artist = "Alihan Samedow", CoverUrl = "", YoutubeId = "PwX3LOgl4F4" },
                new Song { Title = "İhtiyar Oldum", Artist = "Cem Karaca", CoverUrl = "", YoutubeId = "ceHRJVVU0Sw" },
                new Song { Title = "Ceviz Ağacı", Artist = "Cem Karaca", CoverUrl = "", YoutubeId = "khD07C-YDL4" },
                new Song { Title = "Bu Son Olsun", Artist = "Cem Karaca", CoverUrl = "", YoutubeId = "Nwk5uZNUcMw" },
                new Song { Title = "Gözleri Kanlı", Artist = "Duman", CoverUrl = "", YoutubeId = "oIvhaOGNDEk" },
                new Song { Title = "Haberin Yok Ölüyorum", Artist = "Duman", CoverUrl = "", YoutubeId = "r-DgkPS9Ids" },
                new Song { Title = "Bir Sevmek Bin Defa Ölmek Demekmiş", Artist = "Barış Akarsu", CoverUrl = "", YoutubeId = "89IWDcWTjM8" },
                new Song { Title = "Geceler Kara Tren", Artist = "Nazan Öncel", CoverUrl = "", YoutubeId = "4KlRnvlxfHw" },
                new Song { Title = "Kimse Bilmez", Artist = "Mehmet Güreli", CoverUrl = "", YoutubeId = "piyF5qJv8NQ" },
                new Song { Title = "Biliyorsun", Artist = "Redd", CoverUrl = "", YoutubeId = "9QwzcnoUDss" },
                new Song { Title = "Bilmezsin", Artist = "Berk Baysal", CoverUrl = "", YoutubeId = "26ATB3-DbuI" },
                new Song { Title = "Vazgeç Gönül", Artist = "Zeynep Dizdar", CoverUrl = "", YoutubeId = "RpQNgl_IvT8" },
            };
        }
    }
}
