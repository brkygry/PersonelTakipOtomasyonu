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
    public partial class frmPrimler : Form
    {
        public frmPrimler()
        {
            InitializeComponent();
        }

        private void frmPrimler_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil; i >= (yil - 10); i--)
            {
                comboYil.Items.Add(i);
            }

            Veritabani.Listele_Ara(dataGridView1, "select PersonelID, Adi, Soyadi, Maas, GirisTarihi from personeller where Durumu = 'Aktif' ");

            radioKisiyeOzel.Checked = true;
        }

        private void btnPrimEkle_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.KullaniciID = frmGirisEkrani.kullanici_ID;
            p.Donem = comboAy.Text + "/" + comboYil.Text;
            p.PrimTutari = decimal.Parse(txtPrimTutari.Text);
            p.Aciklama = txtAciklama.Text;
            p.Tarih = DateTime.Now;


            if (radioKisiyeOzel.Checked)
            {
                p.PersonelID = int.Parse(txtPersonelID.Text);
                string sql = "insert into Primler(KullaniciID, PersonelID, Donem, PrimTutari, Aciklama, Tarih)  " +
                    "values('" + p.KullaniciID + "', '" + p.PersonelID + "', '" + p.Donem + "', @PrimTutari, '" + p.Aciklama + "', @Tarih)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                Veritabani.ESG(komut, sql);
                MessageBox.Show(" '" + txtAdSoyad.Text + "' personeline prim verildi.", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (radioTumPersoneller.Checked)

            {
                for (int i = 0; i < dataGridView1.Rows.Count -1; i++)
                {
                    string sql = "insert into Primler(KullaniciID, PersonelID, Donem, PrimTutari, Aciklama, Tarih)  " +
                    "values('" + p.KullaniciID + "', '" + dataGridView1.Rows[i].Cells["PersonelID"].Value + "', '" + p.Donem + "', @PrimTutari, '" + p.Aciklama + "', @Tarih)";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.Add("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
                    komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    Veritabani.ESG(komut, sql);
                }
                MessageBox.Show("Tüm personellere prim verildi.", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnTemizle.PerformClick();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + 
                dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void radioTumPersoneller_CheckedChanged(object sender, EventArgs e)
        {
            txtPersonelID.Enabled = false;
            txtAdSoyad.Enabled = false;
        }

        private void radioKisiyeOzel_CheckedChanged(object sender, EventArgs e)
        {
            txtPersonelID.Enabled = true;
            txtAdSoyad.Enabled = true;
        }

        private void btnPrimGoster_Click(object sender, EventArgs e)
        {
            frmPrimleriGoster frm = new frmPrimleriGoster();
            frm.ShowDialog();
        }

        private void btnPersonelPrimleri_Click(object sender, EventArgs e)
        {
            frmPersoneleGorePrimler frm = new frmPersoneleGorePrimler();
            frm.txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtPersonelAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Veritabani.Listele_Ara(frm.dataGridViewPersonel, "select * from Primler where PersonelID = '" + frm.txtPersonelID.Text + "'");
            frm.ShowDialog();
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
