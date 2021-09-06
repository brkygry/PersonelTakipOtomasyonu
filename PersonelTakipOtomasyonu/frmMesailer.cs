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
    public partial class frmMesailer : Form
    {
        public frmMesailer()
        {
            InitializeComponent();
        }

        private void frmMesailer_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil; i >= (yil - 10); i--)
            {
                comboYil.Items.Add(i);
            }

            Veritabani.Listele_Ara(dataGridView1, "select * from Mesailer");
        }

        void MesaiHareketleriEkle(Kullanicilar k, Mesailer m, Personeller p)
        {
            k.KullaniciID = frmGirisEkrani.kullanici_ID;
            string sql = "insert into MesaiHareketleri values('" + k.KullaniciID + "', '" + p.PERSONELID + "', '" + m.MesaiID + "', '" + m.Islem + "', '" + m.Aciklama + "', " +
                "@Tarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = DateTime.Now;
            Veritabani.ESG(komut, sql);
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtAdSoyad);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
            {
                txtMesaiID.Text = dataGridView1.CurrentRow.Cells["MesaiID"].Value.ToString();
                txtPersonelID.Text = dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString();
                txtMesaiSaatUcreti.Text = dataGridView1.CurrentRow.Cells["MesaiSaatUcreti"].Value.ToString();
                txtTutar.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();

                string baslangic = dataGridView1.CurrentRow.Cells["BaslangicSaati"].Value.ToString();
                string bitis = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
                string donem = dataGridView1.CurrentRow.Cells["Donem"].Value.ToString();

                dateTimePickerBaslangic.Text = baslangic.Substring(0, 10);
                maskedtxtBaslangic.Text = baslangic.Substring(11);
                dateTimePickerBitis.Text = bitis.Substring(0, 10);
                maskedtxtBitis.Text = bitis.Substring(11);

                int say = donem.IndexOf("/");
                comboAy.Text = donem.Substring(0, say);
                comboYil.Text = donem.Substring(say + 1);
            }
        }

        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePickerBaslangic.Text != "" && dateTimePickerBitis.Text != "")
                {
                    string baslangic = dateTimePickerBaslangic.Text + " " + maskedtxtBaslangic.Text;
                    string bitis = dateTimePickerBitis.Text + " " + maskedtxtBitis.Text;
                    TimeSpan saatfarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                    double MesaiSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                    double tutar = saatfarki.TotalHours * MesaiSaatUcreti;
                    txtTutar.Text = tutar.ToString("0.00");
                }
                else
                    txtTutar.Text = "0";
                
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

        private void btnPersonelMesaileri_Click(object sender, EventArgs e)
        {
            frmPersonelMesaileri frm = new frmPersonelMesaileri();
            frm.ShowDialog();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dateTimePickerBaslangic.Value = DateTime.Now;
            dateTimePickerBitis.Value = DateTime.Now;
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is ComboBox)
                    item.Text = "";
                if (item is MaskedTextBox)
                    item.Text = "";
            }
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnTumMesaileriOde_Click(object sender, EventArgs e)
        {
            Mesailer m = new Mesailer();
            Kullanicilar k = new Kullanicilar();
            Personeller p = new Personeller();
            m.OdenmeDurumu = "Ödendi";
            string sql = "update Mesailer set OdenmeDurumu= '" + m.OdenmeDurumu + "' where OdenmeDurumu = 'Ödenmedi' ";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            MessageBox.Show("Ödenmeyen tüm mesailer ödendi", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Mesai Hareketlerine ekleme
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
                {
                    m.MesaiID = int.Parse(dataGridView1.Rows[i].Cells["MesaiID"].Value.ToString());
                    p.PERSONELID = int.Parse(dataGridView1.Rows[i].Cells["PersonelID"].Value.ToString());
                    m.Islem = m.MesaiID + " nolu mesai ücreti ödendi";
                    m.Aciklama = "Tüm mesailer ödendi";
                    MesaiHareketleriEkle(k, m, p);
                }
            }
            btnTemizle.PerformClick();
            Veritabani.Listele_Ara(dataGridView1, "Select * from Mesailer");
        }

        private void btnMesaiOde_Click(object sender, EventArgs e)
        {
            if (txtMesaiID.Text != "")
            {
                Mesailer m = new Mesailer();
                Kullanicilar k = new Kullanicilar();
                Personeller p = new Personeller();
                m.OdenmeDurumu = "Ödendi";
                m.MesaiID = int.Parse(txtMesaiID.Text);
                string sql = "update Mesailer set OdenmeDurumu= '" + m.OdenmeDurumu + "' where MesaiID = '" + m.MesaiID + "' ";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                MessageBox.Show(m.MesaiID + " numaralı mesai ücreti ödendi", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Mesai Hareketlerine ekleme
                p.PERSONELID = int.Parse(txtPersonelID.Text);
                m.Islem = m.MesaiID + " nolu mesai için ödeme yapıldı";
                m.Aciklama = "Mesai ödeme";
                MesaiHareketleriEkle(k, m, p);
                btnTemizle.PerformClick();
                Veritabani.Listele_Ara(dataGridView1, "Select * from Mesailer");
            }
            else
                MessageBox.Show("Önce mesai seçilmeli", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (txtMesaiID.Text != "")
            {
                Mesailer m = new Mesailer();
                Kullanicilar k = new Kullanicilar();
                Personeller p = new Personeller();
                
                if (MessageBox.Show("Bu mesai kaydı silinsin mi?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    m.MesaiID = int.Parse(txtMesaiID.Text);
                    //Mesai Hareketlerine ekleme
                    
                    p.PERSONELID = int.Parse(txtPersonelID.Text);
                    m.Islem = m.MesaiID + " nolu mesai kaydı silindi";
                    m.Aciklama = "Mesai kaydı silme";
                    MesaiHareketleriEkle(k, m, p);
                    

                    string sql = "update Mesailer set OdenmeDurumu = 'Silindi' where MesaiID = '" + m.MesaiID + "' ";
                    SqlCommand komut = new SqlCommand();
                    Veritabani.ESG(komut, sql);
                    MessageBox.Show(m.MesaiID + " numaralı mesai kaydı silindi", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    btnTemizle.PerformClick();
                    Veritabani.Listele_Ara(dataGridView1, "Select * from Mesailer");
                }
                
            }
            else
                MessageBox.Show("Önce mesai seçilmeli", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtMesaiID.Text != "")
            {
                //Başlangıç Saati
                if (maskedtxtBaslangic.MaskCompleted == false)
                    label2.ForeColor = Color.Red;
                else
                    label2.ForeColor = Color.Black;

                //Bitiş Saati
                if (maskedtxtBitis.MaskCompleted == false)
                    label3.ForeColor = Color.Red;
                else
                    label3.ForeColor = Color.Black;

                //Mesai Saat Ücreti
                if (txtMesaiSaatUcreti.Text == "")
                    label4.ForeColor = Color.Red;
                else
                    label4.ForeColor = Color.Black;

                //Donem
                if (comboAy.Text == "" || comboYil.Text == "")
                    label6.ForeColor = Color.Red;
                else
                    label6.ForeColor = Color.Black;

                //Mesai Saat Ücreti
                if (txtAciklama.Text == "")
                    label7.ForeColor = Color.Red;
                else
                    label7.ForeColor = Color.Black;

                if (maskedtxtBaslangic.MaskCompleted == true && maskedtxtBitis.MaskCompleted == true && txtMesaiSaatUcreti.Text != "" && comboAy.Text != "" && comboYil.Text != "" && txtAciklama.Text != "")
                {
                    Mesailer m = new Mesailer();
                    Kullanicilar k = new Kullanicilar();
                    Personeller p = new Personeller();
                    p.PERSONELID = int.Parse(txtPersonelID.Text);
                    m.MesaiID = int.Parse(txtMesaiID.Text);
                    m.Baslangic_Saati = dateTimePickerBaslangic.Text + " " + maskedtxtBaslangic.Text;
                    m.Bitis_Saati = dateTimePickerBitis.Text + " " + maskedtxtBitis.Text;
                    m.MesaiSaatUcreti = decimal.Parse(txtMesaiSaatUcreti.Text);
                    m.Tutar = decimal.Parse(txtTutar.Text);
                    m.Donem = comboAy.Text + "/" + comboYil.Text;
                    m.Aciklama = txtAciklama.Text;
                    string sql = "update Mesailer set PersonelID = '" + p.PERSONELID + "', BaslangicSaati = '" + m.Baslangic_Saati + "', BitisSaati = '" + m.Bitis_Saati + "', MesaiSaatUcreti = @MesaiSaatUcreti, " +
                        "Tutar = @Tutar, Donem = '" + m.Donem + "', Aciklama = '" + m.Aciklama + "' where MesaiID = '" + m.MesaiID + "'";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.Add("@MesaiSaatUcreti", SqlDbType.Decimal).Value = m.MesaiSaatUcreti;
                    komut.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = m.Tutar;
                    Veritabani.ESG(komut, sql);
                    MessageBox.Show(m.MesaiID + " numaralı mesai kaydı başarıyla güncellendi", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Mesai Hareketlerine ekleme
                    m.Islem = m.MesaiID + " nolu mesai güncellendi";
                    m.Aciklama = "Mesai güncellemesi";
                    MesaiHareketleriEkle(k, m, p);
                    btnTemizle.PerformClick();
                    Veritabani.Listele_Ara(dataGridView1, "Select * from Mesailer");
                }
                else
                    MessageBox.Show("Yazı rengi kırmızı alanları tekrar gözden geçirin!", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Önce mesai seçilmeli", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnMesaiHareketRaporu_Click(object sender, EventArgs e)
        {
            frmMesaiHareketRaporu frm = new frmMesaiHareketRaporu();
            frm.ShowDialog();
        }

        private void txtMesaiID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPersonelID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMesaiSaatUcreti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
