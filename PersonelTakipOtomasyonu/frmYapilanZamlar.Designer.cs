
namespace PersonelTakipOtomasyonu
{
    partial class frmYapilanZamlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYapilanZamlar));
            this.radioYüzde = new System.Windows.Forms.RadioButton();
            this.radioFiyat = new System.Windows.Forms.RadioButton();
            this.txtYuzde = new System.Windows.Forms.TextBox();
            this.comboPersoneller = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnOnay = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioYüzde
            // 
            this.radioYüzde.AutoSize = true;
            this.radioYüzde.Location = new System.Drawing.Point(114, 40);
            this.radioYüzde.Name = "radioYüzde";
            this.radioYüzde.Size = new System.Drawing.Size(92, 17);
            this.radioYüzde.TabIndex = 0;
            this.radioYüzde.TabStop = true;
            this.radioYüzde.Text = "Yüzdeye Göre";
            this.radioYüzde.UseVisualStyleBackColor = true;
            this.radioYüzde.CheckedChanged += new System.EventHandler(this.radioYüzde_CheckedChanged);
            // 
            // radioFiyat
            // 
            this.radioFiyat.AutoSize = true;
            this.radioFiyat.Location = new System.Drawing.Point(253, 40);
            this.radioFiyat.Name = "radioFiyat";
            this.radioFiyat.Size = new System.Drawing.Size(79, 17);
            this.radioFiyat.TabIndex = 1;
            this.radioFiyat.TabStop = true;
            this.radioFiyat.Text = "Fiyata Göre";
            this.radioFiyat.UseVisualStyleBackColor = true;
            this.radioFiyat.CheckedChanged += new System.EventHandler(this.radioFiyat_CheckedChanged);
            // 
            // txtYuzde
            // 
            this.txtYuzde.Location = new System.Drawing.Point(114, 129);
            this.txtYuzde.Name = "txtYuzde";
            this.txtYuzde.Size = new System.Drawing.Size(218, 20);
            this.txtYuzde.TabIndex = 4;
            this.txtYuzde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYuzde_KeyPress);
            // 
            // comboPersoneller
            // 
            this.comboPersoneller.FormattingEnabled = true;
            this.comboPersoneller.Items.AddRange(new object[] {
            "Tüm Personeller"});
            this.comboPersoneller.Location = new System.Drawing.Point(114, 102);
            this.comboPersoneller.Name = "comboPersoneller";
            this.comboPersoneller.Size = new System.Drawing.Size(188, 21);
            this.comboPersoneller.TabIndex = 5;
            this.comboPersoneller.SelectedIndexChanged += new System.EventHandler(this.comboPersoneller_SelectedIndexChanged);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(114, 155);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(218, 20);
            this.txtFiyat.TabIndex = 6;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(114, 181);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(218, 68);
            this.txtAciklama.TabIndex = 7;
            // 
            // btnOnay
            // 
            this.btnOnay.FlatAppearance.BorderSize = 0;
            this.btnOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnay.ImageIndex = 1;
            this.btnOnay.ImageList = this.ımageList1;
            this.btnOnay.Location = new System.Drawing.Point(114, 255);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(102, 43);
            this.btnOnay.TabIndex = 8;
            this.btnOnay.Text = "Onay";
            this.btnOnay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "exit.png");
            this.ımageList1.Images.SetKeyName(1, "save.png");
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 0;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(231, 255);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 43);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dönem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Personeller:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yüzde(%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fiyat(TL):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Açıklama:";
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
            this.comboAy.Location = new System.Drawing.Point(114, 70);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(92, 21);
            this.comboAy.TabIndex = 15;
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(231, 69);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(101, 21);
            this.comboYil.TabIndex = 16;
            this.comboYil.SelectedIndexChanged += new System.EventHandler(this.comboYil_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(212, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "/";
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Location = new System.Drawing.Point(308, 105);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(13, 13);
            this.lblPersonelID.TabIndex = 19;
            this.lblPersonelID.Text = "0";
            // 
            // frmYapilanZamlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 310);
            this.Controls.Add(this.lblPersonelID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.comboPersoneller);
            this.Controls.Add(this.txtYuzde);
            this.Controls.Add(this.radioFiyat);
            this.Controls.Add(this.radioYüzde);
            this.Name = "frmYapilanZamlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Maaş Zamları";
            this.Load += new System.EventHandler(this.frmYapilanZamlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioYüzde;
        private System.Windows.Forms.RadioButton radioFiyat;
        private System.Windows.Forms.TextBox txtYuzde;
        private System.Windows.Forms.ComboBox comboPersoneller;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.ImageList ımageList1;
    }
}