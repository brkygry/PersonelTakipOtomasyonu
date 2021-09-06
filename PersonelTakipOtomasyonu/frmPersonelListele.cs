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
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaKayitGetir(comboDepartman);
            YenileListele();
        }

        private void YenileListele()
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.tc_no, p.Adi, p.Soyadi, p.Telefon, p.Adres, p.Email, d.Departman, p.Durumu, " +
                "p.Maas, p.GirisTarihi, p.Aciklama, p.Mezuniyet, p.DogumTarihi from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID");

            lblToplamKayit.Text = "Toplam " + (dataGridView1.Rows.Count - 1) + " kayıt listelendi.";
            decimal toplammaas = 0;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                toplammaas += decimal.Parse(dataGridView1.Rows[i].Cells["Maas"].Value.ToString()); 
            }
            lblToplamMaaş.Text = "Listede toplam " + toplammaas.ToString("0.00") + " TL maaş hesaplandı.";
        }

        private void temizle()
        {
            dateTimePickerGiris.Value = DateTime.Now;
            dateTimePickerDogum.Value = DateTime.Now;
            comboDepartman.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }
        Personeller p = new Personeller();
        Kullanicilar k = new Kullanicilar();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            personelIDtxt.Text = dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells["Soyadi"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txtTlefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells["Maas"].Value.ToString();
            dateTimePickerGiris.Text = dataGridView1.CurrentRow.Cells["GirisTarihi"].Value.ToString();
            dateTimePickerDogum.Text = dataGridView1.CurrentRow.Cells["DogumTarihi"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            comboDepartman.Text = dataGridView1.CurrentRow.Cells["Departman"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

                if(personelIDtxt.Text == "")
                    label7.ForeColor = Color.Red;
                else
                    label7.ForeColor = Color.Black;

                //Ad
                if (txtAdi.Text == "" || txtSoyadi.Text.Length < 2)
                    label1.ForeColor = Color.Red;
                else
                    label1.ForeColor = Color.Black;

                //Soyad
                if (txtSoyadi.Text == "" || txtSoyadi.Text.Length < 2)
                    label2.ForeColor = Color.Red;
                else
                    label2.ForeColor = Color.Black;

                //Departman
                if (comboDepartman.Text == "")
                    label6.ForeColor = Color.Red;
                else
                    label6.ForeColor = Color.Black;

                //Email
                if (txtEmail.Text == "")
                    label5.ForeColor = Color.Red;
                else
                    label5.ForeColor = Color.Black;

                //Adres
                if (txtAdres.Text == "")
                    label4.ForeColor = Color.Red;
                else
                    label4.ForeColor = Color.Black;

                //Telefon
                if (txtTlefon.Text == "")
                    label3.ForeColor = Color.Red;
                else
                    label3.ForeColor = Color.Black;

                //Maaş
                if (txtMaas.Text == "" || txtMaas.Text.Length < 3 || txtMaas.Text.Length > 5)
                    label8.ForeColor = Color.Red;
                else
                    label8.ForeColor = Color.Black;

                if (personelIDtxt.Text != "" && txtAdi.Text != "" && txtSoyadi.Text.Length > 1 && txtSoyadi.Text != "" && txtSoyadi.Text.Length > 1 && comboDepartman.Text != "" &&
                    txtEmail.Text != "" && txtAdres.Text != "" && txtTlefon.Text != "" && txtMaas.Text != "")
                {
                    try
                    {
                        p.PERSONELID = int.Parse(personelIDtxt.Text);
                        p.Adi = txtAdi.Text;
                        p.Soyadi = txtSoyadi.Text;
                        p.Telefon = txtTlefon.Text;
                        p.Adres = txtAdres.Text;
                        p.Email = txtEmail.Text;
                        p.DepartmanID = (int)comboDepartman.SelectedValue;
                        p.Maas = decimal.Parse(txtMaas.Text);
                        p.GirisTarihi = dateTimePickerGiris.Value;
                        p.DogumTarihi = dateTimePickerDogum.Value;
                        p.Aciklama = txtAciklama.Text;
                        string sorgu = "update Personeller set Adi = '" + p.Adi + "', Soyadi = '" + p.Soyadi + "', Telefon = '" + p.Telefon + "', Adres = '" + p.Adres + "', " +
                            "Email = '" + p.Email + "', departmanID = '" + p.DepartmanID + "', Maas = @Maas, GirisTarihi = @GirisTarihi, DogumTarihi = @DogumTarihi, " +
                            "Aciklama = '" + p.Aciklama + "'  " +
                            " where PersonelID = '" + p.PERSONELID + "'";
                        SqlCommand komut = new SqlCommand();
                        komut.Parameters.Add("@Maas", SqlDbType.Decimal).Value = p.Maas;
                        komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;
                        komut.Parameters.Add("@DogumTarihi", SqlDbType.Date).Value = p.DogumTarihi;
                        Veritabani.ESG(komut, sorgu);
                        p.Islem = p.PERSONELID + "nolu personelin bilgileri güncellendi";
                        p.Aciklama = "Personel güncelleme";
                        Personeller.PersonelIslemEkle(p, k);
                        temizle();
                        MessageBox.Show("Personel Güncelleme İşlemi Başarılı!", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        YenileListele();
                    }
                    catch (Exception hatamsg)
                    {
                        MessageBox.Show(hatamsg.Message, "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Veritabani.baglanti.Close();
                    }
                }
                else
                    MessageBox.Show("Yazı rengi kırmızı alanları tekrar gözden geçirin!", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            Personeller p = new Personeller();
            p.PERSONELID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            /*
            string sorgu = "delete from personeller where PersonelID = '" + p.PERSONELID + "'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sorgu);
            */
            p.CikisTarihi = DateTime.Now;
            
            string sorgu2 = "update Personeller set Durumu = 'Pasif', CikisTarihi = @CikisTarihi where personelID = '" + p.PERSONELID + "'";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@CikisTarihi", SqlDbType.Date).Value = p.CikisTarihi;
            Veritabani.ESG(komut2, sorgu2);
            
            p.Islem = p.PERSONELID + " nolu personel işten çıkarıldı.";
            p.Aciklama = "İşten çıkarma";
            Personeller.PersonelIslemEkle(p, k);
            
            temizle();
            MessageBox.Show("Personel Silme İşlemi Başarılı!", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YenileListele();
        }

        private void txtPersonelIDAra_TextChanged(object sender, EventArgs e)
        {

            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefon, p.Adres, p.Email, d.Departman, p.Durumu, " +
                "p.Maas, p.GirisTarihi, p.Aciklama, p.Mezuniyet, p.DogumTarihi from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID " +
                "and PersonelID like '%" + txtPersonelIDAra.Text + "%'");
        }

        private void txtTCAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefon, p.Adres, p.Email, d.Departman, p.Durumu, " +
                "p.Maas, p.GirisTarihi, p.Aciklama, p.Mezuniyet, p.DogumTarihi from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID " +
                "and tc_no like '%" + txtTCAra.Text + "%'");
        }

        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefon, p.Adres, p.Email, d.Departman, p.Durumu, " +
                "p.Maas, p.GirisTarihi, p.Aciklama, p.Mezuniyet, p.DogumTarihi from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID " +
                "and Adi like '%" + txtAdAra.Text + "%'");
        }

        private void txtSoyadAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID, p.Adi, p.Soyadi, p.Telefon, p.Adres, p.Email, d.Departman, p.Durumu, " +
                "p.Maas, p.GirisTarihi, p.Aciklama, p.Mezuniyet, p.DogumTarihi from Personeller p, Departmanlar d where p.DepartmanID = d.DepartmanID " +
                "and Soyadi like '%" + txtSoyadAra.Text + "%'");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Personeller.TariheGoreAra(dateTimePickerTarihAra, dataGridView1);
        }

        private void personelIDtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
