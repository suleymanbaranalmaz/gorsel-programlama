using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ATOTIFY.Veritabani;
using ATOTIFY.Servisler;
using ATOTIFY.Modeller;
using System.Net;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace ATOTIFY.Arayuz
{
    public partial class AnaEkran : Form
    {
        private OynaticiServisi _oynaticiServisi;
        private AppDbContext _dbContext;
        private int? _currentPlaylistId;
        private List<Song> _currentDisplayedSongs = new List<Song>();
        private static readonly Dictionary<string, Image> _imageCache = new Dictionary<string, Image>();
        private User _currentUser;

        private Timer _fadeTimer;
        private float _opacity = 0;
        
        private bool IsDesignMode()
        {
            if (this.DesignMode) return true;
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return true;
            if (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv") return true;
            return false;
        }
        
        public AnaEkran(User loggedInUser = null)
        {
            InitializeComponent();
            
            if (IsDesignMode()) return;
            
            _currentUser = loggedInUser;

            // Tasarım ekranında sorun çıkmaması için servisleri OnLoad'da başlatacağız
            // Ama event bağlamalarını burada yapabiliriz
        }

        private void GuncelleSesIkonu(int vol)
        {
            lblSesIkon.Text = "\uE720";
            if (vol == 0) lblSesIkon.ForeColor = Color.Red;
            else lblSesIkon.ForeColor = Color.Gray;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (IsDesignMode()) return;

            try 
            {
                // Ağır işleri buraya taşıdık
                _dbContext = new AppDbContext();
                _oynaticiServisi = new OynaticiServisi();
                InitializePlayerUI();

                _oynaticiServisi.OnSongChanged += Oynatici_SarkiDegisti;
                _oynaticiServisi.OnProgressChanged += Oynatici_ZamanDegisti;
                
                trackZaman.Scroll += (s, ev) => _oynaticiServisi.PozisyonAyarla(trackZaman.Value);
                trackSes.Scroll += (s, ev) => { _oynaticiServisi.SesSeviyesiAyarla(trackSes.Value); GuncelleSesIkonu(trackSes.Value); };
                
                btnOynatDuraklat.Click += (s, ev) => _oynaticiServisi.DuraklatVeyaDevamEt();
                btnOnceki.Click += async (s, ev) => await _oynaticiServisi.OncekiSarkiAsync();
                btnSonraki.Click += async (s, ev) => await _oynaticiServisi.SonrakiSarkiAsync();
                
                btnAnaSayfa.Click += async (s, ev) => await LoadSarkilarAsync();
                btnYeniListe.Click += (s, ev) => YeniListeOlustur();
                
                // Search Box Fixes
                txtAra.DefaultText = "Ne çalmak istiyorsun?";
                txtAra.Enter += (s, ev) => { if (txtAra.Text == "Ne çalmak istiyorsun?") txtAra.Text = ""; };
                txtAra.Leave += (s, ev) => { if (string.IsNullOrWhiteSpace(txtAra.Text)) txtAra.Text = "Ne çalmak istiyorsun?"; };
                txtAra.KeyDown += async (s, ev) => { if (ev.KeyCode == Keys.Enter) { ev.SuppressKeyPress = true; await AraAsync(txtAra.Text); } };

                _fadeTimer = new Timer { Interval = 20 };
                _fadeTimer.Tick += (s, ev) => {
                    _opacity += 0.05f;
                    if (_opacity >= 1) { _opacity = 1; _fadeTimer.Stop(); }
                    int alpha = (int)(_opacity * 255);
                    lblSarkiAdi.ForeColor = Color.FromArgb(alpha, Color.White);
                    lblSanatci.ForeColor = Color.FromArgb(alpha, Color.Gray);
                };

                // Fix flp scrolls and icons
                vScrollBarIcerik.BindingContainer = flpIcerik;
                vScrollBarListeler.BindingContainer = flpListeler;
                
                // Re-apply icons in code for safety
                btnAnaSayfa.Text = "\uE80F  Ana Sayfa";
                btnKitaplik.Text = "\uE8F1  Kitaplığın";

                LoadPlaylists(); 
                await LoadSarkilarAsync(); 
            } 
            catch (Exception ex) 
            {
                MessageBox.Show("Uygulama başlatılırken bir hata oluştu: " + ex.Message);
            }
        }


        private void InitializePlayerUI()
        {
            trackSes.Value = 100;
        }

        private async void Oynatici_SarkiDegisti(object sender, (Song sarki, bool isPlaying) e)
        {
            if (InvokeRequired) { Invoke(new Action(() => Oynatici_SarkiDegisti(sender, e))); return; }
            
            _opacity = 0;
            lblSarkiAdi.ForeColor = Color.Transparent;
            lblSanatci.ForeColor = Color.Transparent;
            
            lblSarkiAdi.Text = e.sarki.Title; 
            lblSanatci.Text = e.sarki.Artist; 
            trackZaman.Value = 0;
            btnOynatDuraklat.Text = e.isPlaying ? "\uE769" : "\uE768"; 
            
            pnlKapakFallback.FillColor = GetColorForSong(e.sarki.Title);
            lblKapakHarf.Text = e.sarki.Title.Length > 0 ? e.sarki.Title[0].ToString().ToUpper() : "♪";
            
            if (!string.IsNullOrEmpty(e.sarki.CoverUrl))
            {
                var img = await ResimYukleAsync(e.sarki.CoverUrl);
                if (img != null) { pbKapak.Image = img; pbKapak.Visible = true; pbKapak.BringToFront(); }
                else { pbKapak.Visible = false; }
            }
            else { pbKapak.Visible = false; }

            _fadeTimer.Start();
            
            // Dinleme geçmişine kaydet
            if (e.isPlaying && _currentUser != null && e.sarki.Id > 0)
            {
                Task.Run(() =>
                {
                    try
                    {
                        using (var ctx = new AppDbContext())
                        {
                            ctx.PlayHistories.Add(new PlayHistory
                            {
                                UserId = _currentUser.Id,
                                SongId = e.sarki.Id,
                                PlayedAt = DateTime.Now
                            });
                            ctx.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Dinleme geçmişi kaydedilemedi: " + ex.Message);
                    }
                });
            }
        }

        private void Oynatici_ZamanDegisti(object sender, float yuzde)
        {
            if (InvokeRequired) { Invoke(new Action(() => Oynatici_ZamanDegisti(sender, yuzde))); return; }
            trackZaman.Value = Math.Min(100, Math.Max(0, (int)yuzde));
            long currentSec = _oynaticiServisi.GetCurrentTime() / 1000;
            long totalSec = _oynaticiServisi.GetTotalTime() / 1000;
            lblZamanBas.Text = string.Format("{0}:{1:D2}", currentSec / 60, currentSec % 60);
            lblZamanSon.Text = string.Format("{0}:{1:D2}", totalSec / 60, totalSec % 60);
        }

        private async Task LoadSarkilarAsync()
        {
            try 
            {
                _currentPlaylistId = null;
                flpIcerik.SuspendLayout();
                flpIcerik.Controls.Clear();
                flpIcerik.FlowDirection = FlowDirection.LeftToRight;
                flpIcerik.WrapContents = true;
                var spotify = new SpotifyServisi(); 
                await spotify.BaslatAsync();
                var dbSarkilar = await _dbContext.Songs.AsNoTracking().ToListAsync();
                var mockSarkilar = await spotify.AnaSayfaSarkilariniGetirAsync();
                var hepsi = new List<Song>(dbSarkilar);
                foreach (var m in mockSarkilar) if (!hepsi.Any(x => x.YoutubeId == m.YoutubeId)) hepsi.Add(m);
                
                _currentDisplayedSongs = hepsi;
                foreach (var s in hepsi) flpIcerik.Controls.Add(CreateSongCard(s));
                flpIcerik.ResumeLayout();
            } catch { }
        }

        private async Task AraAsync(string query)
        {
            if (string.IsNullOrWhiteSpace(query) || query == "Ne çalmak istiyorsun?") return;
            var sarkilar = await new SpotifyServisi().SarkiAraAsync(query);
            _currentDisplayedSongs = sarkilar;
            flpIcerik.SuspendLayout();
            flpIcerik.Controls.Clear();
            flpIcerik.FlowDirection = FlowDirection.LeftToRight;
            flpIcerik.WrapContents = true;
            foreach (var s in sarkilar) flpIcerik.Controls.Add(CreateSongCard(s));
            flpIcerik.ResumeLayout();
        }

        private SarkiKarti CreateSongCard(Song sarki, int? playlistId = null)
        {
            var kart = new SarkiKarti();
            kart.SetData(sarki);
            
            if (!string.IsNullOrEmpty(sarki.CoverUrl)) { 
                Task.Run(async () => { 
                    var img = await ResimYukleAsync(sarki.CoverUrl); 
                    if (img != null) {
                        try {
                            kart.Invoke(new Action(() => kart.SetData(sarki, img))); 
                        } catch { }
                    }
                }); 
            }
            
            kart.SongClicked += async (s, e) => {
                _oynaticiServisi.SetQueue(_currentDisplayedSongs, _currentDisplayedSongs.IndexOf(sarki));
                await _oynaticiServisi.SarkiCalAsync(sarki);
            };
            
            kart.SongRightClicked += (s, e) => {
                GosterSarkiMenusu(sarki, playlistId, (Control)s, e.Location);
            };
            
            return kart;
        }

        private Color GetColorForSong(string t) { int hash = 0; foreach (char c in (t ?? "")) hash = c + (hash << 6) + (hash << 16) - hash; Random r = new Random(hash); return Color.FromArgb(r.Next(50, 150), r.Next(50, 150), r.Next(50, 150)); }

        private void GosterSarkiMenusu(Song sarki, int? plId, Control c, Point pos)
        {
            var menu = new ContextMenuStrip { ShowImageMargin = false, BackColor = Color.FromArgb(40, 40, 40), ForeColor = Color.White };
            var add = new ToolStripMenuItem("Kitaplığa Ekle");
            int userId = _currentUser?.Id ?? 1;
            foreach (var p in _dbContext.Playlists.Where(x => x.UserId == userId).ToList()) { var item = new ToolStripMenuItem(p.Name); item.Click += (s, e) => SarkiyiPlaylisteEkle(p.Id, sarki); add.DropDownItems.Add(item); }
            menu.Items.Add(add);
            if (plId.HasValue) { var rem = new ToolStripMenuItem("Bu Listeden Kaldır"); rem.Click += (s, e) => SarkiPlaylisttenCikar(plId.Value, sarki); menu.Items.Add(rem); }
            menu.Show(c, pos);
        }

        private async void SarkiyiPlaylisteEkle(int plId, Song sarki) { try { using (var ctx = new AppDbContext()) { var dbS = await ctx.Songs.FirstOrDefaultAsync(s => s.YoutubeId == sarki.YoutubeId); if (dbS == null) { dbS = ctx.Songs.Add(new Song { Title = sarki.Title, Artist = sarki.Artist, YoutubeId = sarki.YoutubeId, CoverUrl = sarki.CoverUrl, DurationSeconds = sarki.DurationSeconds }).Entity; await ctx.SaveChangesAsync(); } if (!await ctx.PlaylistSongs.AnyAsync(ps => ps.PlaylistId == plId && ps.SongId == dbS.Id)) { ctx.PlaylistSongs.Add(new PlaylistSong { PlaylistId = plId, SongId = dbS.Id, AddedAt = DateTime.Now }); await ctx.SaveChangesAsync(); } } MessageBox.Show("Eklendi!"); } catch { } }

        private async void SarkiPlaylisttenCikar(int plId, Song sarki) { using (var ctx = new AppDbContext()) { var ps = await ctx.PlaylistSongs.FirstOrDefaultAsync(x => x.PlaylistId == plId && x.SongId == sarki.Id); if (ps != null) { ctx.PlaylistSongs.Remove(ps); await ctx.SaveChangesAsync(); } } LoadPlaylistDetay(plId); }

        private void LoadPlaylists()
        {
            flpListeler.Controls.Clear();
            int userId = _currentUser?.Id ?? 1;
            foreach (var pl in _dbContext.Playlists.Where(p => p.UserId == userId).ToList()) 
            {
                var btn = new Guna2Button { Text = "  " + pl.Name, Width = 185, Height = 35, FillColor = Color.Transparent, ForeColor = Color.Gray, TextAlign = HorizontalAlignment.Left, BorderRadius = 5, Animated = true };
                btn.BorderThickness = 0;
                btn.CheckedState.BorderColor = Color.Transparent;
                btn.CheckedState.FillColor = Color.Transparent;
                btn.PressedColor = Color.Transparent;
                btn.Click += (s, e) => LoadPlaylistDetay(pl.Id);
                var btnD = new Guna2Button { Text = "✕", Width = 30, Height = 35, FillColor = Color.Transparent, ForeColor = Color.FromArgb(40, 40, 40), Font = new Font("Segoe UI", 9F) };
                btnD.HoverState.ForeColor = Color.Red;
                btnD.Click += (s, e) => SilPlaylist(pl.Id);
                var p = new FlowLayoutPanel { Width = 220, Height = 40, WrapContents = false }; 
                p.Controls.AddRange(new Control[] { btn, btnD });
                flpListeler.Controls.Add(p);
            }
        }

        private async void SilPlaylist(int id) { if (MessageBox.Show("Silinsin mi?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes) { var pl = _dbContext.Playlists.Find(id); if (pl != null) { _dbContext.Playlists.Remove(pl); await _dbContext.SaveChangesAsync(); LoadPlaylists(); if (_currentPlaylistId == id) await LoadSarkilarAsync(); } } }

        private void LoadPlaylistDetay(int plId)
        {
            _currentPlaylistId = plId;
            var pl = _dbContext.Playlists.Include(p => p.PlaylistSongs).ThenInclude(ps => ps.Song).FirstOrDefault(p => p.Id == plId);
            if (pl == null) return;
            
            _currentDisplayedSongs = pl.PlaylistSongs.Select(ps => ps.Song).ToList();
            
            flpIcerik.SuspendLayout(); flpIcerik.Controls.Clear(); flpIcerik.FlowDirection = FlowDirection.TopDown; flpIcerik.WrapContents = false;
            var header = new Guna2Panel { Width = flpIcerik.ClientSize.Width - 50, Height = 150, FillColor = Color.FromArgb(30, 30, 30), BorderRadius = 10, Margin = new Padding(10) };
            header.Controls.Add(new Label { Text = pl.Name, Font = new Font("Segoe UI", 24, FontStyle.Bold), ForeColor = Color.White, Location = new Point(20, 30), AutoSize = true, BackColor = Color.Transparent });
            var btnPlay = new Guna2Button { Text = "▶ Çal", FillColor = Color.FromArgb(29, 185, 84), ForeColor = Color.Black, BorderRadius = 20, Size = new Size(100, 40), Location = new Point(20, 90), Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            btnPlay.Click += async (s, e) => { if (_currentDisplayedSongs.Count > 0) { _oynaticiServisi.SetQueue(_currentDisplayedSongs, 0); await _oynaticiServisi.SarkiCalAsync(_currentDisplayedSongs[0]); } };
            header.Controls.Add(btnPlay);
            flpIcerik.Controls.Add(header);
            foreach (var ps in pl.PlaylistSongs.OrderBy(x => x.AddedAt)) 
            {
                var row = new Guna2Panel { Width = flpIcerik.ClientSize.Width - 50, Height = 50, BorderRadius = 5, Cursor = Cursors.Hand, Margin = new Padding(10, 2, 10, 2) };
                row.Controls.Add(new Label { Text = ps.Song.Title, ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(20, 15), Width = 300, AutoEllipsis = true, BackColor = Color.Transparent });
                row.Controls.Add(new Label { Text = ps.Song.Artist, ForeColor = Color.Gray, Font = new Font("Segoe UI", 9), Location = new Point(330, 16), Width = 200, AutoEllipsis = true, BackColor = Color.Transparent });
                row.DoubleClick += async (s, e) => { _oynaticiServisi.SetQueue(_currentDisplayedSongs, _currentDisplayedSongs.IndexOf(ps.Song)); await _oynaticiServisi.SarkiCalAsync(ps.Song); };
                row.MouseDown += (s, e) => { if (e.Button == MouseButtons.Right) GosterSarkiMenusu(ps.Song, plId, (Control)s, e.Location); };
                flpIcerik.Controls.Add(row);
            }
            flpIcerik.ResumeLayout();
        }

        private void YeniListeOlustur() { var frm = new ListeOlusturEkrani(); if (frm.ShowDialog() == DialogResult.OK) { int userId = _currentUser?.Id ?? 1; _dbContext.Playlists.Add(new Playlist { Name = frm.PlaylistName, UserId = userId, CreatedAt = DateTime.Now }); _dbContext.SaveChanges(); LoadPlaylists(); } }

        private async Task<Image> ResimYukleAsync(string url) { if (string.IsNullOrEmpty(url)) return null; if (_imageCache.ContainsKey(url)) return _imageCache[url]; try { using (var wc = new WebClient()) { byte[] data = await wc.DownloadDataTaskAsync(url); using (var ms = new MemoryStream(data)) { var img = Image.FromStream(ms); _imageCache[url] = img; return img; } } } catch { return null; } }
    }
}