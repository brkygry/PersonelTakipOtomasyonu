using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        public static String adi, soyadi, yetki;
        public static int kullanici_ID = 0;

        //X LABEL
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            radioYonetici.Checked = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool durum = false;
            Veritabani.baglanti.Open();
            SqlCommand selectsorgu = new SqlCommand("select * from Kullanicilar where kullanici_adi = '" + txtKullaniciAdi.Text + "'", Veritabani.baglanti);
            SqlDataReader kayitokuma = selectsorgu.ExecuteReader();
            while (kayitokuma.Read())
            {
                durum = true;
                break;
            }
            if (durum == true)
            {
                if (radioYonetici.Checked == true && kayitokuma["yetki"].ToString() == "Yönetici")
                {
                    if (kayitokuma["kullanici_adi"].ToString() == txtKullaniciAdi.Text && kayitokuma["parola"].ToString() == txtSifre.Text)
                    {
                        durum = true;
                        kullanici_ID = int.Parse(kayitokuma[0].ToString());
                        adi = kayitokuma.GetValue(1).ToString();
                        soyadi = kayitokuma.GetValue(2).ToString();
                        yetki = kayitokuma.GetValue(3).ToString();
                        this.Hide();
                        frmAnasayfa anaSayfa = new frmAnasayfa();
                        anaSayfa.Show();
                    }
                    else
                        MessageBox.Show("Yanlış Şifre!", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioKullanici.Checked == true && kayitokuma["yetki"].ToString() == "Kullanıcı")
                {
                    if (kayitokuma["kullanici_adi"].ToString() == txtKullaniciAdi.Text && kayitokuma["parola"].ToString() == txtSifre.Text)
                    {
                        durum = true;
                        kullanici_ID = int.Parse(kayitokuma[0].ToString());
                        adi = kayitokuma.GetValue(1).ToString();
                        soyadi = kayitokuma.GetValue(2).ToString();
                        yetki = kayitokuma.GetValue(3).ToString();
                        this.Hide();
                        frmAnasayfa anaSayfa = new frmAnasayfa();
                        anaSayfa.Show();
                    }
                    else
                        MessageBox.Show("Yanlış Şifre!", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Veritabani.baglanti.Close();
            }
            Veritabani.baglanti.Close();
        }
    }
}

