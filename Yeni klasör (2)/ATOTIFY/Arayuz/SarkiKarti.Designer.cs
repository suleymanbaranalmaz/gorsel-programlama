namespace ATOTIFY.Arayuz
{
    partial class SarkiKarti
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlImg = new Guna.UI2.WinForms.Guna2Panel();
            this.lblH = new System.Windows.Forms.Label();
            this.pbKapak = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSarkiAdi = new System.Windows.Forms.Label();
            this.lblSanatci = new System.Windows.Forms.Label();
            this.pnlImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKapak)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImg
            // 
            this.pnlImg.BackColor = System.Drawing.Color.Transparent;
            this.pnlImg.BorderRadius = 5;
            this.pnlImg.Controls.Add(this.pbKapak);
            this.pnlImg.Controls.Add(this.lblH);
            this.pnlImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlImg.Location = new System.Drawing.Point(15, 15);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(150, 150);
            this.pnlImg.TabIndex = 0;
            // 
            // lblH
            // 
            this.lblH.BackColor = System.Drawing.Color.Transparent;
            this.lblH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblH.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblH.ForeColor = System.Drawing.Color.White;
            this.lblH.Location = new System.Drawing.Point(0, 0);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(150, 150);
            this.lblH.TabIndex = 0;
            this.lblH.Text = "♪";
            this.lblH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbKapak
            // 
            this.pbKapak.BackColor = System.Drawing.Color.Transparent;
            this.pbKapak.BorderRadius = 5;
            this.pbKapak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbKapak.Location = new System.Drawing.Point(0, 0);
            this.pbKapak.Name = "pbKapak";
            this.pbKapak.Size = new System.Drawing.Size(150, 150);
            this.pbKapak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKapak.TabIndex = 1;
            this.pbKapak.TabStop = false;
            this.pbKapak.Visible = false;
            // 
            // lblSarkiAdi
            // 
            this.lblSarkiAdi.AutoEllipsis = true;
            this.lblSarkiAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblSarkiAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSarkiAdi.ForeColor = System.Drawing.Color.White;
            this.lblSarkiAdi.Location = new System.Drawing.Point(15, 175);
            this.lblSarkiAdi.Name = "lblSarkiAdi";
            this.lblSarkiAdi.Size = new System.Drawing.Size(150, 19);
            this.lblSarkiAdi.TabIndex = 1;
            this.lblSarkiAdi.Text = "Şarkı Adı";
            // 
            // lblSanatci
            // 
            this.lblSanatci.AutoEllipsis = true;
            this.lblSanatci.BackColor = System.Drawing.Color.Transparent;
            this.lblSanatci.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSanatci.ForeColor = System.Drawing.Color.Gray;
            this.lblSanatci.Location = new System.Drawing.Point(15, 200);
            this.lblSanatci.Name = "lblSanatci";
            this.lblSanatci.Size = new System.Drawing.Size(150, 15);
            this.lblSanatci.TabIndex = 2;
            this.lblSanatci.Text = "Sanatçı Adı";
            // 
            // SarkiKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.lblSanatci);
            this.Controls.Add(this.lblSarkiAdi);
            this.Controls.Add(this.pnlImg);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "SarkiKarti";
            this.Size = new System.Drawing.Size(180, 240);
            this.pnlImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKapak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlImg;
        private System.Windows.Forms.Label lblH;
        private Guna.UI2.WinForms.Guna2PictureBox pbKapak;
        private System.Windows.Forms.Label lblSarkiAdi;
        private System.Windows.Forms.Label lblSanatci;
    }
}
