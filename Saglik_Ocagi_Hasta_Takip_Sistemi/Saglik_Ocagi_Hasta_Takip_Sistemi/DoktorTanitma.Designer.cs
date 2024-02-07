namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    partial class DoktorTanitma
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
            this.txtkodu = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.btnkayitgir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_doktorlar = new System.Windows.Forms.DataGridView();
            this.btnsil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtkodu
            // 
            this.txtkodu.Enabled = false;
            this.txtkodu.Location = new System.Drawing.Point(40, 62);
            this.txtkodu.Name = "txtkodu";
            this.txtkodu.Size = new System.Drawing.Size(100, 20);
            this.txtkodu.TabIndex = 0;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(155, 62);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 1;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(272, 62);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 2;
            // 
            // btnkayitgir
            // 
            this.btnkayitgir.BackColor = System.Drawing.Color.LightSalmon;
            this.btnkayitgir.Location = new System.Drawing.Point(389, 46);
            this.btnkayitgir.Name = "btnkayitgir";
            this.btnkayitgir.Size = new System.Drawing.Size(75, 37);
            this.btnkayitgir.TabIndex = 3;
            this.btnkayitgir.Text = "Kayıt Gir";
            this.btnkayitgir.UseVisualStyleBackColor = false;
            this.btnkayitgir.Click += new System.EventHandler(this.btnkayitgir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doktor Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doktor Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doktor Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOKTOR TANITMA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_doktorlar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dgv_doktorlar
            // 
            this.dgv_doktorlar.AllowUserToAddRows = false;
            this.dgv_doktorlar.AllowUserToDeleteRows = false;
            this.dgv_doktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_doktorlar.Location = new System.Drawing.Point(3, 16);
            this.dgv_doktorlar.Name = "dgv_doktorlar";
            this.dgv_doktorlar.Size = new System.Drawing.Size(482, 136);
            this.dgv_doktorlar.TabIndex = 0;
            this.dgv_doktorlar.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_doktorlar_CellValueChanged);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.LightCoral;
            this.btnsil.Location = new System.Drawing.Point(12, 103);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 37);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "Seçili Kaydı Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // DoktorKaydiGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(488, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkayitgir);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtkodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoktorKaydiGir";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DoktorKaydiGir_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkodu;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Button btnkayitgir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_doktorlar;
        private System.Windows.Forms.Button btnsil;
    }
}