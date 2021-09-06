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
    public partial class frmizinHareketRaporu : Form
    {
        public frmizinHareketRaporu()
        {
            InitializeComponent();
        }

        private void frmizinHareketRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'Personel_TakipDataSet.izinRapor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.izinRaporTableAdapter.izinRaporFill(this.Personel_TakipDataSet.izinRapor);

            this.reportViewer1.RefreshReport();
        }
    }
}
