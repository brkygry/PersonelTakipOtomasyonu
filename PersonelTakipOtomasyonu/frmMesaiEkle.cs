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
    public partial class frmMesaiEkle : Form
    {
        public frmMesaiEkle()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            dateTimePickerBaslangic.Value = DateTime.Now;
            dateTimePickerBitis.Value = DateTime.Now;
            comboPersonelAdSoyad.Text = "";
            comboAy.Text = "";
            comboYil.Text = "";
            maskedtxtBaslangic.Text = "";
            maskedtxtBitis.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }

        private void frmMesaiEkle_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil; i >= (yil - 10); i--)
            {
                comboYil.Items.Add(i);
            }

            Mesailer.ComboyaPersonelGetir(comboPersonelAdSoyad);

        }

        Label lbl;
        private void comboPersonelAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl = new Label();
            YapilanZamlar.ComboSecilirsePersonelIDGetir(comboPersonelAdSoyad, lbl);
        }

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            Personeller p = new Personeller();
            Mesailer m = new Mesailer();
            k.KullaniciID = frmGirisEkrani.kullanici_ID;
            p.PERSONELID = int.Parse(lbl.Text);
            m.Baslangic_Saati = dateTimePickerBaslangic.Text + " " + maskedtxtBaslangic.Text;
            m.Bitis_Saati = dateTimePickerBitis.Text + " " + maskedtxtBitis.Text;
            m.MesaiSaatUcreti = decimal.Parse(txtMesaiSaatUcreti.Text);
            m.Tutar = decimal.Parse(txtTutar.Text);
            m.Donem = comboAy.Text + "/" + comboYil.Text;
            m.Aciklama = txtAciklama.Text;
            m.Tarih = DateTime.Now;
            string sql = "insert into Mesailer(KullaniciID, PersonelID, BaslangicSaati, BitisSaati, MesaiSaatUcreti, Tutar, Donem, Aciklama, Tarih) " +
                "values('" + k.KullaniciID + "', '" + p.PERSONELID + "', '" + m.Baslangic_Saati + "', '" + m.Bitis_Saati + "', @MesaiSaatUcreti, @Tutar , " +
                "'" + m.Donem + "', '" + m.Aciklama + "', @Tarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@MesaiSaatUcreti", SqlDbType.Decimal).Value = m.MesaiSaatUcreti;
            komut.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = m.Tutar;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = m.Tarih;
            Veritabani.ESG(komut, sql);
            MessageBox.Show("Mesai bilgileri eklendi", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateTimePickerBaslangic.Text + " " + maskedtxtBaslangic.Text;
                string bitis = dateTimePickerBitis.Text + " " + maskedtxtBitis.Text;
                TimeSpan saatfarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double MesaiSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                double tutar = saatfarki.TotalHours * MesaiSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch
            {

                
            }
        }

        private void maskedtxtBaslangic_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateTimePickerBaslangic.Text + " " + maskedtxtBaslangic.Text;
                string bitis = dateTimePickerBitis.Text + " " + maskedtxtBitis.Text;
                TimeSpan saatfarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double MesaiSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                double tutar = saatfarki.TotalHours * MesaiSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch
            {


            }
        }

        private void maskedtxtBitis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateTimePickerBaslangic.Text + " " + maskedtxtBaslangic.Text;
                string bitis = dateTimePickerBitis.Text + " " + maskedtxtBitis.Text;
                TimeSpan saatfarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double MesaiSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                double tutar = saatfarki.TotalHours * MesaiSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch
            {


            }
        }
    }
}
