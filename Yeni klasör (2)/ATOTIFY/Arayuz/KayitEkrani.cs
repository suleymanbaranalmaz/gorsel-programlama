using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ATOTIFY.Modeller;
using ATOTIFY.Veritabani;

namespace ATOTIFY.Arayuz
{
    public partial class KayitEkrani : Form
    {
        private AppDbContext _dbContext;

        private bool IsDesignMode()
        {
            if (this.DesignMode) return true;
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return true;
            if (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv") return true;
            return false;
        }

        public KayitEkrani()
        {
            InitializeComponent();
            if (IsDesignMode()) return;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (IsDesignMode()) return;

            _dbContext = new AppDbContext();

            var animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            animate.TargetForm = this;
            animate.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            animate.Interval = 500;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string username = txtKullaniciAdi.Text;
            string email = txtEposta.Text;
            string password = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            if (_dbContext.Users.Any(u => u.Username == username))
            {
                MessageBox.Show("Bu kullanıcı adı zaten alınmış.");
                return;
            }

            try
            {
                var newUser = new User
                {
                    Username = username,
                    Email = email,
                    Password = password, // Not: Gerçek projede hash'lenmeli!
                    CreatedAt = DateTime.Now
                };

                _dbContext.Users.Add(newUser);
                _dbContext.SaveChanges();

                MessageBox.Show("Kayıt başarılı! Şimdi giriş yapabilirsiniz.");
                this.Close();
            }
            catch (Exception ex)
            {
                string innerMessage = ex.InnerException != null ? "\nDetay: " + ex.InnerException.Message : "";
                MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message + innerMessage, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
