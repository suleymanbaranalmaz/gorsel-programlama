using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ATOTIFY.Veritabani;
using Microsoft.EntityFrameworkCore;
using Guna.UI2.WinForms;

namespace ATOTIFY.Arayuz
{
    [System.ComponentModel.DesignerCategory("Code")]
    public class DatabaseViewer : Form
    {
        private AppDbContext _dbContext;
        private Guna2DataGridView dgvData;
        private ComboBox cbTables;
        
        public DatabaseViewer()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
        }
        
        private void InitializeComponent()
        {
            this.Text = "ATOTIFY - Veritabanı Görüntüleyici";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(18, 18, 18);
            
            var pnlTop = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Color.FromArgb(24, 24, 24) };
            this.Controls.Add(pnlTop);
            
            var lblTitle = new Label { Text = "Tablo Seç:", ForeColor = Color.White, Location = new Point(20, 20), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            pnlTop.Controls.Add(lblTitle);
            
            cbTables = new ComboBox { Location = new Point(100, 18), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            cbTables.Items.AddRange(new object[] { "Songs", "Playlists", "Users", "PlaylistSongs" });
            cbTables.SelectedIndexChanged += CbTables_SelectedIndexChanged;
            pnlTop.Controls.Add(cbTables);
            
            dgvData = new Guna2DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.FromArgb(18, 18, 18),
                GridColor = Color.FromArgb(40, 40, 40),
                ThemeStyle = {
                    HeaderStyle = { BackColor = Color.FromArgb(29, 185, 84), ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold) },
                    RowsStyle = { BackColor = Color.FromArgb(30, 30, 30), ForeColor = Color.White, SelectionBackColor = Color.FromArgb(40, 40, 40), SelectionForeColor = Color.White }
                },
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false
            };
            this.Controls.Add(dgvData);
            
            cbTables.SelectedIndex = 0; // Trigger load
        }
        
        private void CbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table = cbTables.SelectedItem.ToString();
            dgvData.DataSource = null;
            
            if (table == "Songs") dgvData.DataSource = _dbContext.Songs.ToList();
            else if (table == "Playlists") dgvData.DataSource = _dbContext.Playlists.ToList();
            else if (table == "Users") dgvData.DataSource = _dbContext.Users.ToList();
            else if (table == "PlaylistSongs") dgvData.DataSource = _dbContext.PlaylistSongs.Include(ps => ps.Song).Select(ps => new { ps.PlaylistId, ps.Song.Title, ps.AddedAt }).ToList();
        }
        
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _dbContext?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
