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
    public partial class frmMesaiHareketRaporu : Form
    {
        public frmMesaiHareketRaporu()
        {
            InitializeComponent();
        }

        private void frmMesaiHareketRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'Personel_TakipDataSet.mesaiRapor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mesaiRaporTableAdapter.mesaiRaporFill(this.Personel_TakipDataSet.mesaiRapor);

            this.reportViewer1.RefreshReport();
        }
    }
}
