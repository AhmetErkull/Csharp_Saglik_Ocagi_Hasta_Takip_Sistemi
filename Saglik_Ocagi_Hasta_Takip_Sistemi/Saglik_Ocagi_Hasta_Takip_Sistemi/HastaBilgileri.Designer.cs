namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    partial class HastaBilgileri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_baslangic = new System.Windows.Forms.DateTimePicker();
            this.dt_bitis = new System.Windows.Forms.DateTimePicker();
            this.rb_taburcu = new System.Windows.Forms.RadioButton();
            this.rb_taburcudegil = new System.Windows.Forms.RadioButton();
            this.rb_hepsi = new System.Windows.Forms.RadioButton();
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.dgvhastabilgileri = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_dosyano = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.dt_dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.dt_sevktarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhastabilgileri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // dt_baslangic
            // 
            this.dt_baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_baslangic.Location = new System.Drawing.Point(144, 25);
            this.dt_baslangic.Name = "dt_baslangic";
            this.dt_baslangic.Size = new System.Drawing.Size(112, 20);
            this.dt_baslangic.TabIndex = 1;
            // 
            // dt_bitis
            // 
            this.dt_bitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_bitis.Location = new System.Drawing.Point(144, 51);
            this.dt_bitis.Name = "dt_bitis";
            this.dt_bitis.Size = new System.Drawing.Size(112, 20);
            this.dt_bitis.TabIndex = 1;
            // 
            // rb_taburcu
            // 
            this.rb_taburcu.AutoSize = true;
            this.rb_taburcu.Location = new System.Drawing.Point(309, 7);
            this.rb_taburcu.Name = "rb_taburcu";
            this.rb_taburcu.Size = new System.Drawing.Size(95, 17);
            this.rb_taburcu.TabIndex = 2;
            this.rb_taburcu.Text = "Taburcu olmuş";
            this.rb_taburcu.UseVisualStyleBackColor = true;
            // 
            // rb_taburcudegil
            // 
            this.rb_taburcudegil.AutoSize = true;
            this.rb_taburcudegil.Location = new System.Drawing.Point(309, 31);
            this.rb_taburcudegil.Name = "rb_taburcudegil";
            this.rb_taburcudegil.Size = new System.Drawing.Size(105, 17);
            this.rb_taburcudegil.TabIndex = 2;
            this.rb_taburcudegil.Text = "Taburcu olmamış";
            this.rb_taburcudegil.UseVisualStyleBackColor = true;
            // 
            // rb_hepsi
            // 
            this.rb_hepsi.AutoSize = true;
            this.rb_hepsi.Checked = true;
            this.rb_hepsi.Location = new System.Drawing.Point(309, 54);
            this.rb_hepsi.Name = "rb_hepsi";
            this.rb_hepsi.Size = new System.Drawing.Size(52, 17);
            this.rb_hepsi.TabIndex = 2;
            this.rb_hepsi.TabStop = true;
            this.rb_hepsi.Text = "Hepsi";
            this.rb_hepsi.UseVisualStyleBackColor = true;
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.Location = new System.Drawing.Point(486, 12);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(160, 67);
            this.btn_sorgula.TabIndex = 3;
            this.btn_sorgula.Text = "Sorgula";
            this.btn_sorgula.UseVisualStyleBackColor = true;
            this.btn_sorgula.Click += new System.EventHandler(this.btn_sorgula_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(676, 12);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(168, 67);
            this.btn_temizle.TabIndex = 3;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // dgvhastabilgileri
            // 
            this.dgvhastabilgileri.AllowUserToAddRows = false;
            this.dgvhastabilgileri.AllowUserToDeleteRows = false;
            this.dgvhastabilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhastabilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhastabilgileri.Location = new System.Drawing.Point(3, 16);
            this.dgvhastabilgileri.Name = "dgvhastabilgileri";
            this.dgvhastabilgileri.Size = new System.Drawing.Size(868, 331);
            this.dgvhastabilgileri.TabIndex = 4;
            this.dgvhastabilgileri.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhastabilgileri_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvhastabilgileri);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 350);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(118, 150);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 69);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Seçilen Kaydı Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_dosyano
            // 
            this.txt_dosyano.Location = new System.Drawing.Point(12, 124);
            this.txt_dosyano.MaxLength = 4;
            this.txt_dosyano.Name = "txt_dosyano";
            this.txt_dosyano.Size = new System.Drawing.Size(100, 20);
            this.txt_dosyano.TabIndex = 6;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(118, 124);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 6;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(224, 124);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 6;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(528, 124);
            this.txt_telefon.MaxLength = 10;
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(100, 20);
            this.txt_telefon.TabIndex = 6;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(634, 124);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(137, 95);
            this.txt_adres.TabIndex = 6;
            // 
            // dt_dogumtarihi
            // 
            this.dt_dogumtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dogumtarihi.Location = new System.Drawing.Point(330, 124);
            this.dt_dogumtarihi.Name = "dt_dogumtarihi";
            this.dt_dogumtarihi.Size = new System.Drawing.Size(86, 20);
            this.dt_dogumtarihi.TabIndex = 7;
            // 
            // dt_sevktarihi
            // 
            this.dt_sevktarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_sevktarihi.Location = new System.Drawing.Point(777, 124);
            this.dt_sevktarihi.Name = "dt_sevktarihi";
            this.dt_sevktarihi.Size = new System.Drawing.Size(86, 20);
            this.dt_sevktarihi.TabIndex = 7;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(12, 150);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 69);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Kayıt Gir";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dosya No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hasta Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soyadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Doğum Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cinsiyet";
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(422, 123);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cmb_cinsiyet.TabIndex = 10;
            this.cmb_cinsiyet.Text = "Erkek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Adres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(783, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sevk Tarihi";
            // 
            // HastaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 575);
            this.Controls.Add(this.cmb_cinsiyet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dt_sevktarihi);
            this.Controls.Add(this.dt_dogumtarihi);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_dosyano);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sorgula);
            this.Controls.Add(this.rb_hepsi);
            this.Controls.Add(this.rb_taburcudegil);
            this.Controls.Add(this.rb_taburcu);
            this.Controls.Add(this.dt_bitis);
            this.Controls.Add(this.dt_baslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HastaBilgileri";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaBilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvhastabilgileri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_baslangic;
        private System.Windows.Forms.DateTimePicker dt_bitis;
        private System.Windows.Forms.RadioButton rb_taburcu;
        private System.Windows.Forms.RadioButton rb_taburcudegil;
        private System.Windows.Forms.RadioButton rb_hepsi;
        private System.Windows.Forms.Button btn_sorgula;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.DataGridView dgvhastabilgileri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_dosyano;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.DateTimePicker dt_dogumtarihi;
        private System.Windows.Forms.DateTimePicker dt_sevktarihi;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}