namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    partial class HastaIslemleri
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
            this.txt_hastaadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.dt_sevktarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_bul = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hastabilgileri = new System.Windows.Forms.Button();
            this.txt_dosyano = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_poliklinik = new System.Windows.Forms.ComboBox();
            this.txt_sirano = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_yapilanislem = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_drkod = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_birimfiyat = new System.Windows.Forms.TextBox();
            this.nm_miktar = new System.Windows.Forms.NumericUpDown();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dgvyapilanislemler = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.btn_secsil = new System.Windows.Forms.Button();
            this.btn_taburcu = new System.Windows.Forms.Button();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_toplamtutar = new System.Windows.Forms.Label();
            this.btnkullaniciformunagec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvyapilanislemler)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_hastaadi
            // 
            this.txt_hastaadi.Enabled = false;
            this.txt_hastaadi.Location = new System.Drawing.Point(348, 13);
            this.txt_hastaadi.Name = "txt_hastaadi";
            this.txt_hastaadi.Size = new System.Drawing.Size(110, 20);
            this.txt_hastaadi.TabIndex = 1;
            this.txt_hastaadi.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sevk Tarihi:";
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Enabled = false;
            this.txt_soyadi.Location = new System.Drawing.Point(348, 41);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(110, 20);
            this.txt_soyadi.TabIndex = 1;
            this.txt_soyadi.TabStop = false;
            // 
            // dt_sevktarihi
            // 
            this.dt_sevktarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_sevktarihi.Location = new System.Drawing.Point(101, 40);
            this.dt_sevktarihi.Name = "dt_sevktarihi";
            this.dt_sevktarihi.Size = new System.Drawing.Size(142, 20);
            this.dt_sevktarihi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyadı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(483, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sağlık Ocağı Bilgi Sistemi";
            // 
            // btn_bul
            // 
            this.btn_bul.Location = new System.Drawing.Point(191, 11);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(52, 23);
            this.btn_bul.TabIndex = 4;
            this.btn_bul.Text = "Bul";
            this.btn_bul.UseVisualStyleBackColor = true;
            this.btn_bul.Click += new System.EventHandler(this.btn_bul_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hasta Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya No:";
            // 
            // btn_hastabilgileri
            // 
            this.btn_hastabilgileri.Location = new System.Drawing.Point(487, 29);
            this.btn_hastabilgileri.Name = "btn_hastabilgileri";
            this.btn_hastabilgileri.Size = new System.Drawing.Size(208, 41);
            this.btn_hastabilgileri.TabIndex = 5;
            this.btn_hastabilgileri.TabStop = false;
            this.btn_hastabilgileri.Text = "Hasta Bilgileri";
            this.btn_hastabilgileri.UseVisualStyleBackColor = true;
            this.btn_hastabilgileri.Click += new System.EventHandler(this.btn_hastabilgileri_Click);
            // 
            // txt_dosyano
            // 
            this.txt_dosyano.Location = new System.Drawing.Point(101, 13);
            this.txt_dosyano.MaxLength = 4;
            this.txt_dosyano.Name = "txt_dosyano";
            this.txt_dosyano.Size = new System.Drawing.Size(84, 20);
            this.txt_dosyano.TabIndex = 0;
            this.txt_dosyano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dosyano_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.txt_dosyano);
            this.groupBox1.Controls.Add(this.btn_hastabilgileri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_bul);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dt_sevktarihi);
            this.groupBox1.Controls.Add(this.txt_soyadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_hastaadi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SandyBrown;
            this.label8.Location = new System.Drawing.Point(0, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 41);
            this.label8.TabIndex = 7;
            this.label8.Text = "Poliklinik";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SandyBrown;
            this.label9.Location = new System.Drawing.Point(133, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 41);
            this.label9.TabIndex = 7;
            this.label9.Text = "Sıra no:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_poliklinik
            // 
            this.cmb_poliklinik.FormattingEnabled = true;
            this.cmb_poliklinik.Location = new System.Drawing.Point(3, 93);
            this.cmb_poliklinik.Name = "cmb_poliklinik";
            this.cmb_poliklinik.Size = new System.Drawing.Size(124, 21);
            this.cmb_poliklinik.TabIndex = 1;
            this.cmb_poliklinik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_poliklinik_KeyPress);
            this.cmb_poliklinik.Leave += new System.EventHandler(this.cmb_poliklinik_Leave);
            // 
            // txt_sirano
            // 
            this.txt_sirano.Enabled = false;
            this.txt_sirano.Location = new System.Drawing.Point(140, 94);
            this.txt_sirano.Name = "txt_sirano";
            this.txt_sirano.Size = new System.Drawing.Size(68, 20);
            this.txt_sirano.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SandyBrown;
            this.label10.Location = new System.Drawing.Point(213, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 41);
            this.label10.TabIndex = 10;
            this.label10.Text = "Yapılan İşlem";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_yapilanislem
            // 
            this.cmb_yapilanislem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_yapilanislem.FormattingEnabled = true;
            this.cmb_yapilanislem.Location = new System.Drawing.Point(221, 93);
            this.cmb_yapilanislem.Name = "cmb_yapilanislem";
            this.cmb_yapilanislem.Size = new System.Drawing.Size(123, 21);
            this.cmb_yapilanislem.TabIndex = 3;
            this.cmb_yapilanislem.SelectedIndexChanged += new System.EventHandler(this.cmb_yapilanislem_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.SandyBrown;
            this.label11.Location = new System.Drawing.Point(348, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 41);
            this.label11.TabIndex = 12;
            this.label11.Text = "Doktor kodu";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_drkod
            // 
            this.cmb_drkod.FormattingEnabled = true;
            this.cmb_drkod.Location = new System.Drawing.Point(363, 94);
            this.cmb_drkod.MaxLength = 4;
            this.cmb_drkod.Name = "cmb_drkod";
            this.cmb_drkod.Size = new System.Drawing.Size(75, 21);
            this.cmb_drkod.TabIndex = 4;
            this.cmb_drkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_drkod_KeyPress);
            this.cmb_drkod.Leave += new System.EventHandler(this.cmb_drkod_Leave);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.SandyBrown;
            this.label12.Location = new System.Drawing.Point(444, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 41);
            this.label12.TabIndex = 14;
            this.label12.Text = "Miktar";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.SandyBrown;
            this.label13.Location = new System.Drawing.Point(538, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 41);
            this.label13.TabIndex = 16;
            this.label13.Text = "Birim Fiyat";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_birimfiyat
            // 
            this.txt_birimfiyat.Enabled = false;
            this.txt_birimfiyat.Location = new System.Drawing.Point(546, 94);
            this.txt_birimfiyat.Name = "txt_birimfiyat";
            this.txt_birimfiyat.Size = new System.Drawing.Size(90, 20);
            this.txt_birimfiyat.TabIndex = 6;
            // 
            // nm_miktar
            // 
            this.nm_miktar.Location = new System.Drawing.Point(453, 93);
            this.nm_miktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_miktar.Name = "nm_miktar";
            this.nm_miktar.Size = new System.Drawing.Size(79, 20);
            this.nm_miktar.TabIndex = 5;
            this.nm_miktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(642, 80);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(72, 41);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dgvyapilanislemler
            // 
            this.dgvyapilanislemler.AllowUserToAddRows = false;
            this.dgvyapilanislemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvyapilanislemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvyapilanislemler.Location = new System.Drawing.Point(3, 16);
            this.dgvyapilanislemler.Name = "dgvyapilanislemler";
            this.dgvyapilanislemler.ReadOnly = true;
            this.dgvyapilanislemler.Size = new System.Drawing.Size(705, 238);
            this.dgvyapilanislemler.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox2.Controls.Add(this.dgvyapilanislemler);
            this.groupBox2.Location = new System.Drawing.Point(3, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 257);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yapılan işlemler ve birim fiyat";
            // 
            // btn_yeni
            // 
            this.btn_yeni.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_yeni.Location = new System.Drawing.Point(12, 417);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(75, 48);
            this.btn_yeni.TabIndex = 1;
            this.btn_yeni.Text = "Yeni";
            this.btn_yeni.UseVisualStyleBackColor = false;
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // btn_secsil
            // 
            this.btn_secsil.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_secsil.Location = new System.Drawing.Point(93, 417);
            this.btn_secsil.Name = "btn_secsil";
            this.btn_secsil.Size = new System.Drawing.Size(75, 48);
            this.btn_secsil.TabIndex = 1;
            this.btn_secsil.Text = "Seç - Sil";
            this.btn_secsil.UseVisualStyleBackColor = false;
            this.btn_secsil.Click += new System.EventHandler(this.btn_secsil_Click);
            // 
            // btn_taburcu
            // 
            this.btn_taburcu.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_taburcu.Location = new System.Drawing.Point(174, 417);
            this.btn_taburcu.Name = "btn_taburcu";
            this.btn_taburcu.Size = new System.Drawing.Size(75, 48);
            this.btn_taburcu.TabIndex = 1;
            this.btn_taburcu.Text = "Taburcu";
            this.btn_taburcu.UseVisualStyleBackColor = false;
            this.btn_taburcu.Click += new System.EventHandler(this.btn_taburcu_Click);
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_yazdir.Location = new System.Drawing.Point(255, 417);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(75, 48);
            this.btn_yazdir.TabIndex = 1;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = false;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.GreenYellow;
            this.btnKaydet.Location = new System.Drawing.Point(351, 417);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 48);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Aqua;
            this.label14.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(484, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(227, 27);
            this.label14.TabIndex = 21;
            this.label14.Text = "Toplam Tutar:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_toplamtutar
            // 
            this.lbl_toplamtutar.AutoSize = true;
            this.lbl_toplamtutar.BackColor = System.Drawing.Color.Cyan;
            this.lbl_toplamtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamtutar.Location = new System.Drawing.Point(639, 392);
            this.lbl_toplamtutar.Name = "lbl_toplamtutar";
            this.lbl_toplamtutar.Size = new System.Drawing.Size(37, 16);
            this.lbl_toplamtutar.TabIndex = 22;
            this.lbl_toplamtutar.Text = "0 TL";
            // 
            // btnkullaniciformunagec
            // 
            this.btnkullaniciformunagec.BackColor = System.Drawing.Color.SlateBlue;
            this.btnkullaniciformunagec.Location = new System.Drawing.Point(578, 417);
            this.btnkullaniciformunagec.Name = "btnkullaniciformunagec";
            this.btnkullaniciformunagec.Size = new System.Drawing.Size(117, 48);
            this.btnkullaniciformunagec.TabIndex = 1;
            this.btnkullaniciformunagec.Text = "Yeni Kullanıcı Ekle";
            this.btnkullaniciformunagec.UseVisualStyleBackColor = false;
            this.btnkullaniciformunagec.Click += new System.EventHandler(this.btnkullaniciformunagec_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(455, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yeni Personel Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HastaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 477);
            this.Controls.Add(this.lbl_toplamtutar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnkullaniciformunagec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.btn_taburcu);
            this.Controls.Add(this.btn_secsil);
            this.Controls.Add(this.btn_yeni);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.nm_miktar);
            this.Controls.Add(this.txt_birimfiyat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_drkod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_yapilanislem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_sirano);
            this.Controls.Add(this.cmb_poliklinik);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HastaIslemleri";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaIslemleri";
            this.Load += new System.EventHandler(this.HastaIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvyapilanislemler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_hastaadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.DateTimePicker dt_sevktarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_bul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_hastabilgileri;
        private System.Windows.Forms.TextBox txt_dosyano;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_poliklinik;
        private System.Windows.Forms.TextBox txt_sirano;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_yapilanislem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_drkod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_birimfiyat;
        private System.Windows.Forms.NumericUpDown nm_miktar;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dgvyapilanislemler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_yeni;
        private System.Windows.Forms.Button btn_secsil;
        private System.Windows.Forms.Button btn_taburcu;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_toplamtutar;
        private System.Windows.Forms.Button btnkullaniciformunagec;
        private System.Windows.Forms.Button button1;
    }
}