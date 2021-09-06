using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class YapilanZamlar
    {
        #region Zamlar Kapsulleme
        private int _ZamID;
        private string _Personel;
        private string _Donem;
        private decimal _Yuzde;
        private decimal _Fiyat;
        private string _Aciklama;
        private DateTime _Tarih;

        public int ZamID { get => _ZamID; set => _ZamID = value; }
        public string Personel { get => _Personel; set => _Personel = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public decimal Yuzde { get => _Yuzde; set => _Yuzde = value; }
        public decimal Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        #endregion

        public static SqlDataReader ComboyaPersonelGetir(ComboBox cmb)
        {
            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select PersonelID, Adi, Soyadi from Personeller where Durumu = 'Aktif' ",Veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmb.Items.Add(dr[0] + "." + dr[1] + " " + dr[2]);   
            }
            Veritabani.baglanti.Close();
            return dr;
        }
        public static SqlDataReader ComboSecilirsePersonelIDGetir(ComboBox cmb, Label lbl)
        {
            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select PersonelID, Adi, Soyadi from Personeller", Veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                if(cmb.SelectedItem.ToString()== dr[0] + "." + dr[1] + " " + dr[2])
                {
                    lbl.Text = dr[0].ToString();
                }

            }
            Veritabani.baglanti.Close();
            return dr;
        }
    }
}
