
namespace PersonelTakipOtomasyonu
{
    partial class frmPrimleriGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimleriGoster));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPrimID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrimSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPrimGuncelle = new System.Windows.Forms.Button();
            this.btnTumPrimleriOde = new System.Windows.Forms.Button();
            this.btnPrimOde = new System.Windows.Forms.Button();
            this.btnDonemDegistir = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(806, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Prim Tutarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Personel ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(553, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "/";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(572, 304);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(101, 21);
            this.comboYil.TabIndex = 37;
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
            this.comboAy.Location = new System.Drawing.Point(455, 304);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(92, 21);
            this.comboAy.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Dönem:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(455, 358);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(335, 43);
            this.txtAciklama.TabIndex = 34;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(455, 332);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(218, 20);
            this.txtPrimTutari.TabIndex = 33;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(85, 358);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(218, 20);
            this.txtAdSoyad.TabIndex = 32;
            this.txtAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(85, 332);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(218, 20);
            this.txtPersonelID.TabIndex = 31;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            this.txtPersonelID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelID_KeyPress);
            // 
            // txtPrimID
            // 
            this.txtPrimID.Location = new System.Drawing.Point(85, 304);
            this.txtPrimID.Name = "txtPrimID";
            this.txtPrimID.Size = new System.Drawing.Size(218, 20);
            this.txtPrimID.TabIndex = 43;
            this.txtPrimID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "PrimID";
            // 
            // btnPrimSil
            // 
            this.btnPrimSil.FlatAppearance.BorderSize = 0;
            this.btnPrimSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimSil.ImageIndex = 0;
            this.btnPrimSil.ImageList = this.ımageList1;
            this.btnPrimSil.Location = new System.Drawing.Point(412, 407);
            this.btnPrimSil.Name = "btnPrimSil";
            this.btnPrimSil.Size = new System.Drawing.Size(111, 65);
            this.btnPrimSil.TabIndex = 47;
            this.btnPrimSil.Text = "Prim Sil";
            this.btnPrimSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimSil.UseVisualStyleBackColor = true;
            this.btnPrimSil.Click += new System.EventHandler(this.btnPrimSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "46845_documents_draft_eraser_icon.png");
            this.ımageList1.Images.SetKeyName(1, "379473_increase_money_icon (1).png");
            this.ımageList1.Images.SetKeyName(2, "669953_purse_dollars_finance_money_pay_icon.png");
            this.ımageList1.Images.SetKeyName(3, "897226_balance spendings_budget_money_save money_icon.png");
            this.ımageList1.Images.SetKeyName(4, "1055031_magnifying_search_view_icon.png");
            this.ımageList1.Images.SetKeyName(5, "1891032_add_append_circle_create_green_icon.png");
            this.ımageList1.Images.SetKeyName(6, "3213304_bank_business_money_research_search_icon.png");
            this.ımageList1.Images.SetKeyName(7, "3688460_pencil_text_update_write_draw_icon.png");
            this.ımageList1.Images.SetKeyName(8, "3855614_exit_export_logout_icon.png");
            this.ımageList1.Images.SetKeyName(9, "118917_edit_clear_icon.png");
            this.ımageList1.Images.SetKeyName(10, "3440907_business_cash_currency_ecommerce_finance_icon.png");
            this.ımageList1.Images.SetKeyName(11, "5027823_calculator_coin_dollar_money_icon.png");
            this.ımageList1.Images.SetKeyName(12, "5027865_dollar_investor_money_icon.png");
            // 
            // btnPrimGuncelle
            // 
            this.btnPrimGuncelle.FlatAppearance.BorderSize = 0;
            this.btnPrimGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimGuncelle.ImageIndex = 7;
            this.btnPrimGuncelle.ImageList = this.ımageList1;
            this.btnPrimGuncelle.Location = new System.Drawing.Point(278, 407);
            this.btnPrimGuncelle.Name = "btnPrimGuncelle";
            this.btnPrimGuncelle.Size = new System.Drawing.Size(111, 65);
            this.btnPrimGuncelle.TabIndex = 46;
            this.btnPrimGuncelle.Text = "Prim Güncelle";
            this.btnPrimGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimGuncelle.UseVisualStyleBackColor = true;
            this.btnPrimGuncelle.Click += new System.EventHandler(this.btnPrimGuncelle_Click);
            // 
            // btnTumPrimleriOde
            // 
            this.btnTumPrimleriOde.FlatAppearance.BorderSize = 0;
            this.btnTumPrimleriOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumPrimleriOde.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTumPrimleriOde.ImageIndex = 11;
            this.btnTumPrimleriOde.ImageList = this.ımageList1;
            this.btnTumPrimleriOde.Location = new System.Drawing.Point(17, 407);
            this.btnTumPrimleriOde.Name = "btnTumPrimleriOde";
            this.btnTumPrimleriOde.Size = new System.Drawing.Size(111, 65);
            this.btnTumPrimleriOde.TabIndex = 45;
            this.btnTumPrimleriOde.Text = "Tüm Primleri Öde";
            this.btnTumPrimleriOde.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTumPrimleriOde.UseVisualStyleBackColor = true;
            this.btnTumPrimleriOde.Click += new System.EventHandler(this.btnTumPrimleriOde_Click);
            // 
            // btnPrimOde
            // 
            this.btnPrimOde.FlatAppearance.BorderSize = 0;
            this.btnPrimOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimOde.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimOde.ImageIndex = 12;
            this.btnPrimOde.ImageList = this.ımageList1;
            this.btnPrimOde.Location = new System.Drawing.Point(148, 407);
            this.btnPrimOde.Name = "btnPrimOde";
            this.btnPrimOde.Size = new System.Drawing.Size(111, 65);
            this.btnPrimOde.TabIndex = 48;
            this.btnPrimOde.Text = "Prim Öde";
            this.btnPrimOde.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimOde.UseVisualStyleBackColor = true;
            this.btnPrimOde.Click += new System.EventHandler(this.btnPrimOde_Click);
            // 
            // btnDonemDegistir
            // 
            this.btnDonemDegistir.Location = new System.Drawing.Point(679, 304);
            this.btnDonemDegistir.Name = "btnDonemDegistir";
            this.btnDonemDegistir.Size = new System.Drawing.Size(111, 48);
            this.btnDonemDegistir.TabIndex = 49;
            this.btnDonemDegistir.Text = "Dönem Değiştir";
            this.btnDonemDegistir.UseVisualStyleBackColor = true;
            this.btnDonemDegistir.Click += new System.EventHandler(this.btnDonemDegistir_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ImageIndex = 8;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(679, 407);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(111, 65);
            this.btnCikis.TabIndex = 51;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTemizle.ImageIndex = 9;
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(544, 407);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(111, 65);
            this.btnTemizle.TabIndex = 50;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmPrimleriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 476);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnDonemDegistir);
            this.Controls.Add(this.btnPrimOde);
            this.Controls.Add(this.btnPrimSil);
            this.Controls.Add(this.btnPrimGuncelle);
            this.Controls.Add(this.btnTumPrimleriOde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrimID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPrimleriGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrimleriGoster";
            this.Load += new System.EventHandler(this.frmPrimleriGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPrimID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrimSil;
        private System.Windows.Forms.Button btnPrimGuncelle;
        private System.Windows.Forms.Button btnTumPrimleriOde;
        private System.Windows.Forms.Button btnPrimOde;
        private System.Windows.Forms.Button btnDonemDegistir;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}