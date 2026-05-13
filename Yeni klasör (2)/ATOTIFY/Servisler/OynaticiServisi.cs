using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibVLCSharp.Shared;
using ATOTIFY.Modeller;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace ATOTIFY.Servisler
{
    public class OynaticiServisi : IDisposable
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private YoutubeClient _youtubeClient;
        private Dictionary<string, string> _preCachedUrls = new Dictionary<string, string>();

        public event EventHandler<float> OnProgressChanged;
        public event EventHandler OnSongEnded;
        public event EventHandler<(Song sarki, bool isPlaying)> OnSongChanged;

        public bool IsPlaying => _mediaPlayer != null && _mediaPlayer.IsPlaying;
        
        public long GetCurrentTime() => _mediaPlayer != null ? _mediaPlayer.Time : 0;
        public long GetTotalTime() => _mediaPlayer != null ? _mediaPlayer.Length : 0;
        
        // 0: Off, 1: Playlist, 2: Song
        public int RepeatMode { get; set; } = 0;
        public bool IsShuffle { get; set; } = false;

        private List<Song> _currentQueue = new List<Song>();
        private List<Song> _originalQueue = new List<Song>();
        private int _currentIndex = -1;
        
        // Caching for instant replay
        private Dictionary<string, string> _streamCache = new Dictionary<string, string>();

        public OynaticiServisi()
        {
            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            _youtubeClient = new YoutubeClient();

            _mediaPlayer.PositionChanged += (sender, e) =>
            {
                OnProgressChanged?.Invoke(this, e.Position * 100);
            };

            _mediaPlayer.EndReached += (sender, e) =>
            {
                Task.Run(() =>
                {
                    if (RepeatMode == 2) // Repeat One
                    {
                        var t = Task.Run(async () => {
                            await Task.Delay(100);
                            _mediaPlayer.Stop();
                            _mediaPlayer.Play();
                        });
                    }
                    else
                    {
                        OnSongEnded?.Invoke(this, EventArgs.Empty);
                        _ = SonrakiSarkiAsync(isAutoNext: true);
                    }
                });
            };
        }

        public void SetQueue(List<Song> queue, int startIndex)
        {
            _originalQueue = queue.ToList();
            if (IsShuffle && queue.Count > 0)
            {
                var rand = new Random();
                var selected = queue[startIndex];
                var others = queue.Where(x => x != selected).OrderBy(x => rand.Next()).ToList();
                _currentQueue = new List<Song> { selected };
                _currentQueue.AddRange(others);
                _currentIndex = 0;
            }
            else
            {
                _currentQueue = queue.ToList();
                _currentIndex = startIndex;
            }
        }

        public void ToggleShuffle()
        {
            IsShuffle = !IsShuffle;
            if (_currentIndex >= 0 && _currentIndex < _currentQueue.Count)
            {
                var currentSong = _currentQueue[_currentIndex];
                SetQueue(_originalQueue, _originalQueue.IndexOf(currentSong));
            }
        }

        public async Task SarkiCalAsync(Song sarki)
        {
            OnSongChanged?.Invoke(this, (sarki, true)); // Immediate UI feedback
            try
            {
                string cacheKey = $"{sarki.Title} - {sarki.Artist}";
                string streamUrl = null;

                if (_preCachedUrls.ContainsKey(cacheKey)) streamUrl = _preCachedUrls[cacheKey];
                else if (_streamCache.ContainsKey(cacheKey)) streamUrl = _streamCache[cacheKey];

                if (string.IsNullOrEmpty(streamUrl))
                {
                    if (!string.IsNullOrEmpty(sarki.YoutubeId))
                    {
                        var streamManifest = await _youtubeClient.Videos.Streams.GetManifestAsync(sarki.YoutubeId);
                        streamUrl = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate().Url;
                        _streamCache[cacheKey] = streamUrl;
                    }
                    else
                    {
                        var searchQuery = $"{sarki.Title} {sarki.Artist} topic";
                        await foreach (var res in _youtubeClient.Search.GetVideosAsync(searchQuery))
                        {
                            if (res.Duration?.TotalSeconds > 30)
                            {
                                var manifest = await _youtubeClient.Videos.Streams.GetManifestAsync(res.Id);
                                streamUrl = manifest.GetAudioOnlyStreams().GetWithHighestBitrate().Url;
                                _streamCache[cacheKey] = streamUrl;
                                break;
                            }
                        }
                    }
                }

                if (!string.IsNullOrEmpty(streamUrl))
                {
                    var media = new Media(_libVLC, new Uri(streamUrl));
                    _mediaPlayer.Play(media);
                    
                    // Pre-cache NEXT song
                    _ = Task.Run(async () => {
                        int nextIdx = _currentIndex + 1;
                        if (nextIdx < _currentQueue.Count) {
                            var nextSong = _currentQueue[nextIdx];
                            string nextKey = $"{nextSong.Title} - {nextSong.Artist}";
                            if (!_preCachedUrls.ContainsKey(nextKey)) {
                                try {
                                    var manifest = await _youtubeClient.Videos.Streams.GetManifestAsync(nextSong.YoutubeId);
                                    _preCachedUrls[nextKey] = manifest.GetAudioOnlyStreams().GetWithHighestBitrate().Url;
                                } catch {}
                            }
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Şarkı çalınamadı: {ex.Message}");
            }
        }

        public async Task SonrakiSarkiAsync(bool isAutoNext = false)
        {
            if (_currentQueue.Count == 0) return;

            _currentIndex++;
            if (_currentIndex >= _currentQueue.Count)
            {
                if (RepeatMode == 1) // Repeat Playlist
                {
                    _currentIndex = 0;
                }
                else
                {
                    _currentIndex = _currentQueue.Count - 1;
                    if (isAutoNext) return; // Stop if auto next and no repeat
                }
            }

            var next = _currentQueue[_currentIndex];
            await SarkiCalAsync(next);
        }

        public async Task OncekiSarkiAsync()
        {
            if (_currentQueue.Count == 0) return;

            // If playing more than 3 seconds, previous restarts current track
            if (_mediaPlayer.Time > 3000)
            {
                _mediaPlayer.Position = 0;
                return;
            }

            _currentIndex--;
            if (_currentIndex < 0)
            {
                if (RepeatMode == 1) _currentIndex = _currentQueue.Count - 1;
                else _currentIndex = 0;
            }

            var prev = _currentQueue[_currentIndex];
            await SarkiCalAsync(prev);
        }

        public void DuraklatVeyaDevamEt()
        {
            if (_mediaPlayer.IsPlaying)
                _mediaPlayer.Pause();
            else
                _mediaPlayer.Play();
        }

        public void SesSeviyesiAyarla(int seviye)
        {
            _mediaPlayer.Volume = seviye;
        }

        public void PozisyonAyarla(float yuzde)
        {
            _mediaPlayer.Position = yuzde / 100f;
        }

        public void GeriSar10Saniye()
        {
            if (_mediaPlayer.Length > 0)
            {
                long newTime = _mediaPlayer.Time - 10000;
                _mediaPlayer.Time = newTime < 0 ? 0 : newTime;
            }
        }

        public void IleriSar10Saniye()
        {
            if (_mediaPlayer.Length > 0)
            {
                long newTime = _mediaPlayer.Time + 10000;
                _mediaPlayer.Time = newTime > _mediaPlayer.Length ? _mediaPlayer.Length : newTime;
            }
        }

        public void Dispose()
        {
            _mediaPlayer?.Dispose();
            _libVLC?.Dispose();
        }
    }
}
