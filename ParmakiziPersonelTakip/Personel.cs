using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ParmakiziPersonelTakip
{
    class Personel
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CTQFLUU;Initial Catalog=PersonelTakip;Integrated Security=True");
        DataTable tablo;

        private int _personelid;
        private string _personelTcKimlik;
        private string _personelAd;
        private string _personelSoyad;
        private string _personelTelefon;
        private string _personelAdres;
        private string _personelDepartman;
        private double _personelMaas;
        private DateTime _personelGirisTarihi;
        private DateTime _personelCikisTarihi;
        private int _toplamRaporlu;
        private int _toplamUcretli;
        private int _toplamUcretsiz;

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
        public string Personeltc
        {
            get
            {
                return _personelTcKimlik;
            }
            set
            {
                _personelTcKimlik = value;
            }
        }
        public string Personelad
        {
            get
            {
                return _personelAd;
            }
            set
            {
                _personelAd = value;
            }
        }
        public string Personelsoyad
        {
            get
            {
                return _personelSoyad;
            }
            set
            {
                _personelSoyad = value;
            }
        }
        public string Personeltelefon
        {
            get
            {
                return _personelTelefon;
            }
            set
            {
                _personelTelefon = value;
            }
        }
        public string Personeladres
        {
            get
            {
                return _personelAdres;
            }
            set
            {
                _personelAdres = value;
            }
        }
        public string Personeldepartman
        {
            get
            {
                return _personelDepartman;
            }
            set
            {
                _personelDepartman = value;
            }
        }
        public double Personelmaas
        {
            get
            {
                return _personelMaas;
            }
            set
            {
                _personelMaas = value;
            }
        }
        public DateTime Personelgiristarihi
        {
            get
            {
                return _personelGirisTarihi;
            }
            set
            {
                _personelGirisTarihi = value;
            }
        }
        public DateTime Personelcikistarihi

        {
            get
            {
                return _personelCikisTarihi;
            }
            set
            {
                _personelCikisTarihi = value;
            }
        }
        public int Toplamraporlu
        {
            get
            {
                return _toplamRaporlu;
            }
            set
            {
                _toplamRaporlu = value;
            }
        }
        public int Toplamucretli
        {
            get
            {
                return _toplamUcretli;
            }
            set
            {
                _toplamUcretli = value;
            }
        }
        public int Toplamucretsiz

        {
            get
            {
                return _toplamUcretsiz;
            }
            set
            {
                _toplamUcretsiz = value;
            }
        }


        public void personelEkle_sil_guncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable personelListele(SqlDataAdapter adaptor, string sorgu)
        {
            tablo = new DataTable();
            adaptor = new SqlDataAdapter(sorgu, baglanti);
            adaptor.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void personelListeleMesai(ListView lvpersoneller)
        {
            lvpersoneller.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT personelid, personelTcKimlik, personelAd, personelSoyad, personelTelefon, personelAdres, personelDepartman FROM personel WHERE silindi = 0", baglanti);
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
                    lvpersoneller.Items.Add(datareader[0].ToString());
                    lvpersoneller.Items[i].SubItems.Add(datareader[2].ToString());
                    lvpersoneller.Items[i].SubItems.Add(datareader[3].ToString());
                    lvpersoneller.Items[i].SubItems.Add(datareader[4].ToString());
                    lvpersoneller.Items[i].SubItems.Add(datareader[5].ToString());
                    i++;
                }
            }
            datareader.Close();
            baglanti.Close();
        }
        public Personel personelleriListele(int personelid, Personel personel)
        {
            SqlCommand komut = new SqlCommand("SELECT personelTcKimlik,personelAd,personelSoyad,personelTelefon,personelAdres,personelDepartman,personelMaas,personelGirisTarihi,personelCikisTarihi,toplamRaporlu,toplamUcretli,toplamUcretsiz FROM personel " +
            "WHERE personelid=@id AND silindi=0", baglanti); ;
            komut.Parameters.Add("@id", SqlDbType.Int).Value = personelid;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader datareader = komut.ExecuteReader();
            datareader.Read();
            if (datareader.HasRows)
            {
                personel.Personeltc = datareader[0].ToString();
                personel.Personelad = datareader[1].ToString();
                personel.Personelsoyad = datareader[2].ToString();
                personel.Personeltelefon = datareader[3].ToString();
                personel.Personeladres = datareader[4].ToString();
                personel.Personeldepartman = datareader[5].ToString();
                personel.Personelmaas = Convert.ToDouble(datareader[6]);
                personel.Personelgiristarihi = Convert.ToDateTime(datareader[7].ToString());
                personel.Personelcikistarihi = Convert.ToDateTime(datareader[8].ToString());
                personel.Toplamraporlu = Convert.ToInt32(datareader[9]);
                personel.Toplamucretli = Convert.ToInt32(datareader[10]);
                personel.Toplamucretsiz = Convert.ToInt32(datareader[11]);
            }
            datareader.Close();
            baglanti.Close();
            return personel;
        }

        public void personelListeleizin(ListView lvPersoneller)
        {
            lvPersoneller.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT personelid,personelAd,personelSoyad,personelTelefon,personelAdres,toplamRaporlu,toplamUcretli,toplamUcretsiz FROM personel WHERE silindi=0", baglanti);
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
                    lvPersoneller.Items.Add(datareader[0].ToString());
                    lvPersoneller.Items[i].SubItems.Add(datareader[1].ToString());
                    lvPersoneller.Items[i].SubItems.Add(datareader[2].ToString());
                    lvPersoneller.Items[i].SubItems.Add(datareader[3].ToString());
                    lvPersoneller.Items[i].SubItems.Add(datareader[4].ToString());
                    lvPersoneller.Items[i].SubItems.Add(datareader[5].ToString());
                    lvPersoneller.Items[i].SubItems.Add(datareader[6].ToString());
                    lvPersoneller.Items[i].SubItems.Add(datareader[7].ToString());
                    i++;
                }
            }
            datareader.Close();
            baglanti.Close();
        }

        public bool gunSayisiEkle(int personelid, string izinTipi, int gunsayisi)
        {
            bool sonuc = false;
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            if (izinTipi == "RAPORLU")
            {
                komut.CommandText = "UPDATE personel SET toplamRaporlu+=@gunsayisi WHERE personelid=@id";
            }
            else if (izinTipi == "ÜCRETLİ")
            {
                komut.CommandText = "UPDATE personel SET toplamUcretli+=@gunsayisi WHERE personelid=@id";
            }
            else
            {
                komut.CommandText = "UPDATE personel SET toplamUcretsiz+=@gunsayisi WHERE personelid=@id";
            }
            komut.Connection = baglanti;
            komut.Parameters.Add("@id", SqlDbType.Int).Value = personelid;
            komut.Parameters.Add("@gunsayisi", SqlDbType.Int).Value = gunsayisi;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            sonuc = Convert.ToBoolean(komut.ExecuteNonQuery());
            baglanti.Close();
            return sonuc;
        }
        public bool gunSayisiGuncelle(int personelid, string eskiizinTipi, string yeniizinTipi, int eskiGunSayisi, int yeniGunSayisi)
        {
            bool sonuc = false;
            SqlCommand komut = new SqlCommand();
            komut.CommandType = CommandType.Text;
            if (eskiizinTipi == "RAPORLU" && yeniizinTipi == "ÜCRETLİ")
            {
                komut.CommandText = "UPDATE personel SET toplamRaporlu-=@eskiGunSayisi, toplamUcretli+=@yeniGunSayisi WHERE personelid=@id";
            }
            else if (eskiizinTipi == "RAPORLU" && yeniizinTipi == "ÜCRETSİZ")
            {
                komut.CommandText = "UPDATE personel SET toplamRaporlu-=@eskiGunSayisi, toplumUcretsiz+=@yeniGunSayisi WHERE personelid=@id";
            }
            else if (eskiizinTipi == "ÜCRETLİ" && yeniizinTipi == "RAPORLU")
            {
                komut.CommandText = "UPDATE personel SET toplamUcretli-=@eskiGunSayisi, toplamRaporlu+=@yeniGunSayisi WHERE personelid=@id";
            }
            else if (eskiizinTipi == "ÜCRETLİ" && yeniizinTipi == "ÜCRETSİZ")
            {
                komut.CommandText = "UPDATE personel SET toplamUcretli-=@eskiGunSayisi, toplamUcretsiz+=@yeniGunSayisi WHERE personelid=@id";
            }
            else if (eskiizinTipi == "ÜCRETSİZ" && yeniizinTipi == "RAPORLU")
            {
                komut.CommandText = "UPDATE personel SET toplamUcretsiz-=@eskiGunSayisi, toplamRaporlu+=@yeniGunSayisi WHERE personelid=@id";
            }
            else
            {//ÜCRETSİZ-ÜCRETLİ
                komut.CommandText = "UPDATE personel SET toplamUcretsiz-=@eskiGunSayisi, toplamUcretli+=@yeniGunSayisi WHERE personelid=@id";
            }
            komut.Connection = baglanti;
            komut.Parameters.Add("@id", SqlDbType.Int).Value = personelid;
            komut.Parameters.Add("@eskiGunSayisi", SqlDbType.Int).Value = eskiGunSayisi;
            komut.Parameters.Add("@yeniGunSayisi", SqlDbType.Int).Value = yeniGunSayisi;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            sonuc = Convert.ToBoolean(komut.ExecuteNonQuery());
            baglanti.Close();
            return sonuc;
        }
    }
}

