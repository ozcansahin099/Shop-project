namespace ShopGiris
{
    partial class FormPersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ayarlar = new System.Windows.Forms.TabPage();
            this.lblSifreİslem = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.lblYeniSifreTekrari = new System.Windows.Forms.Label();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.lblEskiSifre = new System.Windows.Forms.Label();
            this.txtYeniSifreTekrari = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.UrunIade = new System.Windows.Forms.TabPage();
            this.dtgvUrunIadeGoster = new System.Windows.Forms.DataGridView();
            this.btnİadeEt = new System.Windows.Forms.Button();
            this.lblSatisID = new System.Windows.Forms.Label();
            this.txtSatisID = new System.Windows.Forms.TextBox();
            this.GunSonuIslemRaporu = new System.Windows.Forms.TabPage();
            this.dtgvYaptigimSatislar = new System.Windows.Forms.DataGridView();
            this.btnYaptigimSatislar = new System.Windows.Forms.Button();
            this.btnKasayiKapat = new System.Windows.Forms.Button();
            this.SatisEkran = new System.Windows.Forms.TabPage();
            this.lsvUrunGoster = new System.Windows.Forms.ListView();
            this.UrunID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunBarkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunSatisFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunStok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SatilacakAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSatisListesindenUrunSil = new System.Windows.Forms.Button();
            this.btnSatisListesineEkle = new System.Windows.Forms.Button();
            this.lblSatisAdedi = new System.Windows.Forms.Label();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtSatisAdedi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.tabControlPersonel = new System.Windows.Forms.TabControl();
            this.Ayarlar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.UrunIade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUrunIadeGoster)).BeginInit();
            this.GunSonuIslemRaporu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvYaptigimSatislar)).BeginInit();
            this.SatisEkran.SuspendLayout();
            this.tabControlPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ayarlar
            // 
            this.Ayarlar.Controls.Add(this.lblSifreİslem);
            this.Ayarlar.Controls.Add(this.panel4);
            this.Ayarlar.Location = new System.Drawing.Point(4, 22);
            this.Ayarlar.Name = "Ayarlar";
            this.Ayarlar.Padding = new System.Windows.Forms.Padding(3);
            this.Ayarlar.Size = new System.Drawing.Size(827, 378);
            this.Ayarlar.TabIndex = 4;
            this.Ayarlar.Text = "Ayarlar";
            this.Ayarlar.UseVisualStyleBackColor = true;
            // 
            // lblSifreİslem
            // 
            this.lblSifreİslem.AutoSize = true;
            this.lblSifreİslem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSifreİslem.Location = new System.Drawing.Point(125, 72);
            this.lblSifreİslem.Name = "lblSifreİslem";
            this.lblSifreİslem.Size = new System.Drawing.Size(67, 13);
            this.lblSifreİslem.TabIndex = 8;
            this.lblSifreİslem.Text = "Şifre işlemleri";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSifreDegistir);
            this.panel4.Controls.Add(this.lblYeniSifreTekrari);
            this.panel4.Controls.Add(this.lblYeniSifre);
            this.panel4.Controls.Add(this.lblEskiSifre);
            this.panel4.Controls.Add(this.txtYeniSifreTekrari);
            this.panel4.Controls.Add(this.txtYeniSifre);
            this.panel4.Controls.Add(this.txtEskiSifre);
            this.panel4.Location = new System.Drawing.Point(128, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 167);
            this.panel4.TabIndex = 9;
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.Location = new System.Drawing.Point(205, 111);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnSifreDegistir.TabIndex = 13;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = true;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // lblYeniSifreTekrari
            // 
            this.lblYeniSifreTekrari.AutoSize = true;
            this.lblYeniSifreTekrari.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYeniSifreTekrari.Location = new System.Drawing.Point(4, 64);
            this.lblYeniSifreTekrari.Name = "lblYeniSifreTekrari";
            this.lblYeniSifreTekrari.Size = new System.Drawing.Size(88, 13);
            this.lblYeniSifreTekrari.TabIndex = 11;
            this.lblYeniSifreTekrari.Text = "Yeni Şifre Tekrarı";
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYeniSifre.Location = new System.Drawing.Point(4, 38);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(52, 13);
            this.lblYeniSifre.TabIndex = 11;
            this.lblYeniSifre.Text = "Yeni Şifre";
            // 
            // lblEskiSifre
            // 
            this.lblEskiSifre.AutoSize = true;
            this.lblEskiSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEskiSifre.Location = new System.Drawing.Point(4, 12);
            this.lblEskiSifre.Name = "lblEskiSifre";
            this.lblEskiSifre.Size = new System.Drawing.Size(48, 13);
            this.lblEskiSifre.TabIndex = 3;
            this.lblEskiSifre.Text = "EskiŞifre";
            // 
            // txtYeniSifreTekrari
            // 
            this.txtYeniSifreTekrari.Location = new System.Drawing.Point(98, 61);
            this.txtYeniSifreTekrari.Name = "txtYeniSifreTekrari";
            this.txtYeniSifreTekrari.Size = new System.Drawing.Size(148, 20);
            this.txtYeniSifreTekrari.TabIndex = 7;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(98, 35);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(148, 20);
            this.txtYeniSifre.TabIndex = 7;
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(98, 9);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(148, 20);
            this.txtEskiSifre.TabIndex = 2;
            // 
            // UrunIade
            // 
            this.UrunIade.Controls.Add(this.dtgvUrunIadeGoster);
            this.UrunIade.Controls.Add(this.btnİadeEt);
            this.UrunIade.Controls.Add(this.lblSatisID);
            this.UrunIade.Controls.Add(this.txtSatisID);
            this.UrunIade.Location = new System.Drawing.Point(4, 22);
            this.UrunIade.Name = "UrunIade";
            this.UrunIade.Padding = new System.Windows.Forms.Padding(3);
            this.UrunIade.Size = new System.Drawing.Size(827, 378);
            this.UrunIade.TabIndex = 2;
            this.UrunIade.Text = "Ürün İadesi";
            this.UrunIade.UseVisualStyleBackColor = true;
            // 
            // dtgvUrunIadeGoster
            // 
            this.dtgvUrunIadeGoster.BackgroundColor = System.Drawing.Color.White;
            this.dtgvUrunIadeGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUrunIadeGoster.Location = new System.Drawing.Point(154, 120);
            this.dtgvUrunIadeGoster.Name = "dtgvUrunIadeGoster";
            this.dtgvUrunIadeGoster.Size = new System.Drawing.Size(525, 150);
            this.dtgvUrunIadeGoster.TabIndex = 3;
            // 
            // btnİadeEt
            // 
            this.btnİadeEt.Location = new System.Drawing.Point(318, 52);
            this.btnİadeEt.Name = "btnİadeEt";
            this.btnİadeEt.Size = new System.Drawing.Size(75, 23);
            this.btnİadeEt.TabIndex = 2;
            this.btnİadeEt.Text = "İade Et";
            this.btnİadeEt.UseVisualStyleBackColor = true;
            this.btnİadeEt.Click += new System.EventHandler(this.btnİadeEt_Click);
            // 
            // lblSatisID
            // 
            this.lblSatisID.AutoSize = true;
            this.lblSatisID.Location = new System.Drawing.Point(103, 57);
            this.lblSatisID.Name = "lblSatisID";
            this.lblSatisID.Size = new System.Drawing.Size(54, 13);
            this.lblSatisID.TabIndex = 1;
            this.lblSatisID.Text = "Satış ID si";
            // 
            // txtSatisID
            // 
            this.txtSatisID.Location = new System.Drawing.Point(163, 54);
            this.txtSatisID.Name = "txtSatisID";
            this.txtSatisID.Size = new System.Drawing.Size(100, 20);
            this.txtSatisID.TabIndex = 0;
            // 
            // GunSonuIslemRaporu
            // 
            this.GunSonuIslemRaporu.Controls.Add(this.dtgvYaptigimSatislar);
            this.GunSonuIslemRaporu.Controls.Add(this.btnYaptigimSatislar);
            this.GunSonuIslemRaporu.Controls.Add(this.btnKasayiKapat);
            this.GunSonuIslemRaporu.Location = new System.Drawing.Point(4, 22);
            this.GunSonuIslemRaporu.Name = "GunSonuIslemRaporu";
            this.GunSonuIslemRaporu.Padding = new System.Windows.Forms.Padding(3);
            this.GunSonuIslemRaporu.Size = new System.Drawing.Size(827, 378);
            this.GunSonuIslemRaporu.TabIndex = 1;
            this.GunSonuIslemRaporu.Text = "Gün sonu işlemi ve raporu";
            this.GunSonuIslemRaporu.UseVisualStyleBackColor = true;
            // 
            // dtgvYaptigimSatislar
            // 
            this.dtgvYaptigimSatislar.BackgroundColor = System.Drawing.Color.White;
            this.dtgvYaptigimSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvYaptigimSatislar.Location = new System.Drawing.Point(123, 96);
            this.dtgvYaptigimSatislar.Name = "dtgvYaptigimSatislar";
            this.dtgvYaptigimSatislar.Size = new System.Drawing.Size(525, 150);
            this.dtgvYaptigimSatislar.TabIndex = 2;
            // 
            // btnYaptigimSatislar
            // 
            this.btnYaptigimSatislar.Location = new System.Drawing.Point(287, 48);
            this.btnYaptigimSatislar.Name = "btnYaptigimSatislar";
            this.btnYaptigimSatislar.Size = new System.Drawing.Size(124, 23);
            this.btnYaptigimSatislar.TabIndex = 1;
            this.btnYaptigimSatislar.Text = "Yaptığım Satışlar";
            this.btnYaptigimSatislar.UseVisualStyleBackColor = true;
            this.btnYaptigimSatislar.Click += new System.EventHandler(this.btnYaptigimSatislar_Click);
            // 
            // btnKasayiKapat
            // 
            this.btnKasayiKapat.Location = new System.Drawing.Point(123, 48);
            this.btnKasayiKapat.Name = "btnKasayiKapat";
            this.btnKasayiKapat.Size = new System.Drawing.Size(109, 23);
            this.btnKasayiKapat.TabIndex = 0;
            this.btnKasayiKapat.Text = "Kasayı Kapat";
            this.btnKasayiKapat.UseVisualStyleBackColor = true;
            this.btnKasayiKapat.Click += new System.EventHandler(this.btnKasayiKapat_Click);
            // 
            // SatisEkran
            // 
            this.SatisEkran.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SatisEkran.Controls.Add(this.lsvUrunGoster);
            this.SatisEkran.Controls.Add(this.btnSatisListesindenUrunSil);
            this.SatisEkran.Controls.Add(this.btnSatisListesineEkle);
            this.SatisEkran.Controls.Add(this.lblSatisAdedi);
            this.SatisEkran.Controls.Add(this.lblBarkodNo);
            this.SatisEkran.Controls.Add(this.txtSatisAdedi);
            this.SatisEkran.Controls.Add(this.txtBarkodNo);
            this.SatisEkran.ForeColor = System.Drawing.SystemColors.Control;
            this.SatisEkran.Location = new System.Drawing.Point(4, 22);
            this.SatisEkran.Name = "SatisEkran";
            this.SatisEkran.Padding = new System.Windows.Forms.Padding(3);
            this.SatisEkran.Size = new System.Drawing.Size(827, 378);
            this.SatisEkran.TabIndex = 0;
            this.SatisEkran.Text = "Satış Ekranı";
            // 
            // lsvUrunGoster
            // 
            this.lsvUrunGoster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UrunID,
            this.UrunAd,
            this.UrunKategori,
            this.UrunBarkod,
            this.UrunSatisFiyati,
            this.UrunStok,
            this.SatilacakAdet});
            this.lsvUrunGoster.FullRowSelect = true;
            this.lsvUrunGoster.GridLines = true;
            this.lsvUrunGoster.HideSelection = false;
            this.lsvUrunGoster.Location = new System.Drawing.Point(160, 135);
            this.lsvUrunGoster.MultiSelect = false;
            this.lsvUrunGoster.Name = "lsvUrunGoster";
            this.lsvUrunGoster.Size = new System.Drawing.Size(568, 123);
            this.lsvUrunGoster.TabIndex = 10;
            this.lsvUrunGoster.UseCompatibleStateImageBehavior = false;
            this.lsvUrunGoster.View = System.Windows.Forms.View.Details;
            // 
            // UrunID
            // 
            this.UrunID.Text = "ID";
            this.UrunID.Width = 47;
            // 
            // UrunAd
            // 
            this.UrunAd.Text = "Ürün Adı";
            this.UrunAd.Width = 61;
            // 
            // UrunKategori
            // 
            this.UrunKategori.Text = "Kategorisi";
            this.UrunKategori.Width = 64;
            // 
            // UrunBarkod
            // 
            this.UrunBarkod.Text = "Barkod";
            this.UrunBarkod.Width = 79;
            // 
            // UrunSatisFiyati
            // 
            this.UrunSatisFiyati.Text = "Satış Fiyatı";
            this.UrunSatisFiyati.Width = 121;
            // 
            // UrunStok
            // 
            this.UrunStok.Text = "Stok";
            // 
            // SatilacakAdet
            // 
            this.SatilacakAdet.Text = "SatılacakAdet";
            this.SatilacakAdet.Width = 83;
            // 
            // btnSatisListesindenUrunSil
            // 
            this.btnSatisListesindenUrunSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSatisListesindenUrunSil.Location = new System.Drawing.Point(651, 61);
            this.btnSatisListesindenUrunSil.Name = "btnSatisListesindenUrunSil";
            this.btnSatisListesindenUrunSil.Size = new System.Drawing.Size(137, 23);
            this.btnSatisListesindenUrunSil.TabIndex = 6;
            this.btnSatisListesindenUrunSil.Text = "Satış Listesinden Sil";
            this.btnSatisListesindenUrunSil.UseVisualStyleBackColor = true;
            this.btnSatisListesindenUrunSil.Click += new System.EventHandler(this.btnSatisListesindenUrunSil_Click);
            // 
            // btnSatisListesineEkle
            // 
            this.btnSatisListesineEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSatisListesineEkle.Location = new System.Drawing.Point(492, 61);
            this.btnSatisListesineEkle.Name = "btnSatisListesineEkle";
            this.btnSatisListesineEkle.Size = new System.Drawing.Size(137, 23);
            this.btnSatisListesineEkle.TabIndex = 6;
            this.btnSatisListesineEkle.Text = "Satış Listesine Ekle";
            this.btnSatisListesineEkle.UseVisualStyleBackColor = true;
            this.btnSatisListesineEkle.Click += new System.EventHandler(this.btnSatisListesineEkle_Click);
            // 
            // lblSatisAdedi
            // 
            this.lblSatisAdedi.AutoSize = true;
            this.lblSatisAdedi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSatisAdedi.Location = new System.Drawing.Point(304, 66);
            this.lblSatisAdedi.Name = "lblSatisAdedi";
            this.lblSatisAdedi.Size = new System.Drawing.Size(60, 13);
            this.lblSatisAdedi.TabIndex = 5;
            this.lblSatisAdedi.Text = "Satış Adedi";
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBarkodNo.Location = new System.Drawing.Point(79, 66);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(58, 13);
            this.lblBarkodNo.TabIndex = 5;
            this.lblBarkodNo.Text = "Barkod No";
            // 
            // txtSatisAdedi
            // 
            this.txtSatisAdedi.Location = new System.Drawing.Point(385, 63);
            this.txtSatisAdedi.Name = "txtSatisAdedi";
            this.txtSatisAdedi.Size = new System.Drawing.Size(56, 20);
            this.txtSatisAdedi.TabIndex = 4;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(160, 63);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(127, 20);
            this.txtBarkodNo.TabIndex = 4;
            // 
            // tabControlPersonel
            // 
            this.tabControlPersonel.Controls.Add(this.SatisEkran);
            this.tabControlPersonel.Controls.Add(this.GunSonuIslemRaporu);
            this.tabControlPersonel.Controls.Add(this.UrunIade);
            this.tabControlPersonel.Controls.Add(this.Ayarlar);
            this.tabControlPersonel.Location = new System.Drawing.Point(24, -5);
            this.tabControlPersonel.Name = "tabControlPersonel";
            this.tabControlPersonel.SelectedIndex = 0;
            this.tabControlPersonel.Size = new System.Drawing.Size(835, 404);
            this.tabControlPersonel.TabIndex = 1;
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 469);
            this.Controls.Add(this.tabControlPersonel);
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            this.Ayarlar.ResumeLayout(false);
            this.Ayarlar.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.UrunIade.ResumeLayout(false);
            this.UrunIade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUrunIadeGoster)).EndInit();
            this.GunSonuIslemRaporu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvYaptigimSatislar)).EndInit();
            this.SatisEkran.ResumeLayout(false);
            this.SatisEkran.PerformLayout();
            this.tabControlPersonel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Ayarlar;
        private System.Windows.Forms.Label lblSifreİslem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSifreDegistir;
        private System.Windows.Forms.Label lblYeniSifreTekrari;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.Label lblEskiSifre;
        private System.Windows.Forms.TextBox txtYeniSifreTekrari;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.TabPage UrunIade;
        private System.Windows.Forms.TabPage GunSonuIslemRaporu;
        private System.Windows.Forms.TabPage SatisEkran;
        private System.Windows.Forms.TabControl tabControlPersonel;
        private System.Windows.Forms.Label lblSatisAdedi;
        private System.Windows.Forms.Label lblBarkodNo;
        private System.Windows.Forms.TextBox txtSatisAdedi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnSatisListesindenUrunSil;
        private System.Windows.Forms.Button btnSatisListesineEkle;
        private System.Windows.Forms.ListView lsvUrunGoster;
        private System.Windows.Forms.ColumnHeader UrunID;
        private System.Windows.Forms.ColumnHeader UrunAd;
        private System.Windows.Forms.ColumnHeader UrunKategori;
        private System.Windows.Forms.ColumnHeader UrunBarkod;
        private System.Windows.Forms.ColumnHeader UrunSatisFiyati;
        private System.Windows.Forms.ColumnHeader UrunStok;
        private System.Windows.Forms.ColumnHeader SatilacakAdet;
        private System.Windows.Forms.Button btnİadeEt;
        private System.Windows.Forms.Label lblSatisID;
        private System.Windows.Forms.TextBox txtSatisID;
        private System.Windows.Forms.DataGridView dtgvYaptigimSatislar;
        private System.Windows.Forms.Button btnYaptigimSatislar;
        private System.Windows.Forms.Button btnKasayiKapat;
        private System.Windows.Forms.DataGridView dtgvUrunIadeGoster;
    }
}