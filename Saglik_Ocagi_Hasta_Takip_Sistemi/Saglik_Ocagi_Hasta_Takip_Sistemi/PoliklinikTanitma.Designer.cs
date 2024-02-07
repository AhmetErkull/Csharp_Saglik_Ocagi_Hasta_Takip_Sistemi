namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    partial class PoliklinikTanitma
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
            this.dgv_poliklinikler = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.btn_kayitgir = new System.Windows.Forms.Button();
            this.txtpoliklinikadi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_poliklinikler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_poliklinikler);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 155);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // dgv_poliklinikler
            // 
            this.dgv_poliklinikler.AllowUserToAddRows = false;
            this.dgv_poliklinikler.AllowUserToDeleteRows = false;
            this.dgv_poliklinikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_poliklinikler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_poliklinikler.Location = new System.Drawing.Point(3, 16);
            this.dgv_poliklinikler.Name = "dgv_poliklinikler";
            this.dgv_poliklinikler.Size = new System.Drawing.Size(279, 136);
            this.dgv_poliklinikler.TabIndex = 0;
            this.dgv_poliklinikler.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_poliklinikler_CellValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "POLİKLİNİK TANITMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Poliklinik Adı";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.LightCoral;
            this.btnsil.Location = new System.Drawing.Point(12, 102);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(261, 37);
            this.btnsil.TabIndex = 12;
            this.btnsil.Text = "Seçili Kaydı Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click_1);
            // 
            // btn_kayitgir
            // 
            this.btn_kayitgir.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_kayitgir.Location = new System.Drawing.Point(125, 48);
            this.btn_kayitgir.Name = "btn_kayitgir";
            this.btn_kayitgir.Size = new System.Drawing.Size(148, 37);
            this.btn_kayitgir.TabIndex = 13;
            this.btn_kayitgir.Text = "Kayıt Gir";
            this.btn_kayitgir.UseVisualStyleBackColor = false;
            this.btn_kayitgir.Click += new System.EventHandler(this.btn_kayitgir_Click);
            // 
            // txtpoliklinikadi
            // 
            this.txtpoliklinikadi.Enabled = false;
            this.txtpoliklinikadi.Location = new System.Drawing.Point(19, 57);
            this.txtpoliklinikadi.Name = "txtpoliklinikadi";
            this.txtpoliklinikadi.Size = new System.Drawing.Size(100, 20);
            this.txtpoliklinikadi.TabIndex = 5;
            // 
            // PoliklinikTanitma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btn_kayitgir);
            this.Controls.Add(this.txtpoliklinikadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PoliklinikTanitma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PoliklinikTanitma_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_poliklinikler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_poliklinikler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btn_kayitgir;
        private System.Windows.Forms.TextBox txtpoliklinikadi;
    }
}