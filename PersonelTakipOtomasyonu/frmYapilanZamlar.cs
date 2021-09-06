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
    public partial class frmYapilanZamlar : Form
    {
        public frmYapilanZamlar()
        {
            InitializeComponent();
            comboPersoneller.SelectedIndex = 0;
            radioYüzde.Checked = true;
        }

        private void frmYapilanZamlar_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil; i >= (yil-10); i--)
            {
                comboYil.Items.Add(i);
            }

            YapilanZamlar.ComboyaPersonelGetir(comboPersoneller);
        }

        public void temizle()
        {
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            comboYil.Text = "";
            comboAy.Text = "";
            txtAciklama.Text = "";
            txtFiyat.Text = "";
            txtYuzde.Text = "";
            
        }
        private void btnOnay_Click(object sender, EventArgs e)
        {
            //Dönem
            if (comboAy.Text == "" || comboYil.Text == "")
                label1.ForeColor = Color.Red;
            else
                label1.ForeColor = Color.Black;

            //Yüzde
            if (txtYuzde.Text == "")
                label3.ForeColor = Color.Red;
            else
                label3.ForeColor = Color.Black;

            //Fiyat
            if (txtFiyat.Text == "")
                label4.ForeColor = Color.Red;
            else
                label4.ForeColor = Color.Black;

            //Açıklama
            if (txtAciklama.Text == "")
                label5.ForeColor = Color.Red;
            else
                label5.ForeColor = Color.Black;

            if (comboAy.Text != "" && comboYil.Text != "" && txtAciklama.Text != "" && (txtFiyat.Text != "" || txtYuzde.Text != ""))
            {
                Kullanicilar k = new Kullanicilar();
                YapilanZamlar y = new YapilanZamlar();
                y.Donem = comboAy.Text + "/" + comboYil.Text;
                y.Personel = comboPersoneller.Text;
                y.Aciklama = txtAciklama.Text;
                y.Tarih = DateTime.Now;
                k.KullaniciID = frmGirisEkrani.kullanici_ID;

                if (radioYüzde.Checked == true)
                {
                    y.Yuzde = decimal.Parse(txtYuzde.Text);
                    if (comboPersoneller.SelectedIndex == 0)
                    {
                        string sql = "update Personeller set maas = maas + (maas * '" + y.Yuzde + "' / 100)";
                        SqlCommand komut = new SqlCommand();
                        Veritabani.ESG(komut, sql);
                        MessageBox.Show("Tüm personellerin maaşına % '" + y.Yuzde + "' zam yapıldı.", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string sql = "update Personeller set maas = maas + (maas * '" + y.Yuzde + "')/100 where personelID = '" + lblPersonelID.Text + "'";
                        SqlCommand komut = new SqlCommand();
                        Veritabani.ESG(komut, sql);
                        MessageBox.Show("'" + comboPersoneller.Text + "' personelinin maaşına % '" + y.Yuzde + "' zam yapıldı.", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string sql2 = "insert into YapilanZamlar(KullaniciID, Donem, Personeller, Yuzde, Aciklama, Tarih) values ('" + k.KullaniciID + "', '" + y.Donem + "' , " +
                        "'" + y.Personel + "' , @Yuzde , '" + y.Aciklama + "' , @Tarih)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.Add("@Yuzde", SqlDbType.Decimal).Value = y.Yuzde;
                    komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = y.Tarih;
                    Veritabani.ESG(komut2, sql2);
                }

                if (radioFiyat.Checked == true)
                {
                    y.Fiyat = decimal.Parse(txtFiyat.Text);
                    if (comboPersoneller.SelectedIndex == 0)
                    {
                        string sql = "update Personeller set maas = maas + '" + y.Fiyat + "'";
                        SqlCommand komut = new SqlCommand();
                        Veritabani.ESG(komut, sql);
                        MessageBox.Show("Tüm personellerin maaşına '" + y.Fiyat + "' TL zam yapıldı.", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string sql = "update Personeller set maas = maas + '" + y.Fiyat + "' where personelID = '" + lblPersonelID.Text + "'";
                        SqlCommand komut = new SqlCommand();
                        Veritabani.ESG(komut, sql);
                        MessageBox.Show("'" + comboPersoneller.Text + "' personelinin maaşına  '" + y.Fiyat + "' TL zam yapıldı.", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    string sql2 = "insert into YapilanZamlar(KullaniciID, Donem, Personeller, Fiyat, Aciklama, Tarih) values ('" + k.KullaniciID + "', '" + y.Donem + "' , " +
                        "'" + y.Personel + "' , @Fiyat , '" + y.Aciklama + "' , @Tarih)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = y.Fiyat;
                    komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = y.Tarih;
                    Veritabani.ESG(komut2, sql2);
                    temizle();
                }
            }
            else
                MessageBox.Show("Yazı rengi kırmızı alanları tekrar gözden geçirin!", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void radioYüzde_CheckedChanged(object sender, EventArgs e)
        {
            txtFiyat.Enabled = false;
            txtYuzde.Enabled = true;
        }

        private void radioFiyat_CheckedChanged(object sender, EventArgs e)
        {
            txtYuzde.Enabled = false;
            txtFiyat.Enabled = true;
        }

        private void comboYil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPersoneller.SelectedIndex == 0)
            {
                lblPersonelID.Text = "0";
                return;
            }
            YapilanZamlar.ComboSecilirsePersonelIDGetir(comboPersoneller, lblPersonelID);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtYuzde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
