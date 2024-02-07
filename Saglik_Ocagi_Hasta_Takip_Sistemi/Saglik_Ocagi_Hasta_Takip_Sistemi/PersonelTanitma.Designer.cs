namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    partial class PersonelTanitma
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
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtgorev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.dgvpersoneller = new System.Windows.Forms.DataGridView();
            this.btnkayitsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(17, 47);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 0;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(149, 47);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 0;
            // 
            // txtgorev
            // 
            this.txtgorev.Location = new System.Drawing.Point(273, 47);
            this.txtgorev.Name = "txtgorev";
            this.txtgorev.Size = new System.Drawing.Size(100, 20);
            this.txtgorev.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personel Gorev";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(402, 45);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // dgvpersoneller
            // 
            this.dgvpersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersoneller.Location = new System.Drawing.Point(17, 118);
            this.dgvpersoneller.Name = "dgvpersoneller";
            this.dgvpersoneller.Size = new System.Drawing.Size(460, 150);
            this.dgvpersoneller.TabIndex = 3;
            this.dgvpersoneller.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersoneller_CellValueChanged);
            // 
            // btnkayitsil
            // 
            this.btnkayitsil.Location = new System.Drawing.Point(402, 274);
            this.btnkayitsil.Name = "btnkayitsil";
            this.btnkayitsil.Size = new System.Drawing.Size(75, 23);
            this.btnkayitsil.TabIndex = 2;
            this.btnkayitsil.Text = "Seçili Kaydı Sil";
            this.btnkayitsil.UseVisualStyleBackColor = true;
            this.btnkayitsil.Click += new System.EventHandler(this.btnkayitsil_Click);
            // 
            // PersonelTanitma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 307);
            this.Controls.Add(this.dgvpersoneller);
            this.Controls.Add(this.btnkayitsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgorev);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelTanitma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PersonelTanitma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersoneller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtgorev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dgvpersoneller;
        private System.Windows.Forms.Button btnkayitsil;
    }
}