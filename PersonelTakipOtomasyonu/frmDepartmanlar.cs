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
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            Departmanlar.DepartmanGetir(listView1);   
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            //Departman
            if (txtDepartman.Text == "")
                label2.ForeColor = Color.Red;
            else
                label2.ForeColor = Color.Black;

            //Açıklama
            if (txtAciklama.Text == "")
                label3.ForeColor = Color.Red;
            else
                label3.ForeColor = Color.Black;

            if (txtDepartman.Text != "" && txtAciklama.Text != "")
            {
                Departmanlar d = new Departmanlar();
                d.Departman = txtDepartman.Text;
                d.Aciklama = txtAciklama.Text;
                string sorgu = "insert into Departmanlar values('" + d.Departman + "', '" + d.Aciklama + "')";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sorgu);
                MessageBox.Show("Kayıt başarıyla eklendi.");
                Departmanlar.DepartmanGetir(listView1);
            }
            else
                MessageBox.Show("Yazı rengi kırmızı alanları tekrar gözden geçirin!", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            //Departman
            if (txtDepartman.Text == "")
                label2.ForeColor = Color.Red;
            else
                label2.ForeColor = Color.Black;

            //Açıklama
            if (txtAciklama.Text == "")
                label3.ForeColor = Color.Red;
            else
                label3.ForeColor = Color.Black;

            if (txtDepartman.Text != "" && txtAciklama.Text != "")
            {
                Departmanlar d = new Departmanlar();
                d.DepartmanID = int.Parse(txtDepartmanID.Text);
                d.Departman = txtDepartman.Text;
                d.Aciklama = txtAciklama.Text;
                string sorgu = "update departmanlar set departman= '" + d.Departman + "', aciklama = '" + d.Aciklama + "' where departmanID = '" + d.DepartmanID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sorgu);
                MessageBox.Show("Kayıt başarıyla güncellendi.");
                Departmanlar.DepartmanGetir(listView1);
            }
            else
                MessageBox.Show("Yazı rengi kırmızı alanları tekrar gözden geçirin!", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Departmanlar d = new Departmanlar();
                d.DepartmanID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                d.Departman = txtDepartman.Text;
                d.Aciklama = txtAciklama.Text;
                string sorgu = "delete from departmanlar where departmanID = '" + d.DepartmanID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sorgu);
                MessageBox.Show("Kayıt başarıyla silindi.");
                Departmanlar.DepartmanGetir(listView1);
            }
            else
                MessageBox.Show("Silinecek kayıt seçilmelidir!", "Personel Takip Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtDepartmanID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtDepartman.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void txtDepartmanID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
