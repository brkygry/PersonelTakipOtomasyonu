
namespace PersonelTakipOtomasyonu
{
    partial class frmPrimler
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
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.radioKisiyeOzel = new System.Windows.Forms.RadioButton();
            this.radioTumPersoneller = new System.Windows.Forms.RadioButton();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrimEkle = new System.Windows.Forms.Button();
            this.btnPrimGoster = new System.Windows.Forms.Button();
            this.btnPersonelPrimleri = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(180, 46);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(218, 20);
            this.txtPersonelID.TabIndex = 0;
            this.txtPersonelID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelID_KeyPress);
            // 
            // radioKisiyeOzel
            // 
            this.radioKisiyeOzel.AutoSize = true;
            this.radioKisiyeOzel.Location = new System.Drawing.Point(122, 12);
            this.radioKisiyeOzel.Name = "radioKisiyeOzel";
            this.radioKisiyeOzel.Size = new System.Drawing.Size(99, 17);
            this.radioKisiyeOzel.TabIndex = 1;
            this.radioKisiyeOzel.TabStop = true;
            this.radioKisiyeOzel.Text = "Kişiye Özel Prim";
            this.radioKisiyeOzel.UseVisualStyleBackColor = true;
            this.radioKisiyeOzel.CheckedChanged += new System.EventHandler(this.radioKisiyeOzel_CheckedChanged);
            // 
            // radioTumPersoneller
            // 
            this.radioTumPersoneller.AutoSize = true;
            this.radioTumPersoneller.Location = new System.Drawing.Point(443, 12);
            this.radioTumPersoneller.Name = "radioTumPersoneller";
            this.radioTumPersoneller.Size = new System.Drawing.Size(144, 17);
            this.radioTumPersoneller.TabIndex = 2;
            this.radioTumPersoneller.TabStop = true;
            this.radioTumPersoneller.Text = "Tüm Personeller İçin Prim";
            this.radioTumPersoneller.UseVisualStyleBackColor = true;
            this.radioTumPersoneller.CheckedChanged += new System.EventHandler(this.radioTumPersoneller_CheckedChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(180, 72);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(218, 20);
            this.txtAdSoyad.TabIndex = 3;
            this.txtAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdSoyad_KeyPress);
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(550, 43);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(218, 20);
            this.txtPrimTutari.TabIndex = 5;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(550, 69);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(218, 65);
            this.txtAciklama.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(278, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "/";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(297, 98);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(101, 21);
            this.comboYil.TabIndex = 21;
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
            this.comboAy.Location = new System.Drawing.Point(180, 99);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(92, 21);
            this.comboAy.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dönem:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 271);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Personel ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prim Tutarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Açıklama:";
            // 
            // btnPrimEkle
            // 
            this.btnPrimEkle.Location = new System.Drawing.Point(180, 151);
            this.btnPrimEkle.Name = "btnPrimEkle";
            this.btnPrimEkle.Size = new System.Drawing.Size(111, 50);
            this.btnPrimEkle.TabIndex = 28;
            this.btnPrimEkle.Text = "Prim Ekle";
            this.btnPrimEkle.UseVisualStyleBackColor = true;
            this.btnPrimEkle.Click += new System.EventHandler(this.btnPrimEkle_Click);
            // 
            // btnPrimGoster
            // 
            this.btnPrimGoster.Location = new System.Drawing.Point(314, 152);
            this.btnPrimGoster.Name = "btnPrimGoster";
            this.btnPrimGoster.Size = new System.Drawing.Size(111, 49);
            this.btnPrimGoster.TabIndex = 29;
            this.btnPrimGoster.Text = "Primleri Göster";
            this.btnPrimGoster.UseVisualStyleBackColor = true;
            this.btnPrimGoster.Click += new System.EventHandler(this.btnPrimGoster_Click);
            // 
            // btnPersonelPrimleri
            // 
            this.btnPersonelPrimleri.Location = new System.Drawing.Point(450, 152);
            this.btnPersonelPrimleri.Name = "btnPersonelPrimleri";
            this.btnPersonelPrimleri.Size = new System.Drawing.Size(111, 49);
            this.btnPersonelPrimleri.TabIndex = 30;
            this.btnPersonelPrimleri.Text = "Personel Primleri";
            this.btnPersonelPrimleri.UseVisualStyleBackColor = true;
            this.btnPersonelPrimleri.Click += new System.EventHandler(this.btnPersonelPrimleri_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(586, 152);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(111, 49);
            this.btnTemizle.TabIndex = 31;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmPrimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 511);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnPersonelPrimleri);
            this.Controls.Add(this.btnPrimGoster);
            this.Controls.Add(this.btnPrimEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.radioTumPersoneller);
            this.Controls.Add(this.radioKisiyeOzel);
            this.Controls.Add(this.txtPersonelID);
            this.Name = "frmPrimler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrimler";
            this.Load += new System.EventHandler(this.frmPrimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.RadioButton radioKisiyeOzel;
        private System.Windows.Forms.RadioButton radioTumPersoneller;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrimEkle;
        private System.Windows.Forms.Button btnPrimGoster;
        private System.Windows.Forms.Button btnPersonelPrimleri;
        private System.Windows.Forms.Button btnTemizle;
    }
}