using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ATOTIFY.Veritabani;

namespace ATOTIFY.Arayuz
{
    public partial class GirisEkrani : Form
    {
        private AppDbContext _dbContext;

        private bool IsDesignMode()
        {
            if (this.DesignMode) return true;
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return true;
            if (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv") return true;
            return false;
        }

        public GirisEkrani()
        {
            InitializeComponent();
            if (IsDesignMode()) return;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (IsDesignMode()) return;

            _dbContext = new AppDbContext();

            try 
            {
                string createTableSql = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='PlayHistories' and xtype='U')
                CREATE TABLE PlayHistories (
                    Id INT IDENTITY(1,1) PRIMARY KEY,
                    UserId INT NOT NULL FOREIGN KEY REFERENCES Users(Id),
                    SongId INT NOT NULL FOREIGN KEY REFERENCES Songs(Id),
                    PlayedAt DATETIME2 NOT NULL
                );";
                Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions.ExecuteSqlRaw(_dbContext.Database, createTableSql);
            } 
            catch { }

            var animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            animate.TargetForm = this;
            animate.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            animate.Interval = 500;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string username = txtKullaniciAdi.Text;
            string password = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi girin.");
                return;
            }

            try
            {
                var user = _dbContext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    this.Hide();
                    var anaEkran = new AnaEkran(user);
                    anaEkran.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş yapılırken bir hata oluştu: " + ex.Message);
            }
        }

        private void lblKayitOl_Click(object sender, EventArgs e)
        {
            var kayitEkrani = new KayitEkrani();
            kayitEkrani.ShowDialog();
        }
    }
}
