namespace ATOTIFY.Arayuz
{
    partial class KayitEkrani
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2TextBox txtKullaniciAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtEposta;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private Guna.UI2.WinForms.Guna2Button btnKayitOl;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblGeriDon;
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
            this.txtEposta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKayitOl = new Guna.UI2.WinForms.Guna2Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblGeriDon = new System.Windows.Forms.Label();
            this.btnKapat = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);

            this.pnlMain.SuspendLayout();
            this.SuspendLayout();

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.pnlMain.Controls.Add(this.btnKapat);
            this.pnlMain.Controls.Add(this.lblBaslik);
            this.pnlMain.Controls.Add(this.txtKullaniciAdi);
            this.pnlMain.Controls.Add(this.txtEposta);
            this.pnlMain.Controls.Add(this.txtSifre);
            this.pnlMain.Controls.Add(this.btnKayitOl);
            this.pnlMain.Controls.Add(this.lblGeriDon);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(400, 500);

            // lblBaslik
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(50, 60);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(127, 45);
            this.lblBaslik.Text = "Üye Ol";

            // txtKullaniciAdi
            this.txtKullaniciAdi.BorderRadius = 5;
            this.txtKullaniciAdi.BorderThickness = 0;
            this.txtKullaniciAdi.FillColor = System.Drawing.Color.FromArgb(36, 36, 36);
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(50, 140);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(300, 45);

            // txtEposta
            this.txtEposta.BorderRadius = 5;
            this.txtEposta.BorderThickness = 0;
            this.txtEposta.FillColor = System.Drawing.Color.FromArgb(36, 36, 36);
            this.txtEposta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEposta.ForeColor = System.Drawing.Color.White;
            this.txtEposta.Location = new System.Drawing.Point(50, 200);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.PlaceholderText = "E-posta";
            this.txtEposta.Size = new System.Drawing.Size(300, 45);

            // txtSifre
            this.txtSifre.BorderRadius = 5;
            this.txtSifre.BorderThickness = 0;
            this.txtSifre.FillColor = System.Drawing.Color.FromArgb(36, 36, 36);
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.Location = new System.Drawing.Point(50, 260);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.PlaceholderText = "Şifre";
            this.txtSifre.Size = new System.Drawing.Size(300, 45);

            // btnKayitOl
            this.btnKayitOl.BorderRadius = 22;
            this.btnKayitOl.FillColor = System.Drawing.Color.FromArgb(29, 185, 84);
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKayitOl.ForeColor = System.Drawing.Color.Black;
            this.btnKayitOl.Location = new System.Drawing.Point(50, 340);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(300, 45);
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);

            // lblGeriDon
            this.lblGeriDon.AutoSize = true;
            this.lblGeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGeriDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGeriDon.ForeColor = System.Drawing.Color.Gray;
            this.lblGeriDon.Location = new System.Drawing.Point(120, 410);
            this.lblGeriDon.Name = "lblGeriDon";
            this.lblGeriDon.Size = new System.Drawing.Size(160, 15);
            this.lblGeriDon.Text = "Zaten hesabın var mı? Giriş Yap";
            this.lblGeriDon.Click += new System.EventHandler(this.lblGeriDon_Click);

            // btnKapat
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.FillColor = System.Drawing.Color.Transparent;
            this.btnKapat.IconColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(355, 10);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(35, 25);

            // guna2DragControl1
            this.guna2DragControl1.TargetControl = this.pnlMain;

            // KayitEkrani
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KayitEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATOTIFY - Kayıt Ol";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
