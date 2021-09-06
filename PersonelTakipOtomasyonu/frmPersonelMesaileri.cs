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
    public partial class frmPersonelMesaileri : Form
    {
        public frmPersonelMesaileri()
        {
            InitializeComponent();
        }

        private void frmPersonelMesaileri_Load(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridViewPersonel, "select PersonelID as ID , Adi as ADI, Soyadi as SOYADI from Personeller");
        }

        private void dataGridViewPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string personelID = dataGridViewPersonel.CurrentRow.Cells["ID"].Value.ToString();
            Veritabani.Listele_Ara(dataGridViewMesai, "select * from mesailer where PersonelID = '" + personelID + "'");
            txtPersonelID.Text = dataGridViewPersonel.CurrentRow.Cells["ID"].Value.ToString();
            try
            {
                lblKayitSayisi.Text = "Toplam " + (dataGridViewMesai.Rows.Count - 1) + " kayıt listelendi.";
                decimal tutar = 0;
                for (int i = 0; i < dataGridViewMesai.Rows.Count - 1; i++)
                {
                    tutar += decimal.Parse(dataGridViewMesai.Rows[i].Cells["Tutar"].Value.ToString());
                }
                lblTutarMiktari.Text = "Toplam Mesai Ücreti=" + tutar.ToString("0.00") + " TL";
            }
            catch 
            {

               
            }
            
            
        }

        private void txtMesaiIDAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridViewMesai, "select * from Mesailer where MesaiID like '" + txtMesaiIDAra.Text + "' ");
            if (txtMesaiIDAra.Text == "")
            {
                string personelID = txtPersonelID.Text;
                Veritabani.Listele_Ara(dataGridViewMesai, "select * from mesailer where PersonelID = '" + personelID + "'");
            }

        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridViewMesai, "select * from Mesailer where PersonelID like '" + txtPersonelID.Text + "' ");
            if (txtPersonelID.Text == "")
            {
                string personelID = txtPersonelID.Text;
                Veritabani.Listele_Ara(dataGridViewMesai, "select * from mesailer where PersonelID = '" + personelID + "'");
            }
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtAdSoyad);
        }
    }
}
