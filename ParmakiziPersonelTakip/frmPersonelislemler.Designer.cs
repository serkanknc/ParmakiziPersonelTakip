
namespace ParmakiziPersonelTakip
{
    partial class frmPersonelislemler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelislemler));
            this.lblid = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblİsiGirisTarihi = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.maskedTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.richTxtAdres = new System.Windows.Forms.RichTextBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.ımageListPersonelislemleri = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.dateTimeCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimeGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblistenCikisTarihi = new System.Windows.Forms.Label();
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.txtPersonelAra = new System.Windows.Forms.TextBox();
            this.lblPersonelAra = new System.Windows.Forms.Label();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.btnYeniPersonel = new System.Windows.Forms.Button();
            this.btnParmakiziKaydet = new System.Windows.Forms.Button();
            this.groupBoxPersonelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(23, 34);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(94, 16);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "PERSONEL ID";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(23, 65);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(102, 16);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "T.C KİMLİK NO";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(23, 95);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(26, 16);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "AD";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(23, 126);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(53, 16);
            this.lblSoyad.TabIndex = 3;
            this.lblSoyad.Text = "SOYAD";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(23, 156);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(67, 16);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "TELEFON";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas.Location = new System.Drawing.Point(23, 260);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(46, 16);
            this.lblMaas.TabIndex = 8;
            this.lblMaas.Text = "MAAŞ";
            // 
            // lblİsiGirisTarihi
            // 
            this.lblİsiGirisTarihi.AutoSize = true;
            this.lblİsiGirisTarihi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİsiGirisTarihi.Location = new System.Drawing.Point(23, 291);
            this.lblİsiGirisTarihi.Name = "lblİsiGirisTarihi";
            this.lblİsiGirisTarihi.Size = new System.Drawing.Size(120, 16);
            this.lblİsiGirisTarihi.TabIndex = 9;
            this.lblİsiGirisTarihi.Text = "İŞE GİRİŞ TARİHİ";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartman.Location = new System.Drawing.Point(23, 230);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(88, 16);
            this.lblDepartman.TabIndex = 10;
            this.lblDepartman.Text = "DEPARTMAN";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(23, 187);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(51, 16);
            this.lblAdres.TabIndex = 12;
            this.lblAdres.Text = "ADRES";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(171, 30);
            this.txtid.MaxLength = 4;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(132, 23);
            this.txtid.TabIndex = 0;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(171, 61);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(132, 23);
            this.txtTc.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(171, 91);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 23);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(171, 122);
            this.txtSoyad.MaxLength = 40;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(132, 23);
            this.txtSoyad.TabIndex = 3;
            // 
            // maskedTxtTelefon
            // 
            this.maskedTxtTelefon.Location = new System.Drawing.Point(171, 151);
            this.maskedTxtTelefon.Mask = "(999) 000-0000";
            this.maskedTxtTelefon.Name = "maskedTxtTelefon";
            this.maskedTxtTelefon.Size = new System.Drawing.Size(132, 23);
            this.maskedTxtTelefon.TabIndex = 4;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(171, 256);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(132, 23);
            this.txtMaas.TabIndex = 7;
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(171, 226);
            this.txtDepartman.MaxLength = 30;
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(132, 23);
            this.txtDepartman.TabIndex = 6;
            // 
            // richTxtAdres
            // 
            this.richTxtAdres.Location = new System.Drawing.Point(171, 182);
            this.richTxtAdres.MaxLength = 200;
            this.richTxtAdres.Name = "richTxtAdres";
            this.richTxtAdres.Size = new System.Drawing.Size(132, 37);
            this.richTxtAdres.TabIndex = 5;
            this.richTxtAdres.Text = "";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonelEkle.ImageKey = "personelEkle.PNG";
            this.btnPersonelEkle.ImageList = this.ımageListPersonelislemleri;
            this.btnPersonelEkle.Location = new System.Drawing.Point(704, 191);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(125, 98);
            this.btnPersonelEkle.TabIndex = 10;
            this.btnPersonelEkle.Text = "PERSONEL EKLE";
            this.btnPersonelEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // ımageListPersonelislemleri
            // 
            this.ımageListPersonelislemleri.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListPersonelislemleri.ImageStream")));
            this.ımageListPersonelislemleri.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListPersonelislemleri.Images.SetKeyName(0, "personelEkle.PNG");
            this.ımageListPersonelislemleri.Images.SetKeyName(1, "personelSil.png");
            this.ımageListPersonelislemleri.Images.SetKeyName(2, "personelGuncelle.PNG");
            // 
            // groupBoxPersonelBilgileri
            // 
            this.groupBoxPersonelBilgileri.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxPersonelBilgileri.Controls.Add(this.dateTimeCikisTarihi);
            this.groupBoxPersonelBilgileri.Controls.Add(this.dateTimeGirisTarihi);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblid);
            this.groupBoxPersonelBilgileri.Controls.Add(this.txtid);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblTc);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblistenCikisTarihi);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblİsiGirisTarihi);
            this.groupBoxPersonelBilgileri.Controls.Add(this.txtDepartman);
            this.groupBoxPersonelBilgileri.Controls.Add(this.txtMaas);
            this.groupBoxPersonelBilgileri.Controls.Add(this.richTxtAdres);
            this.groupBoxPersonelBilgileri.Controls.Add(this.txtAd);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblMaas);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblAd);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblDepartman);
            this.groupBoxPersonelBilgileri.Controls.Add(this.txtTc);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblSoyad);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblAdres);
            this.groupBoxPersonelBilgileri.Controls.Add(this.maskedTxtTelefon);
            this.groupBoxPersonelBilgileri.Controls.Add(this.txtSoyad);
            this.groupBoxPersonelBilgileri.Controls.Add(this.lblTelefon);
            this.groupBoxPersonelBilgileri.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxPersonelBilgileri.Location = new System.Drawing.Point(14, 13);
            this.groupBoxPersonelBilgileri.Name = "groupBoxPersonelBilgileri";
            this.groupBoxPersonelBilgileri.Size = new System.Drawing.Size(318, 359);
            this.groupBoxPersonelBilgileri.TabIndex = 29;
            this.groupBoxPersonelBilgileri.TabStop = false;
            this.groupBoxPersonelBilgileri.Text = "PERSONEL BİLGİLERİ";
            // 
            // dateTimeCikisTarihi
            // 
            this.dateTimeCikisTarihi.Location = new System.Drawing.Point(171, 320);
            this.dateTimeCikisTarihi.Name = "dateTimeCikisTarihi";
            this.dateTimeCikisTarihi.Size = new System.Drawing.Size(132, 23);
            this.dateTimeCikisTarihi.TabIndex = 66;
            // 
            // dateTimeGirisTarihi
            // 
            this.dateTimeGirisTarihi.Location = new System.Drawing.Point(171, 291);
            this.dateTimeGirisTarihi.Name = "dateTimeGirisTarihi";
            this.dateTimeGirisTarihi.Size = new System.Drawing.Size(132, 23);
            this.dateTimeGirisTarihi.TabIndex = 61;
            // 
            // lblistenCikisTarihi
            // 
            this.lblistenCikisTarihi.AutoSize = true;
            this.lblistenCikisTarihi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblistenCikisTarihi.Location = new System.Drawing.Point(23, 323);
            this.lblistenCikisTarihi.Name = "lblistenCikisTarihi";
            this.lblistenCikisTarihi.Size = new System.Drawing.Size(138, 16);
            this.lblistenCikisTarihi.TabIndex = 9;
            this.lblistenCikisTarihi.Text = "İŞTEN ÇIKIŞ TARİHİ";
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.AllowUserToAddRows = false;
            this.dataGridViewPersonel.AllowUserToDeleteRows = false;
            this.dataGridViewPersonel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPersonel.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(14, 418);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.ReadOnly = true;
            this.dataGridViewPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonel.Size = new System.Drawing.Size(943, 247);
            this.dataGridViewPersonel.TabIndex = 13;
            this.dataGridViewPersonel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonel_CellDoubleClick);
            // 
            // txtPersonelAra
            // 
            this.txtPersonelAra.Location = new System.Drawing.Point(140, 385);
            this.txtPersonelAra.MaxLength = 11;
            this.txtPersonelAra.Name = "txtPersonelAra";
            this.txtPersonelAra.Size = new System.Drawing.Size(166, 23);
            this.txtPersonelAra.TabIndex = 9;
            this.txtPersonelAra.TextChanged += new System.EventHandler(this.txtPersonelAra_TextChanged);
            // 
            // lblPersonelAra
            // 
            this.lblPersonelAra.AutoSize = true;
            this.lblPersonelAra.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelAra.Location = new System.Drawing.Point(14, 389);
            this.lblPersonelAra.Name = "lblPersonelAra";
            this.lblPersonelAra.Size = new System.Drawing.Size(110, 14);
            this.lblPersonelAra.TabIndex = 60;
            this.lblPersonelAra.Text = "PERSONEL ARA";
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonelSil.ImageKey = "personelSil.png";
            this.btnPersonelSil.ImageList = this.ımageListPersonelislemleri;
            this.btnPersonelSil.Location = new System.Drawing.Point(836, 191);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(121, 98);
            this.btnPersonelSil.TabIndex = 11;
            this.btnPersonelSil.Text = "PERSONEL SİL";
            this.btnPersonelSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonelGuncelle.ImageKey = "personelGuncelle.PNG";
            this.btnPersonelGuncelle.ImageList = this.ımageListPersonelislemleri;
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(704, 295);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(253, 99);
            this.btnPersonelGuncelle.TabIndex = 12;
            this.btnPersonelGuncelle.Text = "PERSONEL GÜNCELLE";
            this.btnPersonelGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelGuncelle.UseVisualStyleBackColor = true;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // btnYeniPersonel
            // 
            this.btnYeniPersonel.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnYeniPersonel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniPersonel.Location = new System.Drawing.Point(704, 12);
            this.btnYeniPersonel.Name = "btnYeniPersonel";
            this.btnYeniPersonel.Size = new System.Drawing.Size(253, 72);
            this.btnYeniPersonel.TabIndex = 0;
            this.btnYeniPersonel.Text = "YENİ PERSONEL";
            this.btnYeniPersonel.UseVisualStyleBackColor = false;
            this.btnYeniPersonel.Click += new System.EventHandler(this.btnYeniPersonel_Click);
            // 
            // btnParmakiziKaydet
            // 
            this.btnParmakiziKaydet.BackColor = System.Drawing.Color.LightGreen;
            this.btnParmakiziKaydet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParmakiziKaydet.Location = new System.Drawing.Point(704, 108);
            this.btnParmakiziKaydet.Name = "btnParmakiziKaydet";
            this.btnParmakiziKaydet.Size = new System.Drawing.Size(253, 54);
            this.btnParmakiziKaydet.TabIndex = 61;
            this.btnParmakiziKaydet.Text = "PARMAK İZİ TANIMLAMA";
            this.btnParmakiziKaydet.UseVisualStyleBackColor = false;
            this.btnParmakiziKaydet.Click += new System.EventHandler(this.btnParmakiziKaydet_Click);
            // 
            // frmPersonelislemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(973, 678);
            this.Controls.Add(this.btnParmakiziKaydet);
            this.Controls.Add(this.btnYeniPersonel);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.btnPersonelGuncelle);
            this.Controls.Add(this.txtPersonelAra);
            this.Controls.Add(this.lblPersonelAra);
            this.Controls.Add(this.dataGridViewPersonel);
            this.Controls.Add(this.groupBoxPersonelBilgileri);
            this.Controls.Add(this.btnPersonelEkle);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPersonelislemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL İŞLEMLERİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonelislemler_FormClosing);
            this.Load += new System.EventHandler(this.frmPersonelislemler_Load);
            this.groupBoxPersonelBilgileri.ResumeLayout(false);
            this.groupBoxPersonelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblİsiGirisTarihi;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox maskedTxtTelefon;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.RichTextBox richTxtAdres;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.ImageList ımageListPersonelislemleri;
        private System.Windows.Forms.GroupBox groupBoxPersonelBilgileri;
        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.TextBox txtPersonelAra;
        private System.Windows.Forms.Label lblPersonelAra;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.Button btnYeniPersonel;
        private System.Windows.Forms.Label lblistenCikisTarihi;
        private System.Windows.Forms.DateTimePicker dateTimeGirisTarihi;
        private System.Windows.Forms.DateTimePicker dateTimeCikisTarihi;
        private System.Windows.Forms.Button btnParmakiziKaydet;
    }
}