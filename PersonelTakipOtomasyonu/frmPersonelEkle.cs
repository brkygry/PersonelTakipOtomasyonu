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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaKayitGetir(comboDepartman);

            //Mezuniyeti
            comboMezuniyet.Items.Add("İlköğretim"); comboMezuniyet.Items.Add("Ortaöğretim"); comboMezuniyet.Items.Add("Lise"); comboMezuniyet.Items.Add("Üniversite");
            comboMezuniyet.Items.Add("Devam Etmekte");

            //Doğum Tarihi

            DateTime zaman = DateTime.Now;

            int year = int.Parse(zaman.ToString("yyyy"));
            int month = int.Parse(zaman.ToString("MM"));
            int day = int.Parse(zaman.ToString("dd"));

            dateTimePickerDogum.MinDate = new DateTime(1960, 1, 1);
            dateTimePickerDogum.MaxDate = new DateTime(year - 18, month, day);

            txtTC.MaxLength = 11; //TC Kimlik No
            toolTip1.SetToolTip(this.txtTC, "TC Kimlik Numarası 11 Haneli Olmalıdır!");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void temizle()
        {
            dateTimePickerGiris.Value = DateTime.Now;
            comboDepartman.Text = "";
            comboMezuniyet.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }
        Personeller p = new Personeller();
        Kullanicilar k = new Kullanicilar();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool kayitkontrol = false;
            Veritabani.baglanti.Open();
            SqlCommand selectsorgu = new SqlCommand("select * from personeller where tc_no = '" + txtTC.Text + "'", Veritabani.baglanti);
            SqlDataReader kayitokuma = selectsorgu.ExecuteReader();

            while (kayitokuma.Read())
            {
                kayitkontrol = true;
                break;
            }
            Veritabani.baglanti.Close();

            if (kayitkontrol == false)
            {
                //TC Kimlik Numarası
                if (txtTC.Text == "" || txtTC.Text.Length != 11)
                    label12.ForeColor = Color.Red;
                else
                    label12.ForeColor = Color.Black;

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

                //Mezuniyet
                if (comboMezuniyet.Text == "")
                    label13.ForeColor = Color.Red;
                else
                    label13.ForeColor = Color.Black;

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
                if (txtTelefon.Text == "")
                    label3.ForeColor = Color.Red;
                else
                    label3.ForeColor = Color.Black;

                //Maaş
                if (txtMaas.Text == "" || txtMaas.Text.Length < 3 || txtMaas.Text.Length > 5)
                    label8.ForeColor = Color.Red;
                else
                    label8.ForeColor = Color.Black;

                if (txtTC.Text.Length == 11 && txtAdi.Text != "" && txtSoyadi.Text.Length > 1 && txtSoyadi.Text != "" && txtSoyadi.Text.Length > 1 && comboDepartman.Text != "" &&
                    comboMezuniyet.Text != "" && txtEmail.Text != "" && txtAdres.Text != "" && txtTelefon.Text != "" && txtMaas.Text != "")
                {
                    try
                    {
                        Personeller p = new Personeller();
                        p.Tc_no = txtTC.Text;
                        p.Adi = txtAdi.Text;
                        p.Soyadi = txtSoyadi.Text;
                        p.Telefon = txtTelefon.Text;
                        p.Adres = txtAdres.Text;
                        p.Email = txtEmail.Text;
                        p.DepartmanID = (int)comboDepartman.SelectedValue;
                        p.Maas = decimal.Parse(txtMaas.Text);
                        p.GirisTarihi = dateTimePickerGiris.Value;
                        p.DogumTarihi = dateTimePickerDogum.Value;
                        p.Aciklama = txtAciklama.Text;
                        p.Mezuniyet = comboMezuniyet.Text;
                        string sorgu = "insert into Personeller(tc_no, Adi,Soyadi,Telefon,Adres,Email,DepartmanID,Maas,GirisTarihi,Aciklama,Mezuniyet,DogumTarihi) values ('" + p.Tc_no + "', '" + p.Adi + "', '" + p.Soyadi + "' , '" + p.Telefon + "', '" + p.Adres + "' , '" + p.Email + "' , " +
                            "'" + p.DepartmanID + "' , @Maas , @GirisTarihi , '" + p.Aciklama + "' , '" + p.Mezuniyet + "' , @DogumTarihi )";
                        SqlCommand komut = new SqlCommand();
                        komut.Parameters.Add("@Maas", SqlDbType.Decimal).Value = p.Maas;
                        komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;
                        komut.Parameters.Add("@DogumTarihi", SqlDbType.Date).Value = p.DogumTarihi;

                        Veritabani.ESG(komut, sorgu);
                        Personeller.PersonelIDSonKayit(p);
                        p.Islem = "Yeni personel kaydı oluşturuldu. Personel ID:" + p.PERSONELID;
                        p.Aciklama = "Yeni personel kaydı";
                        Personeller.PersonelIslemEkle(p, k);
                        temizle();
                        MessageBox.Show("Personel Ekleme İşlemi Başarılı!", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
                MessageBox.Show("TC Kimlik Numarası Zaten Sistemde Kayıtlı!", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text.Length < 11)
                errorProvider1.SetError(txtTC, "TC Kimlik Numarası 11 Haneli Olmalı!");

            else
                errorProvider1.Clear();
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMaas.Text.Length < 3 || txtMaas.Text.Length > 5)
                errorProvider1.SetError(txtMaas, "Maaş bilgisi yanlış girildi.");

            else
                errorProvider1.Clear();
        }

        //Ad
        private void txtAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        //Soyad
        private void txtSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
