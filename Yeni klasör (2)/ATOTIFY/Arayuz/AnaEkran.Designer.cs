namespace ATOTIFY.Arayuz
{
    partial class AnaEkran
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSol = new Guna.UI2.WinForms.Guna2Panel();
            this.vScrollBarListeler = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.btnKitaplik = new Guna.UI2.WinForms.Guna2Button();
            this.btnAnaSayfa = new Guna.UI2.WinForms.Guna2Button();
            this.flpListeler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnYeniListe = new Guna.UI2.WinForms.Guna2Button();
            this.pnlKapakFallback = new Guna.UI2.WinForms.Guna2Panel();
            this.lblKapakHarf = new System.Windows.Forms.Label();
            this.pbKapak = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSarkiAdi = new System.Windows.Forms.Label();
            this.lblSanatci = new System.Windows.Forms.Label();
            this.pnlAlt = new Guna.UI2.WinForms.Guna2Panel();
            this.lblZamanSon = new System.Windows.Forms.Label();
            this.lblZamanBas = new System.Windows.Forms.Label();
            this.trackZaman = new Guna.UI2.WinForms.Guna2TrackBar();
            this.pnlSolBilgi = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSagSes = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSesIkon = new System.Windows.Forms.Label();
            this.trackSes = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btnSonraki = new Guna.UI2.WinForms.Guna2Button();
            this.btnOynatDuraklat = new Guna.UI2.WinForms.Guna2Button();
            this.btnOnceki = new Guna.UI2.WinForms.Guna2Button();
            this.pnlOrta = new Guna.UI2.WinForms.Guna2Panel();
            this.vScrollBarIcerik = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flpIcerik = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUstBar = new Guna.UI2.WinForms.Guna2Panel();
            this.txtAra = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKapat = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlSol.SuspendLayout();
            this.pnlKapakFallback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKapak)).BeginInit();
            this.pnlAlt.SuspendLayout();
            this.pnlSolBilgi.SuspendLayout();
            this.pnlSagSes.SuspendLayout();
            this.pnlOrta.SuspendLayout();
            this.pnlUstBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.Color.Black;
            this.pnlSol.Controls.Add(this.vScrollBarListeler);
            this.pnlSol.Controls.Add(this.btnKitaplik);
            this.pnlSol.Controls.Add(this.btnAnaSayfa);
            this.pnlSol.Controls.Add(this.flpListeler);
            this.pnlSol.Controls.Add(this.btnYeniListe);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.FillColor = System.Drawing.Color.Black;
            this.pnlSol.Location = new System.Drawing.Point(0, 0);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(240, 630);
            this.pnlSol.TabIndex = 0;
            // 
            // vScrollBarListeler
            // 
            this.vScrollBarListeler.BindingContainer = this.flpListeler;
            this.vScrollBarListeler.FillColor = System.Drawing.Color.Black;
            this.vScrollBarListeler.InUpdate = false;
            this.vScrollBarListeler.LargeChange = 10;
            this.vScrollBarListeler.Location = new System.Drawing.Point(222, 150);
            this.vScrollBarListeler.Name = "vScrollBarListeler";
            this.vScrollBarListeler.ScrollbarSize = 10;
            this.vScrollBarListeler.Size = new System.Drawing.Size(10, 468);
            this.vScrollBarListeler.TabIndex = 0;
            this.vScrollBarListeler.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.vScrollBarListeler.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // btnKitaplik
            // 
            this.btnKitaplik.Animated = true;
            this.btnKitaplik.BorderRadius = 5;
            this.btnKitaplik.FillColor = System.Drawing.Color.Transparent;
            this.btnKitaplik.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnKitaplik.ForeColor = System.Drawing.Color.Gray;
            this.btnKitaplik.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnKitaplik.Location = new System.Drawing.Point(12, 58);
            this.btnKitaplik.Name = "btnKitaplik";
            this.btnKitaplik.Size = new System.Drawing.Size(216, 45);
            this.btnKitaplik.TabIndex = 4;
            this.btnKitaplik.Text = "  Kitaplığın";
            this.btnKitaplik.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKitaplik.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Animated = true;
            this.btnAnaSayfa.BorderRadius = 5;
            this.btnAnaSayfa.FillColor = System.Drawing.Color.Transparent;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.Gray;
            this.btnAnaSayfa.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAnaSayfa.Location = new System.Drawing.Point(12, 12);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(216, 45);
            this.btnAnaSayfa.TabIndex = 3;
            this.btnAnaSayfa.Text = "  Ana Sayfa";
            this.btnAnaSayfa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAnaSayfa.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // flpListeler
            // 
            this.flpListeler.AutoScroll = true;
            this.flpListeler.Location = new System.Drawing.Point(12, 150);
            this.flpListeler.Name = "flpListeler";
            this.flpListeler.Size = new System.Drawing.Size(225, 468);
            this.flpListeler.TabIndex = 2;
            // 
            // btnYeniListe
            // 
            this.btnYeniListe.Animated = true;
            this.btnYeniListe.BorderRadius = 5;
            this.btnYeniListe.FillColor = System.Drawing.Color.Transparent;
            this.btnYeniListe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnYeniListe.ForeColor = System.Drawing.Color.Gray;
            this.btnYeniListe.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnYeniListe.Location = new System.Drawing.Point(12, 109);
            this.btnYeniListe.Name = "btnYeniListe";
            this.btnYeniListe.Size = new System.Drawing.Size(216, 35);
            this.btnYeniListe.TabIndex = 1;
            this.btnYeniListe.Text = "  Çalma Listesi Oluştur";
            this.btnYeniListe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnYeniListe.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlAlt.Controls.Add(this.lblZamanSon);
            this.pnlAlt.Controls.Add(this.lblZamanBas);
            this.pnlAlt.Controls.Add(this.trackZaman);
            this.pnlAlt.Controls.Add(this.pnlSolBilgi);
            this.pnlAlt.Controls.Add(this.pnlSagSes);
            this.pnlAlt.Controls.Add(this.btnSonraki);
            this.pnlAlt.Controls.Add(this.btnOynatDuraklat);
            this.pnlAlt.Controls.Add(this.btnOnceki);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlAlt.Location = new System.Drawing.Point(240, 530);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(860, 100);
            this.pnlAlt.TabIndex = 1;
            // 
            // lblZamanSon
            // 
            this.lblZamanSon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZamanSon.AutoSize = true;
            this.lblZamanSon.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblZamanSon.ForeColor = System.Drawing.Color.Gray;
            this.lblZamanSon.Location = new System.Drawing.Point(620, 65);
            this.lblZamanSon.Name = "lblZamanSon";
            this.lblZamanSon.Size = new System.Drawing.Size(34, 13);
            this.lblZamanSon.TabIndex = 8;
            this.lblZamanSon.Text = "00:00";
            // 
            // lblZamanBas
            // 
            this.lblZamanBas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZamanBas.AutoSize = true;
            this.lblZamanBas.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblZamanBas.ForeColor = System.Drawing.Color.Gray;
            this.lblZamanBas.Location = new System.Drawing.Point(205, 65);
            this.lblZamanBas.Name = "lblZamanBas";
            this.lblZamanBas.Size = new System.Drawing.Size(34, 13);
            this.lblZamanBas.TabIndex = 7;
            this.lblZamanBas.Text = "00:00";
            // 
            // trackZaman
            // 
            this.trackZaman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackZaman.Location = new System.Drawing.Point(245, 60);
            this.trackZaman.Name = "trackZaman";
            this.trackZaman.Size = new System.Drawing.Size(370, 23);
            this.trackZaman.TabIndex = 6;
            this.trackZaman.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.trackZaman.Value = 0;
            // 
            // pnlSolBilgi
            // 
            this.pnlSolBilgi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSolBilgi.Location = new System.Drawing.Point(0, 0);
            this.pnlSolBilgi.Name = "pnlSolBilgi";
            this.pnlSolBilgi.Size = new System.Drawing.Size(240, 100);
            this.pnlSolBilgi.TabIndex = 5;
            this.pnlSolBilgi.Controls.Add(this.pbKapak);
            this.pnlSolBilgi.Controls.Add(this.pnlKapakFallback);
            this.pnlSolBilgi.Controls.Add(this.lblSarkiAdi);
            this.pnlSolBilgi.Controls.Add(this.lblSanatci);
            // 
            // pnlKapakFallback
            // 
            this.pnlKapakFallback.BackColor = System.Drawing.Color.Transparent;
            this.pnlKapakFallback.BorderRadius = 5;
            this.pnlKapakFallback.Controls.Add(this.lblKapakHarf);
            this.pnlKapakFallback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlKapakFallback.Location = new System.Drawing.Point(20, 20);
            this.pnlKapakFallback.Name = "pnlKapakFallback";
            this.pnlKapakFallback.Size = new System.Drawing.Size(60, 60);
            this.pnlKapakFallback.TabIndex = 6;
            // 
            // lblKapakHarf
            // 
            this.lblKapakHarf.BackColor = System.Drawing.Color.Transparent;
            this.lblKapakHarf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKapakHarf.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblKapakHarf.ForeColor = System.Drawing.Color.White;
            this.lblKapakHarf.Location = new System.Drawing.Point(0, 0);
            this.lblKapakHarf.Name = "lblKapakHarf";
            this.lblKapakHarf.Size = new System.Drawing.Size(60, 60);
            this.lblKapakHarf.TabIndex = 7;
            this.lblKapakHarf.Text = "♪";
            this.lblKapakHarf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbKapak
            // 
            this.pbKapak.BackColor = System.Drawing.Color.Transparent;
            this.pbKapak.BorderRadius = 5;
            this.pbKapak.Location = new System.Drawing.Point(20, 20);
            this.pbKapak.Name = "pbKapak";
            this.pbKapak.Size = new System.Drawing.Size(60, 60);
            this.pbKapak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKapak.TabIndex = 8;
            this.pbKapak.TabStop = false;
            this.pbKapak.Visible = false;
            // 
            // lblSarkiAdi
            // 
            this.lblSarkiAdi.AutoSize = true;
            this.lblSarkiAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblSarkiAdi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSarkiAdi.ForeColor = System.Drawing.Color.White;
            this.lblSarkiAdi.Location = new System.Drawing.Point(90, 28);
            this.lblSarkiAdi.Name = "lblSarkiAdi";
            this.lblSarkiAdi.Size = new System.Drawing.Size(115, 19);
            this.lblSarkiAdi.TabIndex = 9;
            this.lblSarkiAdi.Text = "Şarkı Seçilmedi";
            // 
            // lblSanatci
            // 
            this.lblSanatci.AutoSize = true;
            this.lblSanatci.BackColor = System.Drawing.Color.Transparent;
            this.lblSanatci.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSanatci.ForeColor = System.Drawing.Color.Gray;
            this.lblSanatci.Location = new System.Drawing.Point(90, 48);
            this.lblSanatci.Name = "lblSanatci";
            this.lblSanatci.Size = new System.Drawing.Size(12, 15);
            this.lblSanatci.TabIndex = 10;
            this.lblSanatci.Text = "-";
            // 
            // pnlSagSes
            // 
            this.pnlSagSes.Controls.Add(this.lblSesIkon);
            this.pnlSagSes.Controls.Add(this.trackSes);
            this.pnlSagSes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSagSes.Location = new System.Drawing.Point(660, 0);
            this.pnlSagSes.Name = "pnlSagSes";
            this.pnlSagSes.Size = new System.Drawing.Size(200, 100);
            this.pnlSagSes.TabIndex = 4;
            // 
            // lblSesIkon
            // 
            this.lblSesIkon.AutoSize = true;
            this.lblSesIkon.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.lblSesIkon.ForeColor = System.Drawing.Color.Gray;
            this.lblSesIkon.Location = new System.Drawing.Point(25, 43);
            this.lblSesIkon.Name = "lblSesIkon";
            this.lblSesIkon.Size = new System.Drawing.Size(24, 16);
            this.lblSesIkon.TabIndex = 1;
            this.lblSesIkon.Text = "";
            // 
            // trackSes
            // 
            this.trackSes.Location = new System.Drawing.Point(55, 38);
            this.trackSes.Name = "trackSes";
            this.trackSes.Size = new System.Drawing.Size(120, 23);
            this.trackSes.TabIndex = 0;
            this.trackSes.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            // 
            // btnSonraki
            // 
            this.btnSonraki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSonraki.Animated = true;
            this.btnSonraki.FillColor = System.Drawing.Color.Transparent;
            this.btnSonraki.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSonraki.ForeColor = System.Drawing.Color.Gray;
            this.btnSonraki.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSonraki.Location = new System.Drawing.Point(470, 15);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(40, 40);
            this.btnSonraki.TabIndex = 3;
            this.btnSonraki.Text = "";
            // 
            // btnOynatDuraklat
            // 
            this.btnOynatDuraklat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOynatDuraklat.Animated = true;
            this.btnOynatDuraklat.BorderRadius = 20;
            this.btnOynatDuraklat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.btnOynatDuraklat.Font = new System.Drawing.Font("Segoe MDL2 Assets", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnOynatDuraklat.ForeColor = System.Drawing.Color.Black;
            this.btnOynatDuraklat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btnOynatDuraklat.Location = new System.Drawing.Point(410, 15);
            this.btnOynatDuraklat.Name = "btnOynatDuraklat";
            this.btnOynatDuraklat.Size = new System.Drawing.Size(40, 40);
            this.btnOynatDuraklat.TabIndex = 2;
            this.btnOynatDuraklat.Text = "";
            this.btnOynatDuraklat.TextOffset = new System.Drawing.Point(1, 0);
            // 
            // btnOnceki
            // 
            this.btnOnceki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOnceki.Animated = true;
            this.btnOnceki.FillColor = System.Drawing.Color.Transparent;
            this.btnOnceki.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnOnceki.ForeColor = System.Drawing.Color.Gray;
            this.btnOnceki.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnOnceki.Location = new System.Drawing.Point(350, 15);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(40, 40);
            this.btnOnceki.TabIndex = 1;
            this.btnOnceki.Text = "";
            // 
            // pnlOrta
            // 
            this.pnlOrta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pnlOrta.Controls.Add(this.vScrollBarIcerik);
            this.pnlOrta.Controls.Add(this.flpIcerik);
            this.pnlOrta.Controls.Add(this.pnlUstBar);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(240, 0);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(860, 530);
            this.pnlOrta.TabIndex = 2;
            // 
            // vScrollBarIcerik
            // 
            this.vScrollBarIcerik.BindingContainer = this.flpIcerik;
            this.vScrollBarIcerik.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.vScrollBarIcerik.InUpdate = false;
            this.vScrollBarIcerik.LargeChange = 10;
            this.vScrollBarIcerik.Location = new System.Drawing.Point(842, 60);
            this.vScrollBarIcerik.Name = "vScrollBarIcerik";
            this.vScrollBarIcerik.ScrollbarSize = 18;
            this.vScrollBarIcerik.Size = new System.Drawing.Size(18, 470);
            this.vScrollBarIcerik.TabIndex = 0;
            this.vScrollBarIcerik.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.vScrollBarIcerik.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // flpIcerik
            // 
            this.flpIcerik.AutoScroll = true;
            this.flpIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpIcerik.Location = new System.Drawing.Point(0, 60);
            this.flpIcerik.Name = "flpIcerik";
            this.flpIcerik.Padding = new System.Windows.Forms.Padding(20);
            this.flpIcerik.Size = new System.Drawing.Size(860, 470);
            this.flpIcerik.TabIndex = 1;
            // 
            // pnlUstBar
            // 
            this.pnlUstBar.Controls.Add(this.txtAra);
            this.pnlUstBar.Controls.Add(this.btnKapat);
            this.pnlUstBar.Controls.Add(this.btnMaximize);
            this.pnlUstBar.Controls.Add(this.btnMinimize);
            this.pnlUstBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUstBar.Location = new System.Drawing.Point(0, 0);
            this.pnlUstBar.Name = "pnlUstBar";
            this.pnlUstBar.Size = new System.Drawing.Size(860, 60);
            this.pnlUstBar.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Animated = true;
            this.txtAra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAra.BorderRadius = 15;
            this.txtAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAra.DefaultText = "Ne çalmak istiyorsun?";
            this.txtAra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAra.ForeColor = System.Drawing.Color.White;
            this.txtAra.Location = new System.Drawing.Point(20, 15);
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAra.PlaceholderText = "";
            this.txtAra.SelectedText = "";
            this.txtAra.Size = new System.Drawing.Size(300, 32);
            this.txtAra.TabIndex = 3;
            this.txtAra.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.FillColor = System.Drawing.Color.Transparent;
            this.btnKapat.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnKapat.IconColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(815, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(45, 30);
            this.btnKapat.TabIndex = 2;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(770, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 30);
            this.btnMaximize.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(725, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 30);
            this.btnMinimize.TabIndex = 0;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Black;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlSol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATOTIFY";
            this.pnlSol.ResumeLayout(false);
            this.pnlKapakFallback.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKapak)).EndInit();
            this.pnlAlt.ResumeLayout(false);
            this.pnlAlt.PerformLayout();
            this.pnlSolBilgi.ResumeLayout(false);
            this.pnlSolBilgi.PerformLayout();
            this.pnlSagSes.ResumeLayout(false);
            this.pnlSagSes.PerformLayout();
            this.pnlOrta.ResumeLayout(false);
            this.pnlUstBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSol;
        private Guna.UI2.WinForms.Guna2Panel pnlAlt;
        private Guna.UI2.WinForms.Guna2Panel pnlOrta;
        private Guna.UI2.WinForms.Guna2Button btnYeniListe;
        private System.Windows.Forms.FlowLayoutPanel flpListeler;
        private Guna.UI2.WinForms.Guna2Button btnAnaSayfa;
        private Guna.UI2.WinForms.Guna2Button btnKitaplik;
        private Guna.UI2.WinForms.Guna2Panel pnlUstBar;
        private Guna.UI2.WinForms.Guna2ControlBox btnKapat;
        private Guna.UI2.WinForms.Guna2ControlBox btnMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2TextBox txtAra;
        private System.Windows.Forms.FlowLayoutPanel flpIcerik;
        private Guna.UI2.WinForms.Guna2Button btnSonraki;
        private Guna.UI2.WinForms.Guna2Button btnOynatDuraklat;
        private Guna.UI2.WinForms.Guna2Button btnOnceki;
        private Guna.UI2.WinForms.Guna2Panel pnlSagSes;
        private Guna.UI2.WinForms.Guna2TrackBar trackSes;
        private System.Windows.Forms.Label lblSesIkon;
        private Guna.UI2.WinForms.Guna2Panel pnlSolBilgi;
        private Guna.UI2.WinForms.Guna2TrackBar trackZaman;
        private System.Windows.Forms.Label lblZamanSon;
        private System.Windows.Forms.Label lblZamanBas;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2VScrollBar vScrollBarIcerik;
        private Guna.UI2.WinForms.Guna2VScrollBar vScrollBarListeler;
        private Guna.UI2.WinForms.Guna2PictureBox pbKapak;
        private Guna.UI2.WinForms.Guna2Panel pnlKapakFallback;
        private System.Windows.Forms.Label lblKapakHarf;
        private System.Windows.Forms.Label lblSarkiAdi;
        private System.Windows.Forms.Label lblSanatci;
    }
}