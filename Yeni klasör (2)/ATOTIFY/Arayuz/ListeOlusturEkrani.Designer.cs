namespace ATOTIFY.Arayuz
{
    partial class ListeOlusturEkrani
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2TextBox txtAd;
        private Guna.UI2.WinForms.Guna2TextBox txtAciklama;
        private Guna.UI2.WinForms.Guna2Button btnKaydet;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pbKapakResmi;
        private Guna.UI2.WinForms.Guna2ControlBox btnKapat;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAciklama = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.lblHata = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbKapakResmi = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnKapat = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbKapakResmi)).BeginInit();
            this.SuspendLayout();

            // guna2BorderlessForm1
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            this.guna2BorderlessForm1.ResizeForm = false;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ayrıntıları düzenle";

            // pbKapakResmi
            this.pbKapakResmi.BackColor = System.Drawing.Color.Transparent;
            this.pbKapakResmi.BorderRadius = 5;
            this.pbKapakResmi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pbKapakResmi.Location = new System.Drawing.Point(25, 75);
            this.pbKapakResmi.Name = "pbKapakResmi";
            this.pbKapakResmi.Size = new System.Drawing.Size(180, 180);
            this.pbKapakResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbKapakResmi.TabIndex = 6;
            this.pbKapakResmi.TabStop = false;

            // txtAd
            this.txtAd.BorderRadius = 5;
            this.txtAd.BorderThickness = 0;
            this.txtAd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtAd.ForeColor = System.Drawing.Color.White;
            this.txtAd.Location = new System.Drawing.Point(225, 75);
            this.txtAd.Name = "txtAd";
            this.txtAd.PlaceholderText = "Ad ekle";
            this.txtAd.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAd.Size = new System.Drawing.Size(300, 40);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextOffset = new System.Drawing.Point(5, 0);
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);

            // txtAciklama
            this.txtAciklama.BorderRadius = 5;
            this.txtAciklama.BorderThickness = 0;
            this.txtAciklama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtAciklama.ForeColor = System.Drawing.Color.White;
            this.txtAciklama.Location = new System.Drawing.Point(225, 125);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PlaceholderText = "İsteğe bağlı bir açıklama ekle";
            this.txtAciklama.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAciklama.Size = new System.Drawing.Size(300, 130);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.TextOffset = new System.Drawing.Point(5, 5);

            // lblHata
            this.lblHata.AutoSize = true;
            this.lblHata.ForeColor = System.Drawing.Color.IndianRed;
            this.lblHata.Location = new System.Drawing.Point(225, 260);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(120, 15);
            this.lblHata.TabIndex = 3;
            this.lblHata.Text = "Lütfen liste adı giriniz.";
            this.lblHata.Visible = false;

            // btnKaydet
            this.btnKaydet.BorderRadius = 20;
            this.btnKaydet.FillColor = System.Drawing.Color.White;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(405, 280);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 40);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // btnKapat
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.FillColor = System.Drawing.Color.Transparent;
            this.btnKapat.IconColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(505, 10);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(35, 35);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.HoverState.IconColor = System.Drawing.Color.IndianRed;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;

            // ListeOlusturEkrani
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(550, 340);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.pbKapakResmi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListeOlusturEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayrıntıları Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.pbKapakResmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
