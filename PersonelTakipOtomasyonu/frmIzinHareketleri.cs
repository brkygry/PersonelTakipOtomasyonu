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
    public partial class frmIzinHareketleri : Form
    {
        public frmIzinHareketleri()
        {
            InitializeComponent();
        }

        izin Izin = new izin();

        private void temizle()
        {
            foreach (Control item in Controls)
            {
                dateTimePickerBaslangic.Value = DateTime.Now;
                dateTimePickerBitis.Value = DateTime.Now;
                izin.ComboyaKayitGetir(comboizinTurleri);
                if(item is TextBox)
                    item.Text = "";
            }
        }

        private void btnIzinTurleri_Click(object sender, EventArgs e)
        {
            frmIzinTurleri frm = new frmIzinTurleri();
            frm.ShowDialog();
        }

        private void frmIzinHareketleri_Load(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select izinHareketID, PersonelID, KullaniciID, tur.izinTuru, izinBaslangic, izinBitis, Islem, Aciklama, Tarih, Saat " +
                "from izinHareketleri i, izinTurleri tur where i.izinTurID = tur.izinTurID");
            izin.ComboyaKayitGetir(comboizinTurleri);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.PERSONELID = int.Parse(txtPersonelID.Text);
            i.KullaniciID = frmGirisEkrani.kullanici_ID;
            i.IzinTurID = (int)comboizinTurleri.SelectedValue;
            i.IzinBaslangic = dateTimePickerBaslangic.Value;
            i.IzinBitis = dateTimePickerBitis.Value;
            i.Islem = i.PERSONELID + "-" + txtAdSoyad.Text + " için" + comboizinTurleri.Text + " oluşturuldu.";
            i.Aciklama = txtAciklama.Text;
            i.Tarih = DateTime.Now;
            i.Saat = DateTime.Now;
            i.Saat.ToString("HH:mm");
            string sql = "insert into izinHareketleri values('" + i.PERSONELID + "', '" + i.KullaniciID + "', '" + i.IzinTurID + "', @izinBaslangic, @izinBitis, " +
                "'" + i.Islem + "', '" + i.Aciklama + "', @Tarih, @Saat)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@izinBaslangic", SqlDbType.Date).Value = i.IzinBaslangic;
            komut.Parameters.Add("@izinBitis", SqlDbType.Date).Value = i.IzinBitis;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = i.Tarih;
            komut.Parameters.Add("@Saat", SqlDbType.DateTime).Value = i.Saat;
            try
            {
                Veritabani.ESG(komut, sql);
                temizle();
                MessageBox.Show("Kayıt oluşturuldu.", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Veritabani.Listele_Ara(dataGridView1, "select izinHareketID, PersonelID, KullaniciID, tur.izinTuru, izinBaslangic, izinBitis, Islem, Aciklama, Tarih, Saat " +
                "from izinHareketleri i, izinTurleri tur where i.izinTurID = tur.izinTurID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.IzinHareketID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sql = "delete from izinHareketleri where izinHareketID = '" + i.IzinHareketID +"'";
            SqlCommand komut = new SqlCommand();
            try
            {
                Veritabani.ESG(komut, sql);
                temizle();
                MessageBox.Show("İzin bilgileri silindi", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Veritabani.Listele_Ara(dataGridView1, "select izinHareketID, PersonelID, KullaniciID, tur.izinTuru, izinBaslangic, izinBitis, Islem, Aciklama, Tarih, Saat " +
                "from izinHareketleri i, izinTurleri tur where i.izinTurID = tur.izinTurID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            izin i = new izin();
            i.IzinHareketID = int.Parse(txtizinHareketID.Text);
            i.PERSONELID = int.Parse(txtPersonelID.Text);
            i.KullaniciID = frmGirisEkrani.kullanici_ID;
            i.IzinTurID = (int)comboizinTurleri.SelectedValue;
            i.IzinBaslangic = dateTimePickerBaslangic.Value;
            i.IzinBitis = dateTimePickerBitis.Value;
            i.Aciklama = txtAciklama.Text;
            i.Tarih = DateTime.Now;
            i.Saat = DateTime.Now;
            i.Islem = i.IzinHareketID + " nolu izin kaydı güncellendi.";
            string sql = "update izinHareketleri set PersonelID = '" + i.PERSONELID + "', izinTurID = '" + i.IzinTurID + "', izinBaslangic = @izinBaslangic, " +
                "izinBitis = @izinBitis, Islem = '" + i.Islem + "', Aciklama = '" + i.Aciklama + "', Tarih = @Tarih, Saat = @Saat where izinHareketID = '" + i.IzinHareketID +"'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@izinBaslangic", SqlDbType.Date).Value = i.IzinBaslangic;
            komut.Parameters.Add("@izinBitis", SqlDbType.Date).Value = i.IzinBitis;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = i.Tarih;
            komut.Parameters.Add("@Saat", SqlDbType.DateTime).Value = i.Saat;
            try
            {
                Veritabani.ESG(komut, sql);
                temizle();
                MessageBox.Show("İzin bilgileri güncellendi", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Veritabani.Listele_Ara(dataGridView1, "select izinHareketID, PersonelID, KullaniciID, tur.izinTuru, izinBaslangic, izinBitis, Islem, Aciklama, Tarih, Saat " +
                "from izinHareketleri i, izinTurleri tur where i.izinTurID = tur.izinTurID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtAdSoyad);

            if (txtPersonelID.Text == "")
                txtAdSoyad.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtizinHareketID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboizinTurleri.Text = dataGridView1.CurrentRow.Cells["izinTuru"].Value.ToString();
            dateTimePickerBaslangic.Text = dataGridView1.CurrentRow.Cells["izinBaslangic"].Value.ToString();
            dateTimePickerBitis.Text = dataGridView1.CurrentRow.Cells["izinBitis"].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();


        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
            uygulama.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                range.Value2 = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j+2,i+1];
                    range.Value2 = dataGridView1[i, j].Value;
                    sayfa.Columns["B:B"].NumberFormat = "0,00";
                    sayfa.Columns["E:E"].NumberFormat = "gg.aa.yyyy";
                    sayfa.Columns["F:F"].NumberFormat = "gg.aa.yyyy";
                    sayfa.Columns["I:I"].NumberFormat = "gg.aa.yyyy";
                    sayfa.Columns["J:J"].NumberFormat = "gg.aa.yyyy ss:dd:nn";
                }
            }
        }

        private void btnizinHareketRaporu_Click(object sender, EventArgs e)
        {   
            frmizinHareketRaporu frm = new frmizinHareketRaporu();
            frm.ShowDialog();
        }

        private void txtizinHareketID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
