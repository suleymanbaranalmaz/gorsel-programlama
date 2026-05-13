namespace ATOTIFY.Arayuz
{
    partial class GirisEkrani
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2TextBox txtKullaniciAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private Guna.UI2.WinForms.Guna2Button btnGiris;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblKayitOl;
        private Guna.UI2.WinForms.Guna2ControlBox btnKapat;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.txtKullaniciAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGiris = new Guna.UI2.WinForms.Guna2Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblKayitOl = new System.Windows.Forms.Label();
            this.btnKapat = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);

            this.pnlMain.SuspendLayout();
            this.SuspendLayout();

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.pnlMain.Controls.Add(this.btnKapat);
            this.pnlMain.Controls.Add(this.lblBaslik);
            this.pnlMain.Controls.Add(this.txtKullaniciAdi);
            this.pnlMain.Controls.Add(this.txtSifre);
            this.pnlMain.Controls.Add(this.btnGiris);
            this.pnlMain.Controls.Add(this.lblKayitOl);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(400, 500);

            // lblBaslik
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(50, 80);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(155, 45);
            this.lblBaslik.Text = "Giriş Yap";

            // txtKullaniciAdi
            this.txtKullaniciAdi.BorderRadius = 5;
            this.txtKullaniciAdi.BorderThickness = 0;
            this.txtKullaniciAdi.FillColor = System.Drawing.Color.FromArgb(36, 36, 36);
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(50, 180);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(300, 45);

            // txtSifre
            this.txtSifre.BorderRadius = 5;
            this.txtSifre.BorderThickness = 0;
            this.txtSifre.FillColor = System.Drawing.Color.FromArgb(36, 36, 36);
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.Location = new System.Drawing.Point(50, 240);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.PlaceholderText = "Şifre";
            this.txtSifre.Size = new System.Drawing.Size(300, 45);

            // btnGiris
            this.btnGiris.BorderRadius = 22;
            this.btnGiris.FillColor = System.Drawing.Color.FromArgb(29, 185, 84);
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Location = new System.Drawing.Point(50, 320);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(300, 45);
            this.btnGiris.Text = "OTURUM AÇ";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);

            // lblKayitOl
            this.lblKayitOl.AutoSize = true;
            this.lblKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKayitOl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKayitOl.ForeColor = System.Drawing.Color.Gray;
            this.lblKayitOl.Location = new System.Drawing.Point(135, 390);
            this.lblKayitOl.Name = "lblKayitOl";
            this.lblKayitOl.Size = new System.Drawing.Size(130, 15);
            this.lblKayitOl.Text = "Hesabın yok mu? Kaydol";
            this.lblKayitOl.Click += new System.EventHandler(this.lblKayitOl_Click);

            // btnKapat
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.FillColor = System.Drawing.Color.Transparent;
            this.btnKapat.IconColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(355, 10);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(35, 25);

            // guna2DragControl1
            this.guna2DragControl1.TargetControl = this.pnlMain;

            // GirisEkrani
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATOTIFY - Giriş";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
