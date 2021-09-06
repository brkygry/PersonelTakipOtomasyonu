
namespace PersonelTakipOtomasyonu
{
    partial class frmPersonelMesaileri
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
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.dataGridViewMesai = new System.Windows.Forms.DataGridView();
            this.lblTutarMiktari = new System.Windows.Forms.Label();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMesaiIDAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesai)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.Size = new System.Drawing.Size(240, 432);
            this.dataGridViewPersonel.TabIndex = 0;
            this.dataGridViewPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonel_CellClick);
            // 
            // dataGridViewMesai
            // 
            this.dataGridViewMesai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMesai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesai.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMesai.Location = new System.Drawing.Point(240, 0);
            this.dataGridViewMesai.Name = "dataGridViewMesai";
            this.dataGridViewMesai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMesai.Size = new System.Drawing.Size(801, 375);
            this.dataGridViewMesai.TabIndex = 1;
            // 
            // lblTutarMiktari
            // 
            this.lblTutarMiktari.AutoSize = true;
            this.lblTutarMiktari.Location = new System.Drawing.Point(837, 398);
            this.lblTutarMiktari.Name = "lblTutarMiktari";
            this.lblTutarMiktari.Size = new System.Drawing.Size(0, 13);
            this.lblTutarMiktari.TabIndex = 3;
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Location = new System.Drawing.Point(670, 398);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblKayitSayisi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mesai ID Ara:";
            // 
            // txtMesaiIDAra
            // 
            this.txtMesaiIDAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMesaiIDAra.Location = new System.Drawing.Point(246, 403);
            this.txtMesaiIDAra.Name = "txtMesaiIDAra";
            this.txtMesaiIDAra.Size = new System.Drawing.Size(84, 20);
            this.txtMesaiIDAra.TabIndex = 6;
            this.txtMesaiIDAra.TextChanged += new System.EventHandler(this.txtMesaiIDAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Personel ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ad Soyad:";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(370, 403);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(91, 20);
            this.txtPersonelID.TabIndex = 9;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(467, 403);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(150, 20);
            this.txtAdSoyad.TabIndex = 10;
            // 
            // frmPersonelMesaileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 432);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMesaiIDAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKayitSayisi);
            this.Controls.Add(this.lblTutarMiktari);
            this.Controls.Add(this.dataGridViewMesai);
            this.Controls.Add(this.dataGridViewPersonel);
            this.Name = "frmPersonelMesaileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Mesaileri Sayfası";
            this.Load += new System.EventHandler(this.frmPersonelMesaileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.DataGridView dataGridViewMesai;
        private System.Windows.Forms.Label lblTutarMiktari;
        private System.Windows.Forms.Label lblKayitSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMesaiIDAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtAdSoyad;
    }
}