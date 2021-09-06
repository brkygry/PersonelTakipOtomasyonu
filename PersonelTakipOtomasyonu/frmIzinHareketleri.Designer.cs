
namespace PersonelTakipOtomasyonu
{
    partial class frmIzinHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzinHareketleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIzinTurleri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtizinHareketID = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.comboizinTurleri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnizinHareketRaporu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnIzinTurleri
            // 
            this.btnIzinTurleri.FlatAppearance.BorderSize = 0;
            this.btnIzinTurleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzinTurleri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIzinTurleri.ImageIndex = 3;
            this.btnIzinTurleri.ImageList = this.ımageList1;
            this.btnIzinTurleri.Location = new System.Drawing.Point(195, 440);
            this.btnIzinTurleri.Name = "btnIzinTurleri";
            this.btnIzinTurleri.Size = new System.Drawing.Size(125, 66);
            this.btnIzinTurleri.TabIndex = 1;
            this.btnIzinTurleri.Text = "İzin Türleri";
            this.btnIzinTurleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIzinTurleri.UseVisualStyleBackColor = true;
            this.btnIzinTurleri.Click += new System.EventHandler(this.btnIzinTurleri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "excel.png");
            this.ımageList1.Images.SetKeyName(1, "46845_documents_draft_eraser_icon.png");
            this.ımageList1.Images.SetKeyName(2, "206460_add_plus_icon.png");
            this.ımageList1.Images.SetKeyName(3, "1055031_magnifying_search_view_icon.png");
            this.ımageList1.Images.SetKeyName(4, "3688460_pencil_text_update_write_draw_icon.png");
            this.ımageList1.Images.SetKeyName(5, "49615_reports_report_documents_icon.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.ImageIndex = 4;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(588, 440);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(125, 66);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageIndex = 1;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(717, 440);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(125, 66);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.ImageIndex = 2;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(457, 440);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(125, 66);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İzin Hareket ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Personel ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad Soyad:";
            // 
            // txtizinHareketID
            // 
            this.txtizinHareketID.Location = new System.Drawing.Point(99, 352);
            this.txtizinHareketID.Name = "txtizinHareketID";
            this.txtizinHareketID.Size = new System.Drawing.Size(184, 20);
            this.txtizinHareketID.TabIndex = 7;
            this.txtizinHareketID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtizinHareketID_KeyPress);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(99, 382);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(184, 20);
            this.txtPersonelID.TabIndex = 8;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(99, 414);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(184, 20);
            this.txtAdSoyad.TabIndex = 9;
            // 
            // comboizinTurleri
            // 
            this.comboizinTurleri.FormattingEnabled = true;
            this.comboizinTurleri.Location = new System.Drawing.Point(374, 352);
            this.comboizinTurleri.Name = "comboizinTurleri";
            this.comboizinTurleri.Size = new System.Drawing.Size(184, 21);
            this.comboizinTurleri.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "İzin Türleri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "İzin Başlangıç:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "İzin Bitiş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Açıklama:";
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(374, 382);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerBaslangic.TabIndex = 15;
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBitis.Location = new System.Drawing.Point(374, 414);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerBitis.TabIndex = 16;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(632, 356);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(210, 78);
            this.txtAciklama.TabIndex = 17;
            // 
            // btnExcel
            // 
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.ImageIndex = 0;
            this.btnExcel.ImageList = this.ımageList1;
            this.btnExcel.Location = new System.Drawing.Point(15, 440);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(125, 66);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "Excel\'e Aktar";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnizinHareketRaporu
            // 
            this.btnizinHareketRaporu.FlatAppearance.BorderSize = 0;
            this.btnizinHareketRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnizinHareketRaporu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnizinHareketRaporu.ImageIndex = 5;
            this.btnizinHareketRaporu.ImageList = this.ımageList1;
            this.btnizinHareketRaporu.Location = new System.Drawing.Point(326, 440);
            this.btnizinHareketRaporu.Name = "btnizinHareketRaporu";
            this.btnizinHareketRaporu.Size = new System.Drawing.Size(125, 66);
            this.btnizinHareketRaporu.TabIndex = 1;
            this.btnizinHareketRaporu.Text = "İzin Hareket Raporu";
            this.btnizinHareketRaporu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnizinHareketRaporu.UseVisualStyleBackColor = true;
            this.btnizinHareketRaporu.Click += new System.EventHandler(this.btnizinHareketRaporu_Click);
            // 
            // frmIzinHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 511);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dateTimePickerBitis);
            this.Controls.Add(this.dateTimePickerBaslangic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboizinTurleri);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtizinHareketID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnizinHareketRaporu);
            this.Controls.Add(this.btnIzinTurleri);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmIzinHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Hareketleri";
            this.Load += new System.EventHandler(this.frmIzinHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIzinTurleri;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtizinHareketID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox comboizinTurleri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitis;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnizinHareketRaporu;
    }
}