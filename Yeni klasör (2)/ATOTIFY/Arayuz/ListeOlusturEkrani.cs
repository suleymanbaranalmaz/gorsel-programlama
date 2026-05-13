using System;
using System.Drawing;
using System.Windows.Forms;

namespace ATOTIFY.Arayuz
{
    public partial class ListeOlusturEkrani : Form
    {
        public string PlaylistName { get; private set; }
        public string PlaylistDescription { get; private set; }

        private bool IsDesignMode()
        {
            if (this.DesignMode) return true;
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return true;
            if (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv") return true;
            return false;
        }

        public ListeOlusturEkrani()
        {
            InitializeComponent();
            if (IsDesignMode()) return;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                lblHata.Visible = true;
                return;
            }

            PlaylistName = txtAd.Text;
            PlaylistDescription = txtAciklama.Text;
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            lblHata.Visible = false;
        }
    }
}
