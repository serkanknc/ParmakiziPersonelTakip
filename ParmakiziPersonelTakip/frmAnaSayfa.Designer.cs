
namespace ParmakiziPersonelTakip
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.personelForm = new System.Windows.Forms.Button();
            this.ımageListAnaSayfa = new System.Windows.Forms.ImageList(this.components);
            this.cikis = new System.Windows.Forms.Button();
            this.mesaiForm = new System.Windows.Forms.Button();
            this.izinForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personelForm
            // 
            this.personelForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.personelForm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.personelForm.ImageKey = "personelislemleri.PNG";
            this.personelForm.ImageList = this.ımageListAnaSayfa;
            this.personelForm.Location = new System.Drawing.Point(12, 12);
            this.personelForm.Name = "personelForm";
            this.personelForm.Size = new System.Drawing.Size(196, 108);
            this.personelForm.TabIndex = 0;
            this.personelForm.Text = "PERSONEL İŞLEMLERİ";
            this.personelForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.personelForm.UseVisualStyleBackColor = false;
            this.personelForm.Click += new System.EventHandler(this.personelForm_Click);
            // 
            // ımageListAnaSayfa
            // 
            this.ımageListAnaSayfa.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListAnaSayfa.ImageStream")));
            this.ımageListAnaSayfa.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListAnaSayfa.Images.SetKeyName(0, "personelislemleri.PNG");
            this.ımageListAnaSayfa.Images.SetKeyName(1, "personelmesaiislemleri.png");
            this.ımageListAnaSayfa.Images.SetKeyName(2, "personelizinislemleri.PNG");
            this.ımageListAnaSayfa.Images.SetKeyName(3, "cikis.png");
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cikis.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cikis.ImageKey = "cikis.png";
            this.cikis.ImageList = this.ımageListAnaSayfa;
            this.cikis.Location = new System.Drawing.Point(215, 126);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(197, 102);
            this.cikis.TabIndex = 3;
            this.cikis.Text = "ÇIKIŞ";
            this.cikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // mesaiForm
            // 
            this.mesaiForm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaiForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mesaiForm.ImageKey = "personelmesaiislemleri.png";
            this.mesaiForm.ImageList = this.ımageListAnaSayfa;
            this.mesaiForm.Location = new System.Drawing.Point(215, 12);
            this.mesaiForm.Name = "mesaiForm";
            this.mesaiForm.Size = new System.Drawing.Size(197, 108);
            this.mesaiForm.TabIndex = 2;
            this.mesaiForm.Text = "MESAİ İŞLEMLERİ";
            this.mesaiForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mesaiForm.UseVisualStyleBackColor = true;
            this.mesaiForm.Click += new System.EventHandler(this.mesaiForm_Click);
            // 
            // izinForm
            // 
            this.izinForm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.izinForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.izinForm.ImageKey = "personelizinislemleri.PNG";
            this.izinForm.ImageList = this.ımageListAnaSayfa;
            this.izinForm.Location = new System.Drawing.Point(12, 126);
            this.izinForm.Name = "izinForm";
            this.izinForm.Size = new System.Drawing.Size(196, 102);
            this.izinForm.TabIndex = 4;
            this.izinForm.Text = "İZİN İŞLEMLERİ";
            this.izinForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.izinForm.UseVisualStyleBackColor = true;
            this.izinForm.Click += new System.EventHandler(this.izinForm_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(424, 236);
            this.Controls.Add(this.izinForm);
            this.Controls.Add(this.mesaiForm);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.personelForm);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personelForm;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button mesaiForm;
        private System.Windows.Forms.ImageList ımageListAnaSayfa;
        private System.Windows.Forms.Button izinForm;
    }
}

