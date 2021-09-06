using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class izin:Personeller
    {

        public izin()
        {
            izin.sql = "select * from izinTurleri";
            izin.value = "izinTurID";
            izin.text = "izinTuru";
        }

        private int _izinHareketID;
        private int _izinTurID;
        private int _kullaniciID;
        private string _izinTuru;
        private DateTime _izinBaslangic;
        private DateTime _izinBitis;
        private DateTime _Saat;

        public int IzinHareketID { get => _izinHareketID; set => _izinHareketID = value; }
        public int IzinTurID { get => _izinTurID; set => _izinTurID = value; }
        public int KullaniciID { get => _kullaniciID; set => _kullaniciID = value; }
        public string IzinTuru { get => _izinTuru; set => _izinTuru = value; }
        public DateTime IzinBaslangic { get => _izinBaslangic; set => _izinBaslangic = value; }
        public DateTime IzinBitis { get => _izinBitis; set => _izinBitis = value; }
        public DateTime Saat { get => _Saat; set => _Saat = value; }



        public static SqlDataReader ListViewKayitGetir(ListView lst)
        {
            lst.Items.Clear();
            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from izinTurleri", Veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                lst.Items.Add(ekle);
            }
            Veritabani.baglanti.Close();
            return dr;
        }


        public static string sql = "select * from Departmanlar";
        public static string value = "DepartmanID";
        public static string text = "Departman";

        public static DataTable ComboyaKayitGetir(ComboBox combo)
        {
            DataTable tbl = new DataTable();
            Veritabani.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, Veritabani.baglanti);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = value;
            combo.DisplayMember = text;
            Veritabani.baglanti.Close();
            return tbl;
        }
    }
}
