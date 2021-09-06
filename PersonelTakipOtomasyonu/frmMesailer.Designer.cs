
namespace PersonelTakipOtomasyonu
{
    partial class frmMesailer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesailer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maskedtxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.maskedtxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtMesaiSaatUcreti = new System.Windows.Forms.TextBox();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMesaiID = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTumMesaileriOde = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnMesaiOde = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnPersonelMesaileri = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnMesaiHareketRaporu = new System.Windows.Forms.Button();
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(854, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // maskedtxtBitis
            // 
            this.maskedtxtBitis.Location = new System.Drawing.Point(532, 357);
            this.maskedtxtBitis.Mask = "00:00";
            this.maskedtxtBitis.Name = "maskedtxtBitis";
            this.maskedtxtBitis.Size = new System.Drawing.Size(75, 20);
            this.maskedtxtBitis.TabIndex = 37;
            this.maskedtxtBitis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedtxtBitis.ValidatingType = typeof(System.DateTime);
            this.maskedtxtBitis.TextChanged += new System.EventHandler(this.maskedtxtBitis_TextChanged);
            // 
            // maskedtxtBaslangic
            // 
            this.maskedtxtBaslangic.Location = new System.Drawing.Point(532, 323);
            this.maskedtxtBaslangic.Mask = "00:00";
            this.maskedtxtBaslangic.Name = "maskedtxtBaslangic";
            this.maskedtxtBaslangic.Size = new System.Drawing.Size(75, 20);
            this.maskedtxtBaslangic.TabIndex = 36;
            this.maskedtxtBaslangic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedtxtBaslangic.ValidatingType = typeof(System.DateTime);
            this.maskedtxtBaslangic.TextChanged += new System.EventHandler(this.maskedtxtBaslangic_TextChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(672, 357);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(170, 56);
            this.txtAciklama.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(751, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "/";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(771, 325);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(71, 21);
            this.comboYil.TabIndex = 33;
            // 
            // comboAy
            // 
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(672, 325);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(71, 21);
            this.comboAy.TabIndex = 32;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(371, 427);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(236, 20);
            this.txtTutar.TabIndex = 31;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // txtMesaiSaatUcreti
            // 
            this.txtMesaiSaatUcreti.Location = new System.Drawing.Point(371, 393);
            this.txtMesaiSaatUcreti.Name = "txtMesaiSaatUcreti";
            this.txtMesaiSaatUcreti.Size = new System.Drawing.Size(236, 20);
            this.txtMesaiSaatUcreti.TabIndex = 30;
            this.txtMesaiSaatUcreti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesaiSaatUcreti.TextChanged += new System.EventHandler(this.txtMesaiSaatUcreti_TextChanged);
            this.txtMesaiSaatUcreti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesaiSaatUcreti_KeyPress);
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBitis.Location = new System.Drawing.Point(371, 357);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerBitis.TabIndex = 29;
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(371, 324);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerBaslangic.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Dönem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mesai Saat Ücreti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Bitiş Saati:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Başlangıç Saati:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mesai ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Personel ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Ad Soyad:";
            // 
            // txtMesaiID
            // 
            this.txtMesaiID.Location = new System.Drawing.Point(76, 325);
            this.txtMesaiID.Name = "txtMesaiID";
            this.txtMesaiID.Size = new System.Drawing.Size(151, 20);
            this.txtMesaiID.TabIndex = 41;
            this.txtMesaiID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesaiID_KeyPress);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(76, 360);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(151, 20);
            this.txtPersonelID.TabIndex = 42;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            this.txtPersonelID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelID_KeyPress);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(76, 395);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(151, 20);
            this.txtAdSoyad.TabIndex = 43;
            this.txtAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 44;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTumMesaileriOde
            // 
            this.btnTumMesaileriOde.FlatAppearance.BorderSize = 0;
            this.btnTumMesaileriOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumMesaileriOde.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTumMesaileriOde.ImageIndex = 4;
            this.btnTumMesaileriOde.ImageList = this.ımageList1;
            this.btnTumMesaileriOde.Location = new System.Drawing.Point(277, 449);
            this.btnTumMesaileriOde.Name = "btnTumMesaileriOde";
            this.btnTumMesaileriOde.Size = new System.Drawing.Size(110, 61);
            this.btnTumMesaileriOde.TabIndex = 45;
            this.btnTumMesaileriOde.Text = "Tüm Mesaileri Öde";
            this.btnTumMesaileriOde.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTumMesaileriOde.UseVisualStyleBackColor = true;
            this.btnTumMesaileriOde.Click += new System.EventHandler(this.btnTumMesaileriOde_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "46845_documents_draft_eraser_icon.png");
            this.ımageList1.Images.SetKeyName(1, "118917_edit_clear_icon.png");
            this.ımageList1.Images.SetKeyName(2, "3213304_bank_business_money_research_search_icon.png");
            this.ımageList1.Images.SetKeyName(3, "3688460_pencil_text_update_write_draw_icon.png");
            this.ımageList1.Images.SetKeyName(4, "5027823_calculator_coin_dollar_money_icon.png");
            this.ımageList1.Images.SetKeyName(5, "5027865_dollar_investor_money_icon.png");
            this.ımageList1.Images.SetKeyName(6, "748987_clock_time_icon.png");
            this.ımageList1.Images.SetKeyName(7, "49615_reports_report_documents_icon.png");
            // 
            // btnMesaiOde
            // 
            this.btnMesaiOde.FlatAppearance.BorderSize = 0;
            this.btnMesaiOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesaiOde.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesaiOde.ImageIndex = 5;
            this.btnMesaiOde.ImageList = this.ımageList1;
            this.btnMesaiOde.Location = new System.Drawing.Point(393, 452);
            this.btnMesaiOde.Name = "btnMesaiOde";
            this.btnMesaiOde.Size = new System.Drawing.Size(99, 58);
            this.btnMesaiOde.TabIndex = 46;
            this.btnMesaiOde.Text = "Mesai Öde";
            this.btnMesaiOde.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMesaiOde.UseVisualStyleBackColor = true;
            this.btnMesaiOde.Click += new System.EventHandler(this.btnMesaiOde_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.ImageIndex = 3;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(498, 449);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(106, 61);
            this.btnGuncelle.TabIndex = 47;
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
            this.btnSil.ImageIndex = 0;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(610, 449);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 61);
            this.btnSil.TabIndex = 48;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnPersonelMesaileri
            // 
            this.btnPersonelMesaileri.FlatAppearance.BorderSize = 0;
            this.btnPersonelMesaileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelMesaileri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonelMesaileri.ImageIndex = 6;
            this.btnPersonelMesaileri.ImageList = this.ımageList1;
            this.btnPersonelMesaileri.Location = new System.Drawing.Point(160, 444);
            this.btnPersonelMesaileri.Name = "btnPersonelMesaileri";
            this.btnPersonelMesaileri.Size = new System.Drawing.Size(111, 66);
            this.btnPersonelMesaileri.TabIndex = 49;
            this.btnPersonelMesaileri.Text = "Personel Mesaileri";
            this.btnPersonelMesaileri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelMesaileri.UseVisualStyleBackColor = true;
            this.btnPersonelMesaileri.Click += new System.EventHandler(this.btnPersonelMesaileri_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTemizle.ImageIndex = 1;
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(712, 449);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(106, 61);
            this.btnTemizle.TabIndex = 50;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnMesaiHareketRaporu
            // 
            this.btnMesaiHareketRaporu.FlatAppearance.BorderSize = 0;
            this.btnMesaiHareketRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesaiHareketRaporu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMesaiHareketRaporu.ImageIndex = 7;
            this.btnMesaiHareketRaporu.ImageList = this.ımageList1;
            this.btnMesaiHareketRaporu.Location = new System.Drawing.Point(43, 444);
            this.btnMesaiHareketRaporu.Name = "btnMesaiHareketRaporu";
            this.btnMesaiHareketRaporu.Size = new System.Drawing.Size(111, 66);
            this.btnMesaiHareketRaporu.TabIndex = 49;
            this.btnMesaiHareketRaporu.Text = "Mesai Raporlama";
            this.btnMesaiHareketRaporu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMesaiHareketRaporu.UseVisualStyleBackColor = true;
            this.btnMesaiHareketRaporu.Click += new System.EventHandler(this.btnMesaiHareketRaporu_Click);
            // 
            // frmMesailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 511);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnMesaiHareketRaporu);
            this.Controls.Add(this.btnPersonelMesaileri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnMesaiOde);
            this.Controls.Add(this.btnTumMesaileriOde);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtMesaiID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedtxtBitis);
            this.Controls.Add(this.maskedtxtBaslangic);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtMesaiSaatUcreti);
            this.Controls.Add(this.dateTimePickerBitis);
            this.Controls.Add(this.dateTimePickerBaslangic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMesailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesailer Sayfası";
            this.Load += new System.EventHandler(this.frmMesailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedtxtBitis;
        private System.Windows.Forms.MaskedTextBox maskedtxtBaslangic;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtMesaiSaatUcreti;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitis;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMesaiID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTumMesaileriOde;
        private System.Windows.Forms.Button btnMesaiOde;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnPersonelMesaileri;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnMesaiHareketRaporu;
    }
}