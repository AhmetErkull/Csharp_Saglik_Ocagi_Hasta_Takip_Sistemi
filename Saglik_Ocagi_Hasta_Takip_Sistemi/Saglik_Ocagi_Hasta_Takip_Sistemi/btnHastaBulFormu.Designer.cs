namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    partial class btnHastaBulFormu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHastaBilgileri = new System.Windows.Forms.DataGridView();
            this.cmbsutunlar = new System.Windows.Forms.ComboBox();
            this.btn_hastaarat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_taburcu = new System.Windows.Forms.RadioButton();
            this.rb_taburcuolmamis = new System.Windows.Forms.RadioButton();
            this.rb_hepsi = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastaBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHastaBilgileri);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvHastaBilgileri
            // 
            this.dgvHastaBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHastaBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHastaBilgileri.Location = new System.Drawing.Point(3, 16);
            this.dgvHastaBilgileri.Name = "dgvHastaBilgileri";
            this.dgvHastaBilgileri.Size = new System.Drawing.Size(739, 227);
            this.dgvHastaBilgileri.TabIndex = 0;
            // 
            // cmbsutunlar
            // 
            this.cmbsutunlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsutunlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbsutunlar.FormattingEnabled = true;
            this.cmbsutunlar.Location = new System.Drawing.Point(108, 35);
            this.cmbsutunlar.Name = "cmbsutunlar";
            this.cmbsutunlar.Size = new System.Drawing.Size(145, 21);
            this.cmbsutunlar.TabIndex = 3;
            this.cmbsutunlar.SelectedIndexChanged += new System.EventHandler(this.cmbsutunlar_SelectedIndexChanged);
            // 
            // btn_hastaarat
            // 
            this.btn_hastaarat.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_hastaarat.Location = new System.Drawing.Point(513, 24);
            this.btn_hastaarat.Name = "btn_hastaarat";
            this.btn_hastaarat.Size = new System.Drawing.Size(216, 40);
            this.btn_hastaarat.TabIndex = 4;
            this.btn_hastaarat.Text = "Hasta Arat";
            this.btn_hastaarat.UseVisualStyleBackColor = false;
            this.btn_hastaarat.Click += new System.EventHandler(this.btn_hastaarat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arama Kriteri:";
            // 
            // rb_taburcu
            // 
            this.rb_taburcu.AutoSize = true;
            this.rb_taburcu.Location = new System.Drawing.Point(404, 12);
            this.rb_taburcu.Name = "rb_taburcu";
            this.rb_taburcu.Size = new System.Drawing.Size(65, 17);
            this.rb_taburcu.TabIndex = 6;
            this.rb_taburcu.Text = "Taburcu";
            this.rb_taburcu.UseVisualStyleBackColor = true;
            // 
            // rb_taburcuolmamis
            // 
            this.rb_taburcuolmamis.AutoSize = true;
            this.rb_taburcuolmamis.Location = new System.Drawing.Point(404, 34);
            this.rb_taburcuolmamis.Name = "rb_taburcuolmamis";
            this.rb_taburcuolmamis.Size = new System.Drawing.Size(105, 17);
            this.rb_taburcuolmamis.TabIndex = 6;
            this.rb_taburcuolmamis.Text = "Taburcu olmamış";
            this.rb_taburcuolmamis.UseVisualStyleBackColor = true;
            // 
            // rb_hepsi
            // 
            this.rb_hepsi.AutoSize = true;
            this.rb_hepsi.Checked = true;
            this.rb_hepsi.Location = new System.Drawing.Point(404, 57);
            this.rb_hepsi.Name = "rb_hepsi";
            this.rb_hepsi.Size = new System.Drawing.Size(52, 17);
            this.rb_hepsi.TabIndex = 6;
            this.rb_hepsi.TabStop = true;
            this.rb_hepsi.Text = "Hepsi";
            this.rb_hepsi.UseVisualStyleBackColor = true;
            // 
            // btnHastaBulFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(745, 329);
            this.Controls.Add(this.rb_hepsi);
            this.Controls.Add(this.rb_taburcuolmamis);
            this.Controls.Add(this.rb_taburcu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hastaarat);
            this.Controls.Add(this.cmbsutunlar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "btnHastaBulFormu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.btnHastaBulFormu_FormClosed);
            this.Load += new System.EventHandler(this.btnHastaBulFormu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastaBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHastaBilgileri;
        private System.Windows.Forms.ComboBox cmbsutunlar;
        private System.Windows.Forms.Button btn_hastaarat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_taburcu;
        private System.Windows.Forms.RadioButton rb_taburcuolmamis;
        private System.Windows.Forms.RadioButton rb_hepsi;
    }
}