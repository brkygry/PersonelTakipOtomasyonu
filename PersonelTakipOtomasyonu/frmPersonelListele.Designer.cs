
namespace PersonelTakipOtomasyonu
{
    partial class frmPersonelListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelListele));
            this.txtPersonelIDAra = new System.Windows.Forms.TextBox();
            this.labelPersonelID = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDogum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerGiris = new System.Windows.Forms.DateTimePicker();
            this.comboDepartman = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTlefon = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.personelIDtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoyadAra = new System.Windows.Forms.TextBox();
            this.txtAdAra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTCAra = new System.Windows.Forms.TextBox();
            this.dateTimePickerTarihAra = new System.Windows.Forms.DateTimePicker();
            this.lblToplamKayit = new System.Windows.Forms.Label();
            this.lblToplamMaaş = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelIDAra
            // 
            this.txtPersonelIDAra.Location = new System.Drawing.Point(80, 17);
            this.txtPersonelIDAra.Name = "txtPersonelIDAra";
            this.txtPersonelIDAra.Size = new System.Drawing.Size(69, 20);
            this.txtPersonelIDAra.TabIndex = 0;
            this.txtPersonelIDAra.TextChanged += new System.EventHandler(this.txtPersonelIDAra_TextChanged);
            // 
            // labelPersonelID
            // 
            this.labelPersonelID.AutoSize = true;
            this.labelPersonelID.Location = new System.Drawing.Point(12, 20);
            this.labelPersonelID.Name = "labelPersonelID";
            this.labelPersonelID.Size = new System.Drawing.Size(65, 13);
            this.labelPersonelID.TabIndex = 1;
            this.labelPersonelID.Text = "Personel ID:";
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Location = new System.Drawing.Point(155, 20);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(101, 13);
            this.labelTC.TabIndex = 1;
            this.labelTC.Text = "TC Kimlik Numarası:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(849, 273);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(244, 402);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Doğum Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Açıklama:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Giriş Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Maaş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Departman:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Adı:";
            // 
            // dateTimePickerDogum
            // 
            this.dateTimePickerDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDogum.Location = new System.Drawing.Point(323, 399);
            this.dateTimePickerDogum.Name = "dateTimePickerDogum";
            this.dateTimePickerDogum.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerDogum.TabIndex = 17;
            // 
            // dateTimePickerGiris
            // 
            this.dateTimePickerGiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerGiris.Location = new System.Drawing.Point(93, 399);
            this.dateTimePickerGiris.Name = "dateTimePickerGiris";
            this.dateTimePickerGiris.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerGiris.TabIndex = 15;
            // 
            // comboDepartman
            // 
            this.comboDepartman.FormattingEnabled = true;
            this.comboDepartman.Location = new System.Drawing.Point(536, 363);
            this.comboDepartman.Name = "comboDepartman";
            this.comboDepartman.Size = new System.Drawing.Size(129, 21);
            this.comboDepartman.TabIndex = 12;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(339, 441);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(176, 70);
            this.txtAciklama.TabIndex = 10;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(536, 402);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(129, 20);
            this.txtMaas.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(323, 363);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(87, 441);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(176, 70);
            this.txtAdres.TabIndex = 7;
            // 
            // txtTlefon
            // 
            this.txtTlefon.Location = new System.Drawing.Point(93, 363);
            this.txtTlefon.Name = "txtTlefon";
            this.txtTlefon.Size = new System.Drawing.Size(129, 20);
            this.txtTlefon.TabIndex = 6;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(536, 327);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(129, 20);
            this.txtSoyadi.TabIndex = 11;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(323, 327);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(129, 20);
            this.txtAdi.TabIndex = 5;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "delete.png");
            this.ımageList1.Images.SetKeyName(1, "exit.png");
            this.ımageList1.Images.SetKeyName(2, "save.png");
            this.ımageList1.Images.SetKeyName(3, "update.png");
            this.ımageList1.Images.SetKeyName(4, "46845_documents_draft_eraser_icon.png");
            this.ımageList1.Images.SetKeyName(5, "3688460_pencil_text_update_write_draw_icon.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncelle.ImageIndex = 5;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(674, 343);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 58);
            this.btnGuncelle.TabIndex = 32;
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
            this.btnSil.ImageIndex = 4;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(780, 343);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 58);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Personel ID:";
            // 
            // personelIDtxt
            // 
            this.personelIDtxt.Location = new System.Drawing.Point(93, 327);
            this.personelIDtxt.Name = "personelIDtxt";
            this.personelIDtxt.Size = new System.Drawing.Size(129, 20);
            this.personelIDtxt.TabIndex = 35;
            this.personelIDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personelIDtxt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Soyad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(347, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Ad:";
            // 
            // txtSoyadAra
            // 
            this.txtSoyadAra.Location = new System.Drawing.Point(536, 16);
            this.txtSoyadAra.Name = "txtSoyadAra";
            this.txtSoyadAra.Size = new System.Drawing.Size(129, 20);
            this.txtSoyadAra.TabIndex = 37;
            this.txtSoyadAra.TextChanged += new System.EventHandler(this.txtSoyadAra_TextChanged);
            // 
            // txtAdAra
            // 
            this.txtAdAra.Location = new System.Drawing.Point(376, 16);
            this.txtAdAra.Name = "txtAdAra";
            this.txtAdAra.Size = new System.Drawing.Size(108, 20);
            this.txtAdAra.TabIndex = 38;
            this.txtAdAra.TextChanged += new System.EventHandler(this.txtAdAra_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(671, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Giriş Tarihi:";
            // 
            // txtTCAra
            // 
            this.txtTCAra.Location = new System.Drawing.Point(263, 16);
            this.txtTCAra.Name = "txtTCAra";
            this.txtTCAra.Size = new System.Drawing.Size(78, 20);
            this.txtTCAra.TabIndex = 43;
            this.txtTCAra.TextChanged += new System.EventHandler(this.txtTCAra_TextChanged);
            // 
            // dateTimePickerTarihAra
            // 
            this.dateTimePickerTarihAra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTarihAra.Location = new System.Drawing.Point(736, 16);
            this.dateTimePickerTarihAra.Name = "dateTimePickerTarihAra";
            this.dateTimePickerTarihAra.Size = new System.Drawing.Size(109, 20);
            this.dateTimePickerTarihAra.TabIndex = 44;
            this.dateTimePickerTarihAra.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblToplamKayit
            // 
            this.lblToplamKayit.AutoSize = true;
            this.lblToplamKayit.Location = new System.Drawing.Point(602, 444);
            this.lblToplamKayit.Name = "lblToplamKayit";
            this.lblToplamKayit.Size = new System.Drawing.Size(128, 13);
            this.lblToplamKayit.TabIndex = 45;
            this.lblToplamKayit.Text = "Toplam 85 kayıt listelendi.";
            // 
            // lblToplamMaaş
            // 
            this.lblToplamMaaş.AutoSize = true;
            this.lblToplamMaaş.Location = new System.Drawing.Point(602, 483);
            this.lblToplamMaaş.Name = "lblToplamMaaş";
            this.lblToplamMaaş.Size = new System.Drawing.Size(224, 13);
            this.lblToplamMaaş.TabIndex = 45;
            this.lblToplamMaaş.Text = "Listede toplam 55000,85 TL maaş hesaplandı.";
            // 
            // frmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 523);
            this.Controls.Add(this.lblToplamMaaş);
            this.Controls.Add(this.lblToplamKayit);
            this.Controls.Add(this.dateTimePickerTarihAra);
            this.Controls.Add(this.txtTCAra);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSoyadAra);
            this.Controls.Add(this.txtAdAra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.personelIDtxt);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDogum);
            this.Controls.Add(this.dateTimePickerGiris);
            this.Controls.Add(this.comboDepartman);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTlefon);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.labelPersonelID);
            this.Controls.Add(this.txtPersonelIDAra);
            this.Name = "frmPersonelListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelIDAra;
        private System.Windows.Forms.Label labelPersonelID;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogum;
        private System.Windows.Forms.DateTimePicker dateTimePickerGiris;
        private System.Windows.Forms.ComboBox comboDepartman;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTlefon;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox personelIDtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoyadAra;
        private System.Windows.Forms.TextBox txtAdAra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTCAra;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarihAra;
        private System.Windows.Forms.Label lblToplamKayit;
        private System.Windows.Forms.Label lblToplamMaaş;
    }
}