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
using System.IO.Ports;//Arduino seri haberleşmesi için "IO.Ports" kütüphanesi eklendi..

namespace ParmakiziPersonelTakip
{
    public partial class frmPersonelislemler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CTQFLUU;Initial Catalog=PersonelTakip;Integrated Security=True");

        Personel personel = new Personel();

        SerialPort seriPort = new SerialPort();

        public frmPersonelislemler()
        {
            InitializeComponent();
        }


        bool durum = false;
        void tekrarEdenKayit()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM personel WHERE personelid=@id OR personelTcKimlik=@tckimlik AND silindi=0", baglanti);
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.Parameters.AddWithValue("@tckimlik", txtTc.Text);
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
        }
        void tekrarEdenKayitUpdate()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM personel WHERE personelid!=@id AND personelTcKimlik=@tckimlik AND silindi=0", baglanti);
            komut.Parameters.AddWithValue("@id", txtid.Text);
            komut.Parameters.AddWithValue("@tckimlik", txtTc.Text);
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
        }
        private void yenileVeListele()
        {
            //Kayıtları listeleme..
            string sorgu = "SELECT personelid,personelTcKimlik,personelAd,personelSoyad,personelTelefon,personelAdres,personelDepartman,personelMaas,personelGirisTarihi FROM personel where silindi=0";
            SqlDataAdapter adaptor = new SqlDataAdapter();
            dataGridViewPersonel.DataSource = personel.personelListele(adaptor, sorgu);

            dataGridViewPersonel.Columns[0].HeaderText = "İD";
            dataGridViewPersonel.Columns[1].HeaderText = "TCKN";
            dataGridViewPersonel.Columns[2].HeaderText = "AD";
            dataGridViewPersonel.Columns[3].HeaderText = "SOYAD";
            dataGridViewPersonel.Columns[4].HeaderText = "TELEFON";
            dataGridViewPersonel.Columns[5].HeaderText = "ADRES";
            dataGridViewPersonel.Columns[6].HeaderText = "DEPARTMAN";
            dataGridViewPersonel.Columns[7].HeaderText = "MAAŞ";
            dataGridViewPersonel.Columns[8].HeaderText = "İŞE GİRİŞ TARİHİ";
        }
        private void Temizle(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                    maskedTxtTelefon.Clear();
                    richTxtAdres.Clear();
                    dateTimeGirisTarihi.Value = DateTime.Now;
                    dateTimeCikisTarihi.Value = DateTime.Now;
                }
                if (item.Controls.Count > 0)
                {
                    Temizle(item);
                }
            }
        }

        private void Kapali()
        {
            txtid.Enabled = false;
            txtTc.Enabled = false;
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            maskedTxtTelefon.Enabled = false;
            richTxtAdres.Enabled = false;
            txtDepartman.Enabled = false;
            txtMaas.Enabled = false;
            dateTimeGirisTarihi.Enabled = false;
            dateTimeCikisTarihi.Enabled = false;
            btnPersonelEkle.Enabled = false;
            btnPersonelGuncelle.Enabled = false;
            btnPersonelSil.Enabled = false;
            btnParmakiziKaydet.Enabled = false;
        }

        private void Acik()
        {
            txtid.Enabled = true;
            txtTc.Enabled = true;
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            maskedTxtTelefon.Enabled = true;
            richTxtAdres.Enabled = true;
            txtDepartman.Enabled = true;
            txtMaas.Enabled = true;
            dateTimeGirisTarihi.Enabled = true;
            btnPersonelEkle.Enabled = true;
            btnPersonelGuncelle.Enabled = true;
            btnPersonelSil.Enabled = true;
            btnParmakiziKaydet.Enabled = true;
        }
        /*void bosAlanKontrol()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox && item != txtPersonelAra)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show(Convert.ToString(((TextBox)item).Tag + "LÜTFEN TÜM ALANLARI DOLDURUN"), "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (item is MaskedTextBox)
                {
                    if (((MaskedTextBox)item).MaskFull == false)
                    {
                        MessageBox.Show(Convert.ToString(((MaskedTextBox)item).Tag + "LÜTFEN TÜM ALANLARI DOLDURUN"), "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (item is RichTextBox)
                {
                    if (item.Text == "")
                    {
                        MessageBox.Show(Convert.ToString(((RichTextBox)item).Tag + "LÜTFEN TÜM ALANLARI DOLDURUN"), "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }*/

        private void frmPersonelislemler_Load(object sender, EventArgs e)
        {
            Kapali();
            yenileVeListele();
            //Oluşturululan seriPort'un bağlantı hızı ve port adını tanımlama
            seriPort.BaudRate = 9600;
            seriPort.PortName = "COM3";
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "" && txtTc.Text != "" && txtAd.Text != "" && txtSoyad.Text != "")
            {
                tekrarEdenKayit();
                if (durum == true)
                {
                    SqlCommand komut = new SqlCommand();
                    string sorgu = "INSERT INTO personel (personelid,personelTcKimlik,personelAd,personelSoyad,personelTelefon,personelAdres,personelDepartman,personelMaas,personelGirisTarihi,personelCikisTarihi)" +
                    "VALUES (@id,@tckimlik,@ad,@soyad,@telefon,@adres,@departman,@maas,@giristarihi,@cikistarihi)";
                    //personel tablosu
                    komut.Parameters.AddWithValue("@id", txtid.Text);
                    komut.Parameters.AddWithValue("@tckimlik", txtTc.Text);
                    komut.Parameters.AddWithValue("@ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@telefon", maskedTxtTelefon.Text);
                    komut.Parameters.AddWithValue("@adres", richTxtAdres.Text);
                    komut.Parameters.AddWithValue("@departman", txtDepartman.Text);
                    komut.Parameters.AddWithValue("@maas", Convert.ToDouble(txtMaas.Text));
                    komut.Parameters.AddWithValue("@giristarihi", dateTimeGirisTarihi.Value);
                    komut.Parameters.AddWithValue("@cikistarihi", SqlDbType.DateTime).Value = Convert.ToDateTime("31.12.9999");
                    personel.personelEkle_sil_guncelle(komut, sorgu);

                    MessageBox.Show("PERSONEL KAYDI EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yenileVeListele();
                    Temizle(this);
                    Kapali();
                }
                else
                {
                    MessageBox.Show("AYNI ID VEYA T.C KİMLİK NUMARASINA AİT PERSONEL ZATEN VAR!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("TÜM ALANLARI DOLDURUN!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void txtPersonelAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "SELECT personelid,personelTcKimlik,personelAd,personelSoyad,personelTelefon,personelAdres," +
            "personelDepartman,personelMaas,personelGirisTarihi FROM personel WHERE personelTcKimlik LIKE '%" 
            + txtPersonelAra.Text + "%' AND silindi=0";

            SqlDataAdapter adaptor = new SqlDataAdapter();
            dataGridViewPersonel.DataSource = personel.personelListele(adaptor, sorgu);
        }

        private void dataGridViewPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Acik();
            txtid.Enabled = false;
            dateTimeGirisTarihi.Enabled = false;
            dateTimeCikisTarihi.Enabled = false;
            btnPersonelEkle.Enabled = false;
            btnParmakiziKaydet.Enabled = false;

            DataGridViewRow satir = dataGridViewPersonel.CurrentRow;
            txtid.Text = satir.Cells[0].Value.ToString();
            txtTc.Text = satir.Cells[1].Value.ToString();
            txtAd.Text = satir.Cells[2].Value.ToString();
            txtSoyad.Text = satir.Cells[3].Value.ToString();
            maskedTxtTelefon.Text = satir.Cells[4].Value.ToString();
            richTxtAdres.Text = satir.Cells[5].Value.ToString();
            txtDepartman.Text = satir.Cells[6].Value.ToString();
            txtMaas.Text = satir.Cells[7].Value.ToString();
            dateTimeGirisTarihi.Text = satir.Cells[8].Value.ToString();
        }

        private void btnYeniPersonel_Click(object sender, EventArgs e)
        {
            Acik();
            btnPersonelEkle.Enabled = false;
            btnPersonelGuncelle.Enabled = false;
            btnPersonelSil.Enabled = false;
            Temizle(this);
            seriPort.Open();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("PERSONEL BİLGİLERİNİ SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                string sorgu = "UPDATE personel SET personelCikisTarihi=@cikistarihi, silindi=1 WHERE personelid=@id";

                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@id", txtid.Text);
                komut.Parameters.AddWithValue("@cikistarihi", SqlDbType.DateTime).Value = DateTime.Now;
                personel.personelEkle_sil_guncelle(komut, sorgu);

                MessageBox.Show("PERSONEL BİLGİLERİ SİLİNDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yenileVeListele();
                Temizle(this);
                Kapali();
            }
            else if (secim == DialogResult.No)
            {
                txtPersonelAra.Focus();
            }
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            tekrarEdenKayitUpdate();

            DialogResult secim = MessageBox.Show("PERSONEL BİLGİLERİ GÜNCELLEMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                if (durum == true)
                {
                    string sorgu = "UPDATE personel SET personelTcKimlik=@tckimlik,personelAd=@ad,personelSoyad=@soyad,personelTelefon=@telefon,personelAdres=@adres,personelDepartman=@departman,personelMaas=@maas WHERE personelid=@id";

                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.AddWithValue("@id", txtid.Text);
                    komut.Parameters.AddWithValue("@tckimlik", txtTc.Text);
                    komut.Parameters.AddWithValue("@ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@telefon", maskedTxtTelefon.Text);
                    komut.Parameters.AddWithValue("@adres", richTxtAdres.Text);
                    komut.Parameters.AddWithValue("@departman", txtDepartman.Text);
                    komut.Parameters.AddWithValue("@maas", Convert.ToDouble(txtMaas.Text));
                    personel.personelEkle_sil_guncelle(komut, sorgu);

                    MessageBox.Show("PERSONEL BİLGİLERİ GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yenileVeListele();
                    Temizle(this);
                    Kapali();
                }
                else
                {
                    MessageBox.Show("PERSONEL ZATEN KAYITLI!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (secim == DialogResult.No)
            {
                txtPersonelAra.Focus();
            }
        }

        private void frmPersonelislemler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (seriPort.IsOpen)
            {
                seriPort.Close();
            }
        }

        private void btnParmakiziKaydet_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("PARMAK İZİ KAYDI İÇİN ID NUMARASI GİRİN!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(seriPort.IsOpen)
                {
                    string veri = txtid.Text;
                    seriPort.Write(veri);
                    seriPort.Close();
                    btnPersonelEkle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("SERİ BAĞLANTI MEVCUT DEĞİL!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        
    }
}
