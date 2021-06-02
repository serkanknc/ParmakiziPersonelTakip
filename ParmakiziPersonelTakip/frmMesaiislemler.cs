using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParmakiziPersonelTakip
{
    public partial class frmMesaiislemler : Form
    {
        public frmMesaiislemler()
        {
            InitializeComponent();
        }

        bool yeniMesai = false;
        private void mesaiListele()
        {
            listViewMesailer.Items.Clear();
            Mesai mesai = new Mesai();
            mesai.mesaiListele(Convert.ToInt32(txtPersonelid.Text), listViewMesailer);
        }

        /*bool durum = false;
        void tekrarEdenKayit()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM mesai WHERE personelid=@id AND mesaiTarihi=@mtarihi", baglanti);
            komut.Parameters.AddWithValue("@id", txtPersonelid.Text);
            komut.Parameters.AddWithValue("@mtarihi", dtpMesaiTarihi.Value);
            SqlDataReader datareader = komut.ExecuteReader();
            if (datareader.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }*/
        private void Acik()
        {
            dtpMesaiTarihi.Enabled = true;
            txtPersonelid.Enabled = true;
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            txtMesaiid.Enabled = true;
            txtGiris.Enabled = true;
            cmbGirisSaat.Enabled = true;
            cmbGirisDakika.Enabled = true;
            txtCikis.Enabled = true;
            cmbCikisSaat.Enabled = true;
            cmbCikisDakika.Enabled = true;
            btnMesaiKaydet.Enabled = true;
            btnMesaiGuncelle.Enabled = true;
            btnMesaiSil.Enabled = true;
        }
        private void Kapali()
        {
            dtpMesaiTarihi.Enabled = false;
            txtPersonelid.Enabled = false;
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtMesaiid.Enabled = false;
            txtGiris.Enabled = false;
            cmbGirisSaat.Enabled = false;
            cmbGirisDakika.Enabled = false;
            txtCikis.Enabled = false;
            cmbCikisSaat.Enabled = false;
            cmbCikisDakika.Enabled = false;
            btnMesaiKaydet.Enabled = false;
            btnMesaiGuncelle.Enabled = false;
            btnMesaiSil.Enabled = false;
        }

        private void Temizle(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                    dtpMesaiTarihi.Value = DateTime.Now;
                    cmbGirisSaat.Text = "";
                    cmbGirisDakika.Text = "";
                    cmbCikisSaat.Text = "";
                    cmbCikisDakika.Text = "";
                    listViewMesailer.Items.Clear();
                }
                if (item.Controls.Count > 0)
                {
                    Temizle(item);
                }
            }
        }
        /*void bosAlanKontrol()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox && item != txtMesaiid)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show(Convert.ToString(((TextBox)item).Tag + "LÜTFEN TÜM ALANLARI DOLDURUN"), "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }*/
        private void frmMesaiislemler_Load(object sender, EventArgs e)
        {
            Kapali();
            Personel personel = new Personel();
            personel.personelListeleMesai(listViewPersoneller);
        }

        private void listViewPersoneller_DoubleClick(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            txtPersonelid.Text = listViewPersoneller.SelectedItems[0].SubItems[0].Text;
            personel.personelleriListele(Convert.ToInt32(txtPersonelid.Text), personel);
            txtAd.Text = personel.Personelad;
            txtSoyad.Text = personel.Personelsoyad;
            if (yeniMesai)
            {
                btnMesaiKaydet.Enabled = true;
                return;
            }
            else
            {
                Acik();
                dtpMesaiTarihi.Enabled = false;
                txtPersonelid.Enabled = false;
                txtMesaiid.Enabled = false;
                txtGiris.Enabled = false;
                txtCikis.Enabled = false;
                cmbGirisSaat.Enabled = false;
                cmbGirisDakika.Enabled = false;
                cmbCikisSaat.Enabled = false;
                cmbCikisDakika.Enabled = false;
                btnMesaiKaydet.Enabled = false;
                btnMesaiGuncelle.Enabled = false;
                btnMesaiSil.Enabled = false;
            }
            mesaiListele();
        }

        private void listViewMesailer_DoubleClick(object sender, EventArgs e)
        {
            Mesai mesai = new Mesai();
            txtMesaiid.Text = listViewMesailer.SelectedItems[0].SubItems[0].Text;
            mesai.mesaiListele(Convert.ToInt32(txtMesaiid.Text), mesai);
            dtpMesaiTarihi.Value = mesai.Mesaitarihi;
            txtGiris.Text = mesai.Girissaati;
            txtCikis.Text = mesai.Cikissaati;
            Acik();
            yeniMesai = false;
            txtPersonelid.Enabled = false;
            txtMesaiid.Enabled = false;
            txtGiris.Enabled = false;
            txtCikis.Enabled = false;
            btnMesaiKaydet.Enabled = false;
            btnMesaiGuncelle.BackColor = Color.Orange;
            btnMesaiSil.BackColor = Color.Crimson;
        }
        private void btnYeniMesai_Click(object sender, EventArgs e)
        {
            yeniMesai = true;
            Acik();
            txtPersonelid.Enabled = false;
            txtMesaiid.Enabled = false;
            txtGiris.Enabled = false;
            txtCikis.Enabled = false;
            btnMesaiGuncelle.Enabled = false;
            btnMesaiSil.Enabled = false;
            btnMesaiKaydet.BackColor = Color.SkyBlue;
            Temizle(this);
        }

        private void cmbGirisSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGirisDakika.Text != "")
            {
                txtGiris.Text = cmbGirisSaat.Text + ":" + cmbGirisDakika.Text;
            }
        }

        private void cmbGirisDakika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGirisSaat.Text != "")
            {
                txtGiris.Text = cmbGirisSaat.Text + ":" + cmbGirisDakika.Text;
            }
        }

        private void cmbCikisSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCikisDakika.Text != "")
            {
                txtCikis.Text = cmbCikisSaat.Text + ":" + cmbCikisDakika.Text;
            }
        }

        private void cmbCikisDakika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCikisSaat.Text != "")
            {
                txtCikis.Text = cmbCikisSaat.Text + ":" + cmbCikisDakika.Text;
            }
        }

        private void btnMesaiKaydet_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text != "" && txtCikis.Text != "")
            {
                Mesai mesai = new Mesai();
                if (mesai.tekrarEdenKayit(Convert.ToInt32(txtPersonelid.Text), dtpMesaiTarihi.Value))
                {
                    MessageBox.Show("FARKLI BİR MESAİ GÜNÜ SEÇİN!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    SqlCommand komut = new SqlCommand();
                    string sorgu = "INSERT INTO mesai(personelid ,mesaiTarihi,girisSaati,cikisSaati) VALUES (@id,@mtarihi,@girissaati,@cikissaati)";
                    komut.Parameters.AddWithValue("@id", txtPersonelid.Text);
                    komut.Parameters.AddWithValue("@mtarihi", dtpMesaiTarihi.Value);
                    komut.Parameters.AddWithValue("@girissaati", txtGiris.Text);
                    komut.Parameters.AddWithValue("@cikissaati", txtCikis.Text);
                    mesai.mesaiEkle_sil_guncelle(komut, sorgu);

                    MessageBox.Show("MESAİ KAYDI EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yeniMesai = false;
                    Temizle(this);
                    Kapali();
                }
            }
            else
            {
                MessageBox.Show("TÜM ALANLARI DOLDURUN!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnMesaiGuncelle_Click(object sender, EventArgs e)
        {
            Mesai mesai = new Mesai();

            DialogResult secim = MessageBox.Show("PERSONELİN MESAİ BİLGİLERİ GÜNCELLEMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (mesai.tekrarEdenKayitUpdate(Convert.ToInt32(txtPersonelid.Text), Convert.ToInt32(txtMesaiid.Text), dtpMesaiTarihi.Value))
                {
                    MessageBox.Show("FARKLI BİR MESAİ GÜNÜ SEÇİN!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string sorgu = "UPDATE mesai SET mesaiTarihi=@mtarihi,girisSaati=@gsaati,cikisSaati=@csaati WHERE mesaiid=@mid";

                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.AddWithValue("@mid", txtMesaiid.Text);
                    komut.Parameters.AddWithValue("@mtarihi", dtpMesaiTarihi.Value);
                    komut.Parameters.AddWithValue("@gsaati", txtGiris.Text);
                    komut.Parameters.AddWithValue("@csaati", txtCikis.Text);
                    mesai.mesaiEkle_sil_guncelle(komut, sorgu);

                    MessageBox.Show("MESAİ KAYDI GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle(this);
                    Kapali();
                }
            }
            else if (secim == DialogResult.No)
            {
                listViewMesailer.Focus();
            }
            else
            {
                return;
            }
        }

        private void btnMesaiSil_Click(object sender, EventArgs e)
        {
            Mesai mesai = new Mesai();

            DialogResult secim = MessageBox.Show("PERSONELİN MESAİ BİLGİLERİNİ SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                string sorgu = "UPDATE mesai SET silindi=1 WHERE mesaiid=@mid";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@mid", txtMesaiid.Text);
                mesai.mesaiEkle_sil_guncelle(komut, sorgu);
                Temizle(this);
                Kapali();
            }
        }
    }
}
