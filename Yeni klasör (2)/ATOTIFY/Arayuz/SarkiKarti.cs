using System;
using System.Drawing;
using System.Windows.Forms;
using ATOTIFY.Modeller;

namespace ATOTIFY.Arayuz
{
    public partial class SarkiKarti : UserControl
    {
        public Song Sarki { get; private set; }
        public event EventHandler<Song> SongClicked;
        public event EventHandler<MouseEventArgs> SongRightClicked;

        public SarkiKarti()
        {
            InitializeComponent();
            
            // Tıklama olaylarını haritalandır (UserControl'ün neresine tıklanırsa tıklansın tetiklenmesi için)
            EventHandler clickHandler = (s, e) => SongClicked?.Invoke(this, Sarki);
            MouseEventHandler rightClickHandler = (s, e) => {
                if (e.Button == MouseButtons.Right) SongRightClicked?.Invoke(this, e);
            };

            this.Click += clickHandler;
            this.MouseDown += rightClickHandler;
            
            foreach (Control c in this.Controls)
            {
                c.Click += clickHandler;
                c.MouseDown += rightClickHandler;
                if (c == pnlImg)
                {
                    foreach (Control child in pnlImg.Controls)
                    {
                        child.Click += clickHandler;
                        child.MouseDown += rightClickHandler;
                    }
                }
            }
        }

        public void SetData(Song sarki, Image coverImage = null)
        {
            Sarki = sarki;
            lblSarkiAdi.Text = sarki.Title;
            lblSanatci.Text = sarki.Artist;
            lblH.Text = sarki.Title.Length > 0 ? sarki.Title[0].ToString().ToUpper() : "♪";
            pnlImg.FillColor = GetColorForSong(sarki.Title);

            if (coverImage != null)
            {
                pbKapak.Image = coverImage;
                pbKapak.Visible = true;
                pbKapak.BringToFront();
            }
            else
            {
                pbKapak.Visible = false;
            }
        }

        private Color GetColorForSong(string t)
        {
            int hash = 0; 
            foreach (char c in (t ?? "")) hash = c + (hash << 6) + (hash << 16) - hash; 
            Random r = new Random(hash); 
            return Color.FromArgb(r.Next(50, 150), r.Next(50, 150), r.Next(50, 150));
        }
    }
}
