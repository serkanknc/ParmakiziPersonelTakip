
namespace ParmakiziPersonelTakip
{
    partial class frmIzinislemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzinislemler));
            this.lblPersonelid = new System.Windows.Forms.Label();
            this.lblPersonelAd = new System.Windows.Forms.Label();
            this.lblPersonelSoyad = new System.Windows.Forms.Label();
            this.lblRaporlu = new System.Windows.Forms.Label();
            this.lblUcretli = new System.Windows.Forms.Label();
            this.lblUcretsiz = new System.Windows.Forms.Label();
            this.lblizinid = new System.Windows.Forms.Label();
            this.lblizinTip = new System.Windows.Forms.Label();
            this.lblizinGunSayisi = new System.Windows.Forms.Label();
            this.lblizinBaslangic = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKalanizin = new System.Windows.Forms.Label();
            this.txtPersonelid = new System.Windows.Forms.TextBox();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.txtRaporlu = new System.Windows.Forms.TextBox();
            this.txtUcretli = new System.Windows.Forms.TextBox();
            this.txtUcretsiz = new System.Windows.Forms.TextBox();
            this.txtizinid = new System.Windows.Forms.TextBox();
            this.comboBoxizinTipi = new System.Windows.Forms.ComboBox();
            this.dtpizinBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpizinBitis = new System.Windows.Forms.DateTimePicker();
            this.txtizinGunSayisi = new System.Windows.Forms.TextBox();
            this.txtKalanizin = new System.Windows.Forms.TextBox();
            this.groupBoxPersonel = new System.Windows.Forms.GroupBox();
            this.groupBoxizin = new System.Windows.Forms.GroupBox();
            this.listViewPersoneller = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewizinler = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPersoneller = new System.Windows.Forms.Label();
            this.lblizinler = new System.Windows.Forms.Label();
            this.btnYeniizin = new System.Windows.Forms.Button();
            this.btnizinKaydet = new System.Windows.Forms.Button();
            this.btnizinGuncelle = new System.Windows.Forms.Button();
            this.btnizinSil = new System.Windows.Forms.Button();
            this.groupBoxPersonel.SuspendLayout();
            this.groupBoxizin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPersonelid
            // 
            this.lblPersonelid.AutoSize = true;
            this.lblPersonelid.Location = new System.Drawing.Point(18, 29);
            this.lblPersonelid.Name = "lblPersonelid";
            this.lblPersonelid.Size = new System.Drawing.Size(85, 13);
            this.lblPersonelid.TabIndex = 0;
            this.lblPersonelid.Text = "PERSONEL ID";
            // 
            // lblPersonelAd
            // 
            this.lblPersonelAd.AutoSize = true;
            this.lblPersonelAd.Location = new System.Drawing.Point(18, 56);
            this.lblPersonelAd.Name = "lblPersonelAd";
            this.lblPersonelAd.Size = new System.Drawing.Size(24, 13);
            this.lblPersonelAd.TabIndex = 1;
            this.lblPersonelAd.Text = "AD";
            // 
            // lblPersonelSoyad
            // 
            this.lblPersonelSoyad.AutoSize = true;
            this.lblPersonelSoyad.Location = new System.Drawing.Point(18, 83);
            this.lblPersonelSoyad.Name = "lblPersonelSoyad";
            this.lblPersonelSoyad.Size = new System.Drawing.Size(48, 13);
            this.lblPersonelSoyad.TabIndex = 2;
            this.lblPersonelSoyad.Text = "SOYAD";
            // 
            // lblRaporlu
            // 
            this.lblRaporlu.AutoSize = true;
            this.lblRaporlu.Location = new System.Drawing.Point(228, 29);
            this.lblRaporlu.Name = "lblRaporlu";
            this.lblRaporlu.Size = new System.Drawing.Size(61, 13);
            this.lblRaporlu.TabIndex = 3;
            this.lblRaporlu.Text = "RAPORLU";
            // 
            // lblUcretli
            // 
            this.lblUcretli.AutoSize = true;
            this.lblUcretli.Location = new System.Drawing.Point(228, 56);
            this.lblUcretli.Name = "lblUcretli";
            this.lblUcretli.Size = new System.Drawing.Size(57, 13);
            this.lblUcretli.TabIndex = 4;
            this.lblUcretli.Text = "ÜCRETLİ";
            // 
            // lblUcretsiz
            // 
            this.lblUcretsiz.AutoSize = true;
            this.lblUcretsiz.Location = new System.Drawing.Point(228, 83);
            this.lblUcretsiz.Name = "lblUcretsiz";
            this.lblUcretsiz.Size = new System.Drawing.Size(67, 13);
            this.lblUcretsiz.TabIndex = 5;
            this.lblUcretsiz.Text = "ÜCRETSİZ";
            // 
            // lblizinid
            // 
            this.lblizinid.AutoSize = true;
            this.lblizinid.Location = new System.Drawing.Point(18, 29);
            this.lblizinid.Name = "lblizinid";
            this.lblizinid.Size = new System.Drawing.Size(51, 13);
            this.lblizinid.TabIndex = 6;
            this.lblizinid.Text = "İZİN ID";
            // 
            // lblizinTip
            // 
            this.lblizinTip.AutoSize = true;
            this.lblizinTip.Location = new System.Drawing.Point(18, 56);
            this.lblizinTip.Name = "lblizinTip";
            this.lblizinTip.Size = new System.Drawing.Size(61, 13);
            this.lblizinTip.TabIndex = 7;
            this.lblizinTip.Text = "İZİN TİPİ";
            // 
            // lblizinGunSayisi
            // 
            this.lblizinGunSayisi.AutoSize = true;
            this.lblizinGunSayisi.Location = new System.Drawing.Point(18, 141);
            this.lblizinGunSayisi.Name = "lblizinGunSayisi";
            this.lblizinGunSayisi.Size = new System.Drawing.Size(107, 13);
            this.lblizinGunSayisi.TabIndex = 8;
            this.lblizinGunSayisi.Text = "İZİN GÜN SAYISI";
            // 
            // lblizinBaslangic
            // 
            this.lblizinBaslangic.AutoSize = true;
            this.lblizinBaslangic.Location = new System.Drawing.Point(18, 87);
            this.lblizinBaslangic.Name = "lblizinBaslangic";
            this.lblizinBaslangic.Size = new System.Drawing.Size(106, 13);
            this.lblizinBaslangic.TabIndex = 9;
            this.lblizinBaslangic.Text = "İZİN BAŞLANGIÇ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "İZİN BİTİŞ";
            // 
            // lblKalanizin
            // 
            this.lblKalanizin.AutoSize = true;
            this.lblKalanizin.Location = new System.Drawing.Point(220, 26);
            this.lblKalanizin.Name = "lblKalanizin";
            this.lblKalanizin.Size = new System.Drawing.Size(75, 13);
            this.lblKalanizin.TabIndex = 11;
            this.lblKalanizin.Text = "KALAN İZİN";
            // 
            // txtPersonelid
            // 
            this.txtPersonelid.Location = new System.Drawing.Point(109, 26);
            this.txtPersonelid.Name = "txtPersonelid";
            this.txtPersonelid.Size = new System.Drawing.Size(44, 21);
            this.txtPersonelid.TabIndex = 12;
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(109, 53);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(100, 21);
            this.txtPersonelAd.TabIndex = 13;
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(109, 80);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(100, 21);
            this.txtPersonelSoyad.TabIndex = 14;
            // 
            // txtRaporlu
            // 
            this.txtRaporlu.Location = new System.Drawing.Point(304, 26);
            this.txtRaporlu.Name = "txtRaporlu";
            this.txtRaporlu.Size = new System.Drawing.Size(43, 21);
            this.txtRaporlu.TabIndex = 15;
            // 
            // txtUcretli
            // 
            this.txtUcretli.Location = new System.Drawing.Point(304, 53);
            this.txtUcretli.Name = "txtUcretli";
            this.txtUcretli.Size = new System.Drawing.Size(43, 21);
            this.txtUcretli.TabIndex = 16;
            // 
            // txtUcretsiz
            // 
            this.txtUcretsiz.Location = new System.Drawing.Point(304, 80);
            this.txtUcretsiz.Name = "txtUcretsiz";
            this.txtUcretsiz.Size = new System.Drawing.Size(43, 21);
            this.txtUcretsiz.TabIndex = 17;
            // 
            // txtizinid
            // 
            this.txtizinid.Location = new System.Drawing.Point(133, 26);
            this.txtizinid.Name = "txtizinid";
            this.txtizinid.Size = new System.Drawing.Size(44, 21);
            this.txtizinid.TabIndex = 18;
            // 
            // comboBoxizinTipi
            // 
            this.comboBoxizinTipi.FormattingEnabled = true;
            this.comboBoxizinTipi.Items.AddRange(new object[] {
            "RAPORLU",
            "ÜCRETLİ",
            "ÜCRETSİZ"});
            this.comboBoxizinTipi.Location = new System.Drawing.Point(133, 53);
            this.comboBoxizinTipi.Name = "comboBoxizinTipi";
            this.comboBoxizinTipi.Size = new System.Drawing.Size(118, 21);
            this.comboBoxizinTipi.TabIndex = 19;
            this.comboBoxizinTipi.SelectedIndexChanged += new System.EventHandler(this.comboBoxizinTipi_SelectedIndexChanged);
            // 
            // dtpizinBaslangic
            // 
            this.dtpizinBaslangic.Location = new System.Drawing.Point(133, 81);
            this.dtpizinBaslangic.Name = "dtpizinBaslangic";
            this.dtpizinBaslangic.Size = new System.Drawing.Size(118, 21);
            this.dtpizinBaslangic.TabIndex = 20;
            // 
            // dtpizinBitis
            // 
            this.dtpizinBitis.Location = new System.Drawing.Point(133, 108);
            this.dtpizinBitis.Name = "dtpizinBitis";
            this.dtpizinBitis.Size = new System.Drawing.Size(118, 21);
            this.dtpizinBitis.TabIndex = 21;
            this.dtpizinBitis.ValueChanged += new System.EventHandler(this.dtpizinBitis_ValueChanged);
            // 
            // txtizinGunSayisi
            // 
            this.txtizinGunSayisi.Location = new System.Drawing.Point(133, 138);
            this.txtizinGunSayisi.Name = "txtizinGunSayisi";
            this.txtizinGunSayisi.Size = new System.Drawing.Size(44, 21);
            this.txtizinGunSayisi.TabIndex = 22;
            // 
            // txtKalanizin
            // 
            this.txtKalanizin.Location = new System.Drawing.Point(304, 23);
            this.txtKalanizin.Name = "txtKalanizin";
            this.txtKalanizin.Size = new System.Drawing.Size(43, 21);
            this.txtKalanizin.TabIndex = 23;
            // 
            // groupBoxPersonel
            // 
            this.groupBoxPersonel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxPersonel.Controls.Add(this.lblPersonelid);
            this.groupBoxPersonel.Controls.Add(this.lblPersonelAd);
            this.groupBoxPersonel.Controls.Add(this.lblPersonelSoyad);
            this.groupBoxPersonel.Controls.Add(this.lblRaporlu);
            this.groupBoxPersonel.Controls.Add(this.lblUcretli);
            this.groupBoxPersonel.Controls.Add(this.lblUcretsiz);
            this.groupBoxPersonel.Controls.Add(this.txtPersonelid);
            this.groupBoxPersonel.Controls.Add(this.txtUcretsiz);
            this.groupBoxPersonel.Controls.Add(this.txtPersonelAd);
            this.groupBoxPersonel.Controls.Add(this.txtUcretli);
            this.groupBoxPersonel.Controls.Add(this.txtPersonelSoyad);
            this.groupBoxPersonel.Controls.Add(this.txtRaporlu);
            this.groupBoxPersonel.Location = new System.Drawing.Point(599, 62);
            this.groupBoxPersonel.Name = "groupBoxPersonel";
            this.groupBoxPersonel.Size = new System.Drawing.Size(355, 109);
            this.groupBoxPersonel.TabIndex = 24;
            this.groupBoxPersonel.TabStop = false;
            this.groupBoxPersonel.Text = "PERSONEL BİLGİLERİ";
            // 
            // groupBoxizin
            // 
            this.groupBoxizin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxizin.Controls.Add(this.lblizinid);
            this.groupBoxizin.Controls.Add(this.lblizinTip);
            this.groupBoxizin.Controls.Add(this.txtKalanizin);
            this.groupBoxizin.Controls.Add(this.lblizinGunSayisi);
            this.groupBoxizin.Controls.Add(this.txtizinGunSayisi);
            this.groupBoxizin.Controls.Add(this.lblizinBaslangic);
            this.groupBoxizin.Controls.Add(this.dtpizinBitis);
            this.groupBoxizin.Controls.Add(this.label5);
            this.groupBoxizin.Controls.Add(this.dtpizinBaslangic);
            this.groupBoxizin.Controls.Add(this.lblKalanizin);
            this.groupBoxizin.Controls.Add(this.comboBoxizinTipi);
            this.groupBoxizin.Controls.Add(this.txtizinid);
            this.groupBoxizin.Location = new System.Drawing.Point(599, 256);
            this.groupBoxizin.Name = "groupBoxizin";
            this.groupBoxizin.Size = new System.Drawing.Size(355, 165);
            this.groupBoxizin.TabIndex = 25;
            this.groupBoxizin.TabStop = false;
            this.groupBoxizin.Text = "İZİN BİLGİLERİ";
            // 
            // listViewPersoneller
            // 
            this.listViewPersoneller.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewPersoneller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewPersoneller.FullRowSelect = true;
            this.listViewPersoneller.HideSelection = false;
            this.listViewPersoneller.Location = new System.Drawing.Point(15, 62);
            this.listViewPersoneller.Name = "listViewPersoneller";
            this.listViewPersoneller.Size = new System.Drawing.Size(564, 192);
            this.listViewPersoneller.TabIndex = 26;
            this.listViewPersoneller.UseCompatibleStateImageBehavior = false;
            this.listViewPersoneller.View = System.Windows.Forms.View.Details;
            this.listViewPersoneller.DoubleClick += new System.EventHandler(this.listViewPersoneller_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AD";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SOYAD";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TELEFON";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ADRES";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "RAPORLU";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ÜCRETLİ";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 62;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ÜCRETSİZ";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 72;
            // 
            // listViewizinler
            // 
            this.listViewizinler.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewizinler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listViewizinler.FullRowSelect = true;
            this.listViewizinler.HideSelection = false;
            this.listViewizinler.Location = new System.Drawing.Point(12, 338);
            this.listViewizinler.Name = "listViewizinler";
            this.listViewizinler.Size = new System.Drawing.Size(567, 195);
            this.listViewizinler.TabIndex = 27;
            this.listViewizinler.UseCompatibleStateImageBehavior = false;
            this.listViewizinler.View = System.Windows.Forms.View.Details;
            this.listViewizinler.DoubleClick += new System.EventHandler(this.listViewizinler_DoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 26;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "AD";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 62;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "SOYAD";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "İZİN TİPİ";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 70;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "İZİN BAŞLANGIÇ";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 114;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "İZİN BİTİŞ";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 92;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "İZİNLİ GÜN SAYISI";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 124;
            // 
            // lblPersoneller
            // 
            this.lblPersoneller.AutoSize = true;
            this.lblPersoneller.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersoneller.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPersoneller.Location = new System.Drawing.Point(12, 41);
            this.lblPersoneller.Name = "lblPersoneller";
            this.lblPersoneller.Size = new System.Drawing.Size(137, 18);
            this.lblPersoneller.TabIndex = 28;
            this.lblPersoneller.Text = "PERSONELLER";
            // 
            // lblizinler
            // 
            this.lblizinler.AutoSize = true;
            this.lblizinler.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblizinler.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblizinler.Location = new System.Drawing.Point(12, 316);
            this.lblizinler.Name = "lblizinler";
            this.lblizinler.Size = new System.Drawing.Size(82, 18);
            this.lblizinler.TabIndex = 29;
            this.lblizinler.Text = "İZİNLER";
            // 
            // btnYeniizin
            // 
            this.btnYeniizin.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnYeniizin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniizin.Location = new System.Drawing.Point(618, 452);
            this.btnYeniizin.Name = "btnYeniizin";
            this.btnYeniizin.Size = new System.Drawing.Size(323, 40);
            this.btnYeniizin.TabIndex = 30;
            this.btnYeniizin.Text = "YENİ İZİN";
            this.btnYeniizin.UseVisualStyleBackColor = false;
            this.btnYeniizin.Click += new System.EventHandler(this.btnYeniizin_Click);
            // 
            // btnizinKaydet
            // 
            this.btnizinKaydet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnizinKaydet.Location = new System.Drawing.Point(618, 498);
            this.btnizinKaydet.Name = "btnizinKaydet";
            this.btnizinKaydet.Size = new System.Drawing.Size(100, 35);
            this.btnizinKaydet.TabIndex = 31;
            this.btnizinKaydet.Text = "İZİN KAYDET";
            this.btnizinKaydet.UseVisualStyleBackColor = false;
            this.btnizinKaydet.Click += new System.EventHandler(this.btnizinKaydet_Click);
            // 
            // btnizinGuncelle
            // 
            this.btnizinGuncelle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnizinGuncelle.Location = new System.Drawing.Point(730, 498);
            this.btnizinGuncelle.Name = "btnizinGuncelle";
            this.btnizinGuncelle.Size = new System.Drawing.Size(100, 35);
            this.btnizinGuncelle.TabIndex = 32;
            this.btnizinGuncelle.Text = "İZİN GÜNCELLE";
            this.btnizinGuncelle.UseVisualStyleBackColor = false;
            this.btnizinGuncelle.Click += new System.EventHandler(this.btnizinGuncelle_Click);
            // 
            // btnizinSil
            // 
            this.btnizinSil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnizinSil.Location = new System.Drawing.Point(841, 498);
            this.btnizinSil.Name = "btnizinSil";
            this.btnizinSil.Size = new System.Drawing.Size(100, 35);
            this.btnizinSil.TabIndex = 33;
            this.btnizinSil.Text = "İZİN SİL";
            this.btnizinSil.UseVisualStyleBackColor = false;
            this.btnizinSil.Click += new System.EventHandler(this.btnizinSil_Click);
            // 
            // frmIzinislemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(966, 545);
            this.Controls.Add(this.btnizinSil);
            this.Controls.Add(this.btnizinGuncelle);
            this.Controls.Add(this.btnizinKaydet);
            this.Controls.Add(this.btnYeniizin);
            this.Controls.Add(this.lblizinler);
            this.Controls.Add(this.lblPersoneller);
            this.Controls.Add(this.listViewizinler);
            this.Controls.Add(this.listViewPersoneller);
            this.Controls.Add(this.groupBoxizin);
            this.Controls.Add(this.groupBoxPersonel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIzinislemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İZİN İŞLEMLERİ";
            this.Load += new System.EventHandler(this.frmIzinislemler_Load);
            this.groupBoxPersonel.ResumeLayout(false);
            this.groupBoxPersonel.PerformLayout();
            this.groupBoxizin.ResumeLayout(false);
            this.groupBoxizin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonelid;
        private System.Windows.Forms.Label lblPersonelAd;
        private System.Windows.Forms.Label lblPersonelSoyad;
        private System.Windows.Forms.Label lblRaporlu;
        private System.Windows.Forms.Label lblUcretli;
        private System.Windows.Forms.Label lblUcretsiz;
        private System.Windows.Forms.Label lblizinid;
        private System.Windows.Forms.Label lblizinTip;
        private System.Windows.Forms.Label lblizinGunSayisi;
        private System.Windows.Forms.Label lblizinBaslangic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKalanizin;
        private System.Windows.Forms.TextBox txtPersonelid;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.TextBox txtRaporlu;
        private System.Windows.Forms.TextBox txtUcretli;
        private System.Windows.Forms.TextBox txtUcretsiz;
        private System.Windows.Forms.TextBox txtizinid;
        private System.Windows.Forms.ComboBox comboBoxizinTipi;
        private System.Windows.Forms.DateTimePicker dtpizinBaslangic;
        private System.Windows.Forms.DateTimePicker dtpizinBitis;
        private System.Windows.Forms.TextBox txtizinGunSayisi;
        private System.Windows.Forms.TextBox txtKalanizin;
        private System.Windows.Forms.GroupBox groupBoxPersonel;
        private System.Windows.Forms.GroupBox groupBoxizin;
        private System.Windows.Forms.ListView listViewPersoneller;
        private System.Windows.Forms.ListView listViewizinler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblPersoneller;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label lblizinler;
        private System.Windows.Forms.Button btnYeniizin;
        private System.Windows.Forms.Button btnizinKaydet;
        private System.Windows.Forms.Button btnizinGuncelle;
        private System.Windows.Forms.Button btnizinSil;
    }
}