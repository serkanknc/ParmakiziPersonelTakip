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
    class Mesai
    {
        private int _mesaiid;
        private int _personelid;
        private DateTime _mesaitarihi;
        private string _girissaati;
        private string _cikissaati;
        public int Mesaiid
        {
            get
            {
                return _mesaiid;
            }
            set
            {
                _mesaiid = value;
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
        public DateTime Mesaitarihi
        {
            get
            {
                return _mesaitarihi;
            }
            set
            {
                _mesaitarihi = value;
            }
        }
        public string Girissaati
        {
            get
            {
                return _girissaati;
            }
            set
            {
                _girissaati = value;
            }
        }
        public string Cikissaati
        {
            get
            {
                return _cikissaati;
            }
            set
            {
                _cikissaati = value;
            }
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CTQFLUU;Initial Catalog=PersonelTakip;Integrated Security=True");

        public void mesaiEkle_sil_guncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void mesaiListele(int personelid, ListView lvMesailer)
        {
            lvMesailer.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT mesaiid,personelAd,personelSoyad,mesaiTarihi,girisSaati,cikisSaati FROM mesai m INNER JOIN personel p on m.personelid=p.personelid " +
            "WHERE m.personelid=@id AND m.silindi=0 ORDER BY mesaiTarihi", baglanti);
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
                    lvMesailer.Items.Add(datareader[0].ToString());
                    lvMesailer.Items[i].SubItems.Add(datareader[1].ToString());
                    lvMesailer.Items[i].SubItems.Add(datareader[2].ToString());
                    lvMesailer.Items[i].SubItems.Add(Convert.ToDateTime(datareader[3]).ToShortDateString());
                    lvMesailer.Items[i].SubItems.Add(datareader[4].ToString());
                    lvMesailer.Items[i].SubItems.Add(datareader[5].ToString());
                    i++;
                }
            }
            datareader.Close();
            baglanti.Close();
        }

        public Mesai mesaiListele(int mesaiid, Mesai mesai)
        {
            SqlCommand komut = new SqlCommand("SELECT personelid,mesaiTarihi,girisSaati,cikisSaati FROM mesai WHERE mesaiid=@id AND silindi=0", baglanti);
            komut.Parameters.Add("@id", SqlDbType.Int).Value = mesaiid;
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataReader datareader = komut.ExecuteReader();
            datareader.Read();
            if (datareader.HasRows)
            {
                mesai.Personelid = Convert.ToInt32(datareader[0]);
                mesai.Mesaitarihi = Convert.ToDateTime(datareader[1]);
                mesai.Girissaati = datareader[2].ToString();
                mesai.Cikissaati = datareader[3].ToString();
            }
            datareader.Close();
            baglanti.Close();
            return mesai;
        }

        public bool tekrarEdenKayit(int personelid, DateTime mtarihi)
        {
            bool durum = false;
            SqlCommand komut = new SqlCommand("SELECT * FROM mesai WHERE personelid=@id AND mesaiTarihi=@mtarihi AND silindi=0", baglanti);
            komut.Parameters.Add("@id", SqlDbType.Int).Value = personelid;
            komut.Parameters.Add("@mtarihi", SqlDbType.Date).Value = mtarihi;

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

        public bool tekrarEdenKayitUpdate(int personelid, int mesaiid, DateTime mtarihi)
        {
            bool durum = false;
            SqlCommand komut = new SqlCommand("SELECT * FROM mesai WHERE personelid=@pid AND mesaiTarihi=@mtarihi AND mesaiid!=@mid AND silindi=0", baglanti);
            komut.Parameters.AddWithValue("@pid", SqlDbType.Int).Value = personelid;
            komut.Parameters.AddWithValue("@mtarihi", SqlDbType.Date).Value = mtarihi;
            komut.Parameters.AddWithValue("@mid", SqlDbType.Int).Value = mesaiid;

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
    }
}
