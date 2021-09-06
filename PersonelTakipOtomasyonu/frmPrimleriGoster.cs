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
    public partial class frmPrimleriGoster : Form
    {
        public frmPrimleriGoster()
        {
            InitializeComponent();
        }

        private void frmPrimleriGoster_Load(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select * from Primler");

            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil; i >= (yil - 10); i--)
            {
                comboYil.Items.Add(i);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
            {
                txtPrimID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPersonelID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPrimTutari.Text = dataGridView1.CurrentRow.Cells["PrimTutari"].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
                string donem = dataGridView1.CurrentRow.Cells["Donem"].Value.ToString();
                int say = donem.IndexOf("/");
                comboAy.Text = donem.Substring(0, say);
                comboYil.Text = donem.Substring(say + 1);
            }
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtAdSoyad);
        }

        private void btnDonemDegistir_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = frmGirisEkrani.kullanici_ID;
            Primler p = new Primler();
            p.Donem = comboAy.Text + "/" + comboYil.Text;
            p.PrimID = int.Parse(txtPrimID.Text);
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.Aciklama = txtAciklama.Text;
            p.Islem = "Dönem bilgisi değiştirildi";
            p.Tarih = DateTime.Now;
            string sql = "update Primler set donem = '" + p.Donem + "' where PrimID = '" + p.PrimID + "' ";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            string sql2 = "insert into PrimHareketleri values ('" + k.KullaniciID + "', '" + p.PersonelID + "', '" + p.PrimID + "', '" + p.Islem + "', '" + p.Aciklama + "', @Tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            Veritabani.ESG(komut2, sql2);
            Veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            MessageBox.Show("Dönem değişikliği başarıyla uygulandı", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnTumPrimleriOde_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.OdenmeDurumu = "Ödendi";
            string sql = "update Primler set OdenmeDurumu = '" + p.OdenmeDurumu + "' where OdenmeDurumu = 'Ödenmedi' ";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                if(dataGridView1.Rows[i].Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
                {
                    Kullanicilar k = new Kullanicilar();
                    k.KullaniciID = frmGirisEkrani.kullanici_ID;
                    p.PrimID = int.Parse(dataGridView1.Rows[i].Cells["PrimID"].Value.ToString());
                    p.PersonelID = int.Parse(dataGridView1.Rows[i].Cells["PrimID"].Value.ToString());
                    p.Islem = "Tüm personellerin ödenmeyen primleri ödendi.";
                    p.Aciklama = "Tüm personellerin ödenmeyen primleri ödendi.";
                    /////////////////////////////
                    string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "', '" + p.PersonelID + "', '" + p.PrimID + "', '" + p.Islem + "', '" + p.Aciklama + "', @Tarih)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    Veritabani.ESG(komut2, sql2);
                    //////////////////////////////
                }
            }
            Veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            MessageBox.Show("Tüm primler başarıyla ödendi", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnPrimOde_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = frmGirisEkrani.kullanici_ID;
            Primler p = new Primler();
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.PrimTutari = decimal.Parse(txtPrimTutari.Text);
            p.Aciklama = "Personel ID:"+p.PersonelID + " Ad Soyad:"+txtAdSoyad.Text + "Prim Tutarı:" +p.PrimTutari;
            p.Islem = p.PersonelID+" personel IDli " +txtAdSoyad.Text+" için ödeme yapıldı";
            p.OdenmeDurumu = "Ödendi";
            p.PrimID = int.Parse(txtPrimID.Text);
            p.Tarih = DateTime.Now;
            string sql = "update Primler set OdenmeDurumu = '" + p.OdenmeDurumu + "' where PrimID = '" + p.PrimID + "' ";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            /////////////////////////////
            string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "', '" + p.PersonelID + "', '" + p.PrimID + "', '" + p.Islem + "', '" + p.Aciklama + "', @Tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            Veritabani.ESG(komut2, sql2);
            //////////////////////////////
            Veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            MessageBox.Show("Seçili prim ödendi", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();  
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is ComboBox)
                    item.Text = "";
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrimGuncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = frmGirisEkrani.kullanici_ID;
            Primler p = new Primler();
            p.PrimID = int.Parse(txtPrimID.Text);
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.PrimTutari = decimal.Parse(txtPrimTutari.Text);
            p.Aciklama = txtAciklama.Text;
            p.Islem = p.PrimID + " numaralı primin bilgileri değiştirildi";
            string sql = "update Primler set PersonelID = '" + p.PersonelID + "', PrimTutari = @PrimTutari, Aciklama = '" +  p.Aciklama + "' where PrimID = '" + p.PrimID + "' ";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
            Veritabani.ESG(komut, sql);
            ////////////////////
            string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "', '" + p.PersonelID + "', '" + p.PrimID + "', '" + p.Islem + "', '" + p.Aciklama + "', @Tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            Veritabani.ESG(komut2, sql2);
            ////////////////////
            Veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            MessageBox.Show("Seçili prim güncellendi", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnPrimSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt silinsin mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Kullanicilar k = new Kullanicilar();
                k.KullaniciID = frmGirisEkrani.kullanici_ID;
                Primler p = new Primler();
                p.PersonelID = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
                p.Aciklama = "Kayıt silindi.";
                p.PrimID = int.Parse(dataGridView1.CurrentRow.Cells["PrimID"].Value.ToString());
                p.Islem = p.PrimID + " numaralı prim kaydı silindi";
                string sql = "update Primler set OdenmeDurumu = 'Silindi' where PrimID = '" + p.PrimID + "' ";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                ////////////////////
                string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "', '" + p.PersonelID + "', '" + p.PrimID + "', '" + p.Islem + "', '" + p.Aciklama + "', @Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                Veritabani.ESG(komut2, sql2);
                ////////////////////
                Veritabani.Listele_Ara(dataGridView1, "select * from Primler");
                MessageBox.Show("Prim kaydı başarıyla silindi", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnTemizle.PerformClick();
            }
        }

        private void txtPrimID_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
