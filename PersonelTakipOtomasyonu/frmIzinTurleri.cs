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
    public partial class frmIzinTurleri : Form
    {
        public frmIzinTurleri()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIzinTurleri_Load(object sender, EventArgs e)
        {
            izin.ListViewKayitGetir(listView1);
        }

        private void temizle()
        {
            txtizinTurID.Text = "";
            txtizinTuru.Text = "";

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                izin i = new izin();
                i.IzinTuru = txtizinTuru.Text;
                string sql = "insert into izinTurleri values('" + i.IzinTuru +"')";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                MessageBox.Show("Kayıt eklendi", "Personel Kayıt Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                izin.ListViewKayitGetir(listView1);
                temizle();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Hata Türü");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                izin i = new izin();
                i.IzinTurID = int.Parse(txtizinTurID.Text);
                i.IzinTuru = txtizinTuru.Text;
                string sql = "update izinTurleri set izinTuru = '" + i.IzinTuru +"' where izinTurID = '" + i.IzinTurID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                MessageBox.Show("Kayıt güncellendi", "Personel Kayıt Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                izin.ListViewKayitGetir(listView1);
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Türü");
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtizinTurID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtizinTuru.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                izin i = new izin();
                i.IzinTurID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string sql = "delete from izinTurleri where izinTurID = '" + i.IzinTurID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                MessageBox.Show("Kayıt başarıyla silindi", "Personel Kayıt Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                izin.ListViewKayitGetir(listView1);
                temizle();
            }

            else
                MessageBox.Show("Hiçbir kayıt seçilmedi!", "Personel Kayıt Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtizinTurID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
