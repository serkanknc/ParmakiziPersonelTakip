using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParmakiziPersonelTakip
{
    public partial class frmIzinislemler : Form
    {
        public frmIzinislemler()
        {
            InitializeComponent();
        }
        private void Kapali()
        {
            txtPersonelid.Enabled = false;
            txtPersonelAd.Enabled = false;
            txtPersonelAd.Enabled = false;
            txtPersonelSoyad.Enabled = false;
            txtRaporlu.Enabled = false;
            txtUcretli.Enabled = false;
            txtUcretsiz.Enabled = false;
            txtizinid.Enabled = false;
            comboBoxizinTipi.Enabled = false;
            dtpizinBaslangic.Enabled = false;
            dtpizinBitis.Enabled = false;
            txtizinGunSayisi.Enabled = false;
            txtKalanizin.Enabled = false;
            btnizinKaydet.Enabled = false;
            btnizinGuncelle.Enabled = false;
            btnizinSil.Enabled = false;
        }
        private void Acik()
        {
            txtPersonelid.Enabled = true;
            txtPersonelAd.Enabled = true;
            txtPersonelAd.Enabled = true;
            txtPersonelSoyad.Enabled = true;
            txtRaporlu.Enabled = true;
            txtUcretli.Enabled = true;
            txtUcretsiz.Enabled = true;
            txtizinid.Enabled = true;
            comboBoxizinTipi.Enabled = true;
            dtpizinBaslangic.Enabled = true;
            dtpizinBitis.Enabled = true;
            txtizinGunSayisi.Enabled = true;
            txtKalanizin.Enabled = true;
            btnizinKaydet.Enabled = true;
            btnizinGuncelle.Enabled = true;
            btnizinSil.Enabled = true;
        }

        private void Temizle(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                    comboBoxizinTipi.Text = "";
                    /*dtpizinBaslangic.Value = DateTime.Now;
                    dtpizinBitis.Value = DateTime.Now;*/
                    listViewizinler.Items.Clear();
                }
                if (item.Controls.Count > 0)
                {
                    Temizle(item);
                }
            }
        }
        private void frmIzinislemler_Load(object sender, EventArgs e)
        {
            Kapali();
            Personel personel = new Personel();
            personel.personelListeleizin(listViewPersoneller);
            Temizle(this);
        }

        private void listViewPersoneller_DoubleClick(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            Izin izin = new Izin();
            txtPersonelid.Text = listViewPersoneller.SelectedItems[0].SubItems[0].Text;
            personel.personelleriListele(Convert.ToInt32(txtPersonelid.Text), personel);
            txtPersonelAd.Text = personel.Personelad;
            txtPersonelSoyad.Text = personel.Personelsoyad;
            txtRaporlu.Text = personel.Toplamraporlu.ToString();
            txtUcretli.Text = personel.Toplamucretli.ToString();
            txtUcretsiz.Text = personel.Toplamucretsiz.ToString();
            izin.izinListele(Convert.ToInt32(txtPersonelid.Text), listViewizinler);
            Acik();
            txtPersonelid.Enabled = false;
            txtRaporlu.Enabled = false;
            txtUcretli.Enabled = false;
            txtUcretsiz.Enabled = false;
            txtizinid.Enabled = false;
            txtKalanizin.Enabled = false;
            txtizinGunSayisi.Enabled = false;
            btnizinGuncelle.Enabled = false;
            btnizinSil.Enabled = false;
        }

        private void btnYeniizin_Click(object sender, EventArgs e)
        {
            Acik();
            btnizinGuncelle.Enabled = false;
            btnizinSil.Enabled = false;
            btnizinKaydet.BackColor = Color.YellowGreen;
            Temizle(this);
        }

        private void btnizinKaydet_Click(object sender, EventArgs e)
        {
            if (txtPersonelid.Text != "" && comboBoxizinTipi.Text != "")
            {
                Personel personel = new Personel();
                Izin izin = new Izin();
                if (izin.tekrarEdenKayit(Convert.ToInt32(txtPersonelid.Text), dtpizinBaslangic.Value, dtpizinBitis.Value))
                {
                    MessageBox.Show("AYNI TARİHTE İZİN KAYDI MEVCUT!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    izin.Personelid = Convert.ToInt32(txtPersonelid.Text);
                    izin.izinTipi = comboBoxizinTipi.Text;
                    izin.izinBaslangic = dtpizinBaslangic.Value;
                    izin.izinBitis = dtpizinBitis.Value;
                    izin.izinGunSayisi = Convert.ToInt32(txtizinGunSayisi.Text);

                    if (izin.izinHakki(Convert.ToInt32(txtKalanizin.Text), Convert.ToInt32(txtizinGunSayisi.Text)) && izin.izinKaydet(izin) && personel.gunSayisiEkle(Convert.ToInt32(txtPersonelid.Text), comboBoxizinTipi.Text, Convert.ToInt32(txtizinGunSayisi.Text)))
                    {
                        MessageBox.Show("PERSONEL İZİN KAYDI EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        izin.izinListele(listViewizinler);
                        Temizle(this);
                        Kapali();
                        personel.personelListeleizin(listViewPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("İZİN KAYDI EKLENEMEDİ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("TÜM ALANLARI DOLDURUN!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void comboBoxizinTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int yapilanizin = 0;
            Izin izin = new Izin();
            if (comboBoxizinTipi.Text == "RAPORLU")
            {
                yapilanizin = Convert.ToInt32(txtRaporlu.Text);
            }
            else if (comboBoxizinTipi.Text == "ÜCRETLİ")
            {
                yapilanizin = Convert.ToInt32(txtUcretli.Text);
            }
            else if (comboBoxizinTipi.Text == "ÜCRETSİZ")
            {
                yapilanizin = Convert.ToInt32(txtUcretsiz.Text);
            }
            txtKalanizin.Text = izin.kalanizin(comboBoxizinTipi.Text, yapilanizin).ToString();
        }

        private void dtpizinBitis_ValueChanged(object sender, EventArgs e)
        {
            DateTime ibaslangic = Convert.ToDateTime(dtpizinBaslangic.Text);
            DateTime ibitis = Convert.ToDateTime(dtpizinBitis.Text);
            if (ibaslangic != ibitis)
            {
                if (ibitis > ibaslangic)
                {
                    TimeSpan sonuc = ibitis - ibaslangic;
                    txtizinGunSayisi.Text = sonuc.TotalDays.ToString();
                    btnizinKaydet.Enabled = true;
                }
                else
                {
                    MessageBox.Show("İZİN BİTİŞ TARİHİ BAŞLANGIÇ TARİHİNDEN ÖNCE BİR TARİH OLAMAZ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnizinKaydet.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("İZİN BİTİŞ TARİHİ BAŞLANGIÇ TARİHİ İLE AYNI OLAMAZ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void listViewizinler_DoubleClick(object sender, EventArgs e)
        {
            txtizinid.Text = listViewizinler.SelectedItems[0].SubItems[0].Text;
            comboBoxizinTipi.Text = listViewizinler.SelectedItems[0].SubItems[3].Text;
            dtpizinBaslangic.Text = listViewizinler.SelectedItems[0].SubItems[4].Text;
            dtpizinBitis.Text = listViewizinler.SelectedItems[0].SubItems[5].Text;
            txtizinGunSayisi.Text = listViewizinler.SelectedItems[0].SubItems[6].Text;
            Acik();
            txtPersonelid.Enabled = false;
            txtRaporlu.Enabled = false;
            txtUcretli.Enabled = false;
            txtUcretsiz.Enabled = false;
            txtizinid.Enabled = false;
            txtKalanizin.Enabled = false;
            txtizinGunSayisi.Enabled = false;
            btnizinKaydet.Enabled = false;
            btnizinGuncelle.BackColor = Color.Goldenrod;
            btnizinSil.BackColor = Color.Tomato;
        }

        private void btnizinGuncelle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            Izin izin = new Izin();
            string[] deger = new string[2];
            izin.eskiizin(Convert.ToInt32(txtizinid.Text), deger);
            string eskiizinTipi = deger[0];
            int eskiGunSayisi = Convert.ToInt32(deger[1]);

            if (txtPersonelid.Text != "")
            {
                DialogResult secenek = MessageBox.Show("PERSONEL İZİN BİLGİLERİNİ GÜNCELLEMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    if (izin.tekrarEdenKayit(Convert.ToInt32(txtizinid.Text), comboBoxizinTipi.Text, dtpizinBaslangic.Value, dtpizinBitis.Value))
                    {
                        MessageBox.Show("BU İZİN BİLGİSİ SİSTEMDE ZATEN VAR!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        izin.Personelid = Convert.ToInt32(txtPersonelid.Text);
                        if (izin.izinHakki(Convert.ToInt32(txtKalanizin.Text), Convert.ToInt32(txtizinGunSayisi.Text)) && personel.gunSayisiGuncelle(izin.Personelid, eskiizinTipi, 
                        comboBoxizinTipi.Text, eskiGunSayisi, Convert.ToInt32(txtizinGunSayisi.Text)) && izin.izinGuncelle(izin))
                        {
                            MessageBox.Show("PERSONEL İZİN BİLGİLERİ GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            izin.izinListele(listViewizinler);
                            personel.personelListeleizin(listViewPersoneller);
                            Temizle(this);
                            btnizinKaydet.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("İZİN BİLGİLERİ GÜNCELLENEMEDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("ÖNCE BİR PERSONEL SEÇİNİZ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnizinSil_Click(object sender, EventArgs e)
        {
            if (txtPersonelid.Text != "")
            {
                DialogResult secenek = MessageBox.Show("PERSONEL İZİN BİLGİLERİNİ SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    Personel personel = new Personel();
                    Izin izin = new Izin();
                    bool sonuc = izin.izinSil(Convert.ToInt32(txtizinid.Text));
                    if (sonuc && personel.gunSayisiEkle(Convert.ToInt32(txtPersonelid.Text), comboBoxizinTipi.Text, Convert.ToInt32(txtizinGunSayisi.Text) * (-1)))
                    {
                        MessageBox.Show("PERSONEL İZİN BİLGİLERİ SİLİNDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle(this);
                        Kapali();
                        izin.izinListele(listViewizinler);
                        personel.personelListeleizin(listViewPersoneller);
                    }
                    else
                    {
                        MessageBox.Show("İZİN BİLGİLERİ SİLİNEMEDİ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("ÖNCE BİR PERSONEL SEÇİNİZ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
