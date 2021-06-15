using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ParmakiziPersonelTakip
{
    class Izin
    {
        private int _izinid;
        private int _personelid;
        private string _izinTipi;
        private DateTime _izinBaslangic;
        private DateTime _izinBitis;
        private int _izinGunSayisi;

        public int izinid
        {
            get
            {
                return _izinid;
            }
            set
            {
                _izinid = value;
            }
        }
        public int Personelid
        {
            get
            {
                return _personelid;
            }
            set
            {
                _personelid = value;
            }
        }
        public string izinTipi
        {
            get
            {
                return _izinTipi;
            }
            set
            {
                _izinTipi = value;
            }
        }
        public DateTime izinBaslangic
        {
            get
            {
                return _izinBaslangic;
            }
            set
            {
                _izinBaslangic = value;
            }
        }
        public DateTime izinBitis

        {
            get
            {
                return _izinBitis;
            }
            set
            {
                _izinBitis = value;
            }
        }
        public int izinGunSayisi
        {
            get
            {
                return _izinGunSayisi;
            }
            set
            {
                _izinGunSayisi = value;
            }
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CTQFLUU;Initial Catalog=PersonelTakip;Integrated Security=True");

        public void izinListele(int personelid, ListView lvizinler)
        {
            lvizinler.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT izinid,personelAd,personelSoyad,izinTipi,izinBaslangic,izinBitis,izinliGunSayisi " +
            "FROM personel p INNER JOIN izin i ON p.personelid=i.personelid WHERE i.personelid=@id AND i.silindi=0", baglanti);
            komut.Parameters.Add("@id", SqlDbType.Int).Value = personelid;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader datareader = komut.ExecuteReader();
            if (datareader.HasRows)
            {
                int i = 0;
                while (datareader.Read())
                {
                    lvizinler.Items.Add(datareader[0].ToString());
                    lvizinler.Items[i].SubItems.Add(datareader[1].ToString());
                    lvizinler.Items[i].SubItems.Add(datareader[2].ToString());
                    lvizinler.Items[i].SubItems.Add(datareader[3].ToString());
                    lvizinler.Items[i].SubItems.Add(Convert.ToDateTime(datareader[4]).ToShortDateString());
                    lvizinler.Items[i].SubItems.Add(Convert.ToDateTime(datareader[5]).ToShortDateString());
                    lvizinler.Items[i].SubItems.Add(datareader[6].ToString());
                    i++;
                }
            }
            datareader.Close();
            baglanti.Close();
        }

        public void izinListele(ListView lvizinler)
        {
            lvizinler.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT izinid,personelAd,personelSoyad,izinTipi,izinBaslangic,izinBitis,izinliGunSayisi " +
            "FROM izin i INNER JOIN personel p ON i.personelid=p.personelid WHERE i.silindi=0", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader datareader = komut.ExecuteReader();
            if (datareader.HasRows)
            {
                int i = 0;
                while (datareader.Read())
                {
                    lvizinler.Items.Add(datareader[0].ToString());
                    lvizinler.Items[i].SubItems.Add(datareader[1].ToString());
                    lvizinler.Items[i].SubItems.Add(datareader[2].ToString());
                    lvizinler.Items[i].SubItems.Add(datareader[3].ToString());
                    lvizinler.Items[i].SubItems.Add(Convert.ToDateTime(datareader[4]).ToShortDateString());
                    lvizinler.Items[i].SubItems.Add(Convert.ToDateTime(datareader[5]).ToShortDateString());
                    lvizinler.Items[i].SubItems.Add(datareader[6].ToString());
                    i++;
                }
            }
            datareader.Close();
            baglanti.Close();
        }

        public bool tekrarEdenKayit(int personelid, DateTime izinBaslangic, DateTime izinBitis)
        {
            bool durum = false;
            SqlCommand komut = new SqlCommand("SELECT * FROM izin WHERE personelid=@id AND izinBaslangic=@baslangic OR izinBitis=@bitis AND silindi=0", baglanti);
            komut.Parameters.Add("@id", SqlDbType.Int).Value = personelid;
            komut.Parameters.Add("@baslangic", SqlDbType.Date).Value = izinBaslangic;
            komut.Parameters.Add("@bitis", SqlDbType.Date).Value = izinBitis;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader datareader = komut.ExecuteReader();
            if (datareader.HasRows)
            {
                durum = true;
            }
            datareader.Close();
            baglanti.Close();
            return durum;
        }

        public bool tekrarEdenKayit(int personelid, string izinTipi, DateTime izinBaslangic, DateTime izinBitis)
        {
            bool durum = false;
            SqlCommand komut = new SqlCommand("SELECT * FROM izin WHERE personelid=@id AND izinBaslangic=@baslangic AND izinBitis=@bitis AND izinTipi=@tip AND silindi=0", baglanti);
            komut.Parameters.Add("@id", SqlDbType.Int).Value = personelid;
            komut.Parameters.Add("@tip", SqlDbType.VarChar).Value = izinTipi;
            komut.Parameters.Add("@baslangic", SqlDbType.Date).Value = izinBaslangic;
            komut.Parameters.Add("@bitis", SqlDbType.Date).Value = izinBitis;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader datareader = komut.ExecuteReader();
            if (datareader.HasRows)
            {
                durum = true;
            }
            datareader.Close();
            baglanti.Close();
            return durum;
        }
        public bool izinHakki(int kalanizin, int istenilenizin)
        {
            bool durum = false;
            if (istenilenizin <= kalanizin)
            {
                durum = true;
            }
            else
            {
                durum = false;
            }
            return durum;
        }

        public bool izinKaydet(Izin izin)
        {
            bool sonuc = false;
            SqlCommand komut = new SqlCommand("INSERT INTO izin (personelid,izinTipi,izinBaslangic,izinBitis,izinliGunSayisi) VALUES (@id,@izintip,@ibaslangic,@ibitis,@gunsayisi)", baglanti);
            komut.Parameters.Add("@id", SqlDbType.Int).Value = izin._personelid;
            komut.Parameters.Add("@izintip", SqlDbType.VarChar).Value = izin._izinTipi;
            komut.Parameters.Add("@ibaslangic", SqlDbType.Date).Value = izin._izinBaslangic;
            komut.Parameters.Add("@ibitis", SqlDbType.Date).Value = izin._izinBitis;
            komut.Parameters.Add("@gunsayisi", SqlDbType.Int).Value = izin._izinGunSayisi;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            sonuc = Convert.ToBoolean(komut.ExecuteNonQuery());
            baglanti.Close();
            return sonuc;
        }

        public int kalanizin(string izinTipi, int yapilanizin)
        {
            int izinlimit = 0;
            if (izinTipi == "RAPORLU")
            {
                izinTipi = "RAPORLU";
            }
            if (izinTipi == "ÜCRETLİ")
            {
                izinTipi = "ÜCRETLİ";
            }
            if (izinTipi == "ÜCRETSİZ")
            {
                izinTipi = "ÜCRETSİZ";
            }
            SqlCommand komut = new SqlCommand("SELECT izinLimit FROM izinLimit WHERE izinTipi=@tip", baglanti);
            komut.Parameters.Add("@tip", SqlDbType.VarChar).Value = izinTipi;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            izinlimit = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            return izinlimit - yapilanizin;
        }

        public bool izinSil(int izinid)
        {
            bool sonuc = false;
            SqlCommand komut = new SqlCommand("UPDATE izin SET silindi=1 WHERE izinid=@id", baglanti);
            komut.Parameters.Add("@id", SqlDbType.Int).Value = izinid;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            sonuc = Convert.ToBoolean(komut.ExecuteNonQuery());
            baglanti.Close();
            return sonuc;
        }
        public bool izinGuncelle(Izin izin)
        {
            bool sonuc = false;
            SqlCommand komut = new SqlCommand("UPDATE izin SET personelid=@pid, izinTipi=@tip, izinBaslangic=@baslangic, izinBitis=@bitis, izinliGunSayisi=@gunsayisi WHERE izinid=@izinid AND silindi=0", baglanti);
            komut.Parameters.Add("@izinid", SqlDbType.Int).Value = izin._izinid;
            komut.Parameters.Add("@pid", SqlDbType.Int).Value = izin._personelid;
            komut.Parameters.Add("@tip", SqlDbType.VarChar).Value = izin._izinTipi;
            komut.Parameters.Add("@baslangic", SqlDbType.Date).Value = izin._izinBaslangic;
            komut.Parameters.Add("@bitis", SqlDbType.Date).Value = izin._izinBitis;
            komut.Parameters.Add("@gunsayisi", SqlDbType.Int).Value = izin._izinGunSayisi;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            sonuc = Convert.ToBoolean(komut.ExecuteNonQuery());
            baglanti.Close();
            return sonuc;
        }
        public void eskiizin(int izinid, string[] deger)
        {
            deger[0] = "";
            deger[1] = "";

            SqlCommand komut = new SqlCommand("SELECT izinTipi FROM izin WHERE izinid=@id", baglanti);
            komut.Parameters.Add("@id", SqlDbType.Int).Value = izinid;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            deger[0] = komut.ExecuteScalar().ToString();
            baglanti.Close();

            SqlCommand komutt = new SqlCommand("SELECT izinliGunSayisi FROM izin WHERE izinid=@id", baglanti);
            komutt.Parameters.Add("@id", SqlDbType.Int).Value = izinid;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            deger[1] = komutt.ExecuteScalar().ToString();
            baglanti.Close();
        }
    }
}
