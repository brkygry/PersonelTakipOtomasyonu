using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class Kullanicilar
    {
        private int _KullaniciID;
        private string _tc_no;
        private string _ad;
        private string _soyad;
        private string _yetki;
        private string _KullaniciAdı;
        private string _Parola;

        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string Tc_no { get => _tc_no; set => _tc_no = value; }
        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
        public string Yetki { get => _yetki; set => _yetki = value; }
        public string KullaniciAdı { get => _KullaniciAdı; set => _KullaniciAdı = value; }
        public string Parola { get => _Parola; set => _Parola = value; }


        //public static String tc_no, adi, soyadi, yetki;

        //Yerel değişkenler
        public static bool durum = false;
        public static SqlDataReader KullaniciGirisi(string kullanici_adi, string parola)
        {
            Kullanicilar k = new Kullanicilar();
            k._KullaniciAdı = kullanici_adi;
            k._Parola = parola;
            //k._yetki = yetki;
            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kullanicilar where kullanici_adi = '" + k._KullaniciAdı + "' and parola = '" + k._Parola + "'",Veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                durum = true;
                k.KullaniciID = int.Parse(dr[0].ToString());
            }
            else
            {
                durum = false;
            }
            dr.Close();
            Veritabani.baglanti.Close();
            return dr;
        }
    }
}
