
namespace PersonelTakipOtomasyonu
{
    partial class frmizinHareketRaporu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Personel_TakipDataSet = new PersonelTakipOtomasyonu.Personel_TakipDataSet();
            this.izinRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izinRaporTableAdapter = new PersonelTakipOtomasyonu.Personel_TakipDataSetTableAdapters.izinRaporTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Personel_TakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinRaporBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "izinRaporDataSet";
            reportDataSource1.Value = this.izinRaporBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonelTakipOtomasyonu.izinHareketReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(854, 511);
            this.reportViewer1.TabIndex = 0;
            // 
            // Personel_TakipDataSet
            // 
            this.Personel_TakipDataSet.DataSetName = "Personel_TakipDataSet";
            this.Personel_TakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izinRaporBindingSource
            // 
            this.izinRaporBindingSource.DataMember = "izinRapor";
            this.izinRaporBindingSource.DataSource = this.Personel_TakipDataSet;
            // 
            // izinRaporTableAdapter
            // 
            this.izinRaporTableAdapter.ClearBeforeFill = true;
            // 
            // frmizinHareketRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmizinHareketRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Hareket Raporu";
            this.Load += new System.EventHandler(this.frmizinHareketRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Personel_TakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinRaporBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource izinRaporBindingSource;
        private Personel_TakipDataSet Personel_TakipDataSet;
        private Personel_TakipDataSetTableAdapters.izinRaporTableAdapter izinRaporTableAdapter;
    }
}