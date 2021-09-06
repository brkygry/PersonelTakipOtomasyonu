using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{

    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        void FormGetir(Form frm, Panel pnl)
        {
            pnl.Controls.Clear();
            frm.TopLevel = false;
            pnl.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();
            frm.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            frm.ShowDialog();
        }

        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            frmDepartmanlar frm = new frmDepartmanlar();
            frm.ShowDialog();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmPersonelListele frm = new frmPersonelListele();
            FormGetir(frm, panelFormlar);
        }

        private void btnMaasZamlari_Click(object sender, EventArgs e)
        {
            frmYapilanZamlar frm = new frmYapilanZamlar();
            frm.ShowDialog();
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            frmPrimler frm = new frmPrimler(); 
            FormGetir(frm, panelFormlar);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Veritabani.baglanti.Close();
            this.Close();
            frmGirisEkrani frm = new frmGirisEkrani();
            frm.ShowDialog();
        }

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            frmMesaiEkle frm = new frmMesaiEkle();
            frm.ShowDialog();
        }

        private void btnMesailer_Click(object sender, EventArgs e)
        {
            frmMesailer frm = new frmMesailer();
            FormGetir(frm, panelFormlar);
        }

        private void btnIzınHareketListele_Click(object sender, EventArgs e)
        {
            frmIzinHareketleri frm = new frmIzinHareketleri();
            FormGetir(frm, panelFormlar);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelIslemler.Width == 178)
                panelIslemler.Width = 60;
            else if (panelIslemler.Width == 60)
                panelIslemler.Width = 178;
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            panelIslemler.Width = 60;
        }
    }
}
