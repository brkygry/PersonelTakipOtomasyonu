
namespace PersonelTakipOtomasyonu
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnDepartmanEkle = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMaasZamlari = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.btnMesaiEkle = new System.Windows.Forms.Button();
            this.btnMesailer = new System.Windows.Forms.Button();
            this.btnIzınHareketListele = new System.Windows.Forms.Button();
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelFormlar = new System.Windows.Forms.Panel();
            this.panelIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "2993694_brand_brands_excel_logo_logos_icon.png");
            this.ımageList1.Images.SetKeyName(1, "49580_binary_department_organization chart_tree_icon.png");
            this.ımageList1.Images.SetKeyName(2, "1218712_customers_group_team_user_user group_icon.png");
            this.ımageList1.Images.SetKeyName(3, "379473_increase_money_icon (1).png");
            this.ımageList1.Images.SetKeyName(4, "3844407_hamburger_list_menu_more_navigation_icon.png");
            this.ımageList1.Images.SetKeyName(5, "3855607_parallel_pause_icon.png");
            this.ımageList1.Images.SetKeyName(6, "49576_new_add_plus_user_icon.png");
            this.ımageList1.Images.SetKeyName(7, "mesai.png");
            this.ımageList1.Images.SetKeyName(8, "5448845_christmas_date_decoration_holiday_ornament_icon (1).png");
            this.ımageList1.Images.SetKeyName(9, "1891032_add_append_circle_create_green_icon.png");
            this.ımageList1.Images.SetKeyName(10, "897226_balance spendings_budget_money_save money_icon.png");
            this.ımageList1.Images.SetKeyName(11, "3855614_exit_export_logout_icon.png");
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.FlatAppearance.BorderSize = 0;
            this.btnPersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelEkle.ImageIndex = 6;
            this.btnPersonelEkle.ImageList = this.ımageList1;
            this.btnPersonelEkle.Location = new System.Drawing.Point(3, 95);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(172, 47);
            this.btnPersonelEkle.TabIndex = 1;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnDepartmanEkle
            // 
            this.btnDepartmanEkle.FlatAppearance.BorderSize = 0;
            this.btnDepartmanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartmanEkle.ImageIndex = 1;
            this.btnDepartmanEkle.ImageList = this.ımageList1;
            this.btnDepartmanEkle.Location = new System.Drawing.Point(3, 43);
            this.btnDepartmanEkle.Name = "btnDepartmanEkle";
            this.btnDepartmanEkle.Size = new System.Drawing.Size(172, 46);
            this.btnDepartmanEkle.TabIndex = 1;
            this.btnDepartmanEkle.Text = "Departmanlar";
            this.btnDepartmanEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepartmanEkle.UseVisualStyleBackColor = true;
            this.btnDepartmanEkle.Click += new System.EventHandler(this.btnDepartmanEkle_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.FlatAppearance.BorderSize = 0;
            this.btnPersonelListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelListele.ImageIndex = 2;
            this.btnPersonelListele.ImageList = this.ımageList1;
            this.btnPersonelListele.Location = new System.Drawing.Point(3, 148);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(172, 47);
            this.btnPersonelListele.TabIndex = 1;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 11;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(3, 466);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(172, 50);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMaasZamlari
            // 
            this.btnMaasZamlari.FlatAppearance.BorderSize = 0;
            this.btnMaasZamlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaasZamlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasZamlari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaasZamlari.ImageIndex = 3;
            this.btnMaasZamlari.ImageList = this.ımageList1;
            this.btnMaasZamlari.Location = new System.Drawing.Point(3, 201);
            this.btnMaasZamlari.Name = "btnMaasZamlari";
            this.btnMaasZamlari.Size = new System.Drawing.Size(172, 47);
            this.btnMaasZamlari.TabIndex = 3;
            this.btnMaasZamlari.Text = "Maaş Zamları";
            this.btnMaasZamlari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaasZamlari.UseVisualStyleBackColor = true;
            this.btnMaasZamlari.Click += new System.EventHandler(this.btnMaasZamlari_Click);
            // 
            // btnPrim
            // 
            this.btnPrim.FlatAppearance.BorderSize = 0;
            this.btnPrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrim.ImageIndex = 10;
            this.btnPrim.ImageList = this.ımageList1;
            this.btnPrim.Location = new System.Drawing.Point(3, 360);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(172, 47);
            this.btnPrim.TabIndex = 4;
            this.btnPrim.Text = "Primler";
            this.btnPrim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrim.UseVisualStyleBackColor = true;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // btnMesaiEkle
            // 
            this.btnMesaiEkle.FlatAppearance.BorderSize = 0;
            this.btnMesaiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesaiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesaiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesaiEkle.ImageIndex = 9;
            this.btnMesaiEkle.ImageList = this.ımageList1;
            this.btnMesaiEkle.Location = new System.Drawing.Point(3, 254);
            this.btnMesaiEkle.Name = "btnMesaiEkle";
            this.btnMesaiEkle.Size = new System.Drawing.Size(172, 47);
            this.btnMesaiEkle.TabIndex = 5;
            this.btnMesaiEkle.Text = "Mesai Ekle";
            this.btnMesaiEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesaiEkle.UseVisualStyleBackColor = true;
            this.btnMesaiEkle.Click += new System.EventHandler(this.btnMesaiEkle_Click);
            // 
            // btnMesailer
            // 
            this.btnMesailer.FlatAppearance.BorderSize = 0;
            this.btnMesailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesailer.ImageIndex = 7;
            this.btnMesailer.ImageList = this.ımageList1;
            this.btnMesailer.Location = new System.Drawing.Point(3, 307);
            this.btnMesailer.Name = "btnMesailer";
            this.btnMesailer.Size = new System.Drawing.Size(172, 47);
            this.btnMesailer.TabIndex = 6;
            this.btnMesailer.Text = "Mesailer";
            this.btnMesailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMesailer.UseVisualStyleBackColor = true;
            this.btnMesailer.Click += new System.EventHandler(this.btnMesailer_Click);
            // 
            // btnIzınHareketListele
            // 
            this.btnIzınHareketListele.FlatAppearance.BorderSize = 0;
            this.btnIzınHareketListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzınHareketListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzınHareketListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzınHareketListele.ImageIndex = 8;
            this.btnIzınHareketListele.ImageList = this.ımageList1;
            this.btnIzınHareketListele.Location = new System.Drawing.Point(3, 413);
            this.btnIzınHareketListele.Name = "btnIzınHareketListele";
            this.btnIzınHareketListele.Size = new System.Drawing.Size(172, 47);
            this.btnIzınHareketListele.TabIndex = 8;
            this.btnIzınHareketListele.Text = "İzin Hareketleri";
            this.btnIzınHareketListele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzınHareketListele.UseVisualStyleBackColor = true;
            this.btnIzınHareketListele.Click += new System.EventHandler(this.btnIzınHareketListele_Click);
            // 
            // panelIslemler
            // 
            this.panelIslemler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIslemler.Controls.Add(this.btnCikis);
            this.panelIslemler.Controls.Add(this.btnMenu);
            this.panelIslemler.Controls.Add(this.btnDepartmanEkle);
            this.panelIslemler.Controls.Add(this.btnIzınHareketListele);
            this.panelIslemler.Controls.Add(this.btnMesaiEkle);
            this.panelIslemler.Controls.Add(this.btnMaasZamlari);
            this.panelIslemler.Controls.Add(this.btnPrim);
            this.panelIslemler.Controls.Add(this.btnPersonelListele);
            this.panelIslemler.Controls.Add(this.btnMesailer);
            this.panelIslemler.Controls.Add(this.btnPersonelEkle);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIslemler.Location = new System.Drawing.Point(0, 0);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(178, 521);
            this.panelIslemler.TabIndex = 10;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.ImageIndex = 4;
            this.btnMenu.ImageList = this.ımageList1;
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(49, 42);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelFormlar
            // 
            this.panelFormlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormlar.Location = new System.Drawing.Point(178, 0);
            this.panelFormlar.Name = "panelFormlar";
            this.panelFormlar.Size = new System.Drawing.Size(886, 521);
            this.panelFormlar.TabIndex = 11;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 521);
            this.Controls.Add(this.panelFormlar);
            this.Controls.Add(this.panelIslemler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Takip Sistemi";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.panelIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnDepartmanEkle;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMaasZamlari;
        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.Button btnMesaiEkle;
        private System.Windows.Forms.Button btnMesailer;
        private System.Windows.Forms.Button btnIzınHareketListele;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelFormlar;
    }
}

