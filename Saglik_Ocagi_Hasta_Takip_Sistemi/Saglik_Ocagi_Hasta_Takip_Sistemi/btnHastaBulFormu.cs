using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    public partial class btnHastaBulFormu : Form
    {
        DatabaseManager databaseManager = DatabaseManager.Instance;
        dbHastalar dbhastalar = new dbHastalar();
        public btnHastaBulFormu()
        {
            InitializeComponent();
        }

        private void btnHastaBulFormu_Load(object sender, EventArgs e)
        {
           
            ArrayList Sutunlar = dbhastalar.SutunIsımleriniCek();
            cmbsutunlar.Items.AddRange(Sutunlar.ToArray());
            cmbsutunlar.SelectedIndex = 0;
            
        }

        private void btnHastaBulFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataGridViewRow satir = dgvHastaBilgileri.CurrentRow;
            if (satir !=null)
            {
                databaseManager.DosyaNo = satir.Cells["dosyano"].Value.ToString();
                databaseManager.Ad = satir.Cells["ad"].Value.ToString();
                databaseManager.Soyad = satir.Cells["soyad"].Value.ToString();
                databaseManager.DogumTarihi = Convert.ToDateTime(satir.Cells["dogumtarihi"].Value);
                databaseManager.Cinsiyet = satir.Cells["cinsiyet"].Value.ToString();
                databaseManager.Telefon = satir.Cells["telefon"].Value.ToString();
                databaseManager.Adres = satir.Cells["adres"].Value.ToString();
                databaseManager.SevkTarihi = Convert.ToDateTime(satir.Cells["dogumtarihi"].Value);
            }

        }

        DateTimePicker dtp;
        TextBox txt;
        private void cmbsutunlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtp != null)
            {
                this.Controls.Remove(dtp);
                dtp.Dispose();
            }
            if (txt != null)
            {
                this.Controls.Remove(txt);
                txt.Dispose();
            }

            if (cmbsutunlar.SelectedItem.ToString() == "dogumtarihi"|| cmbsutunlar.SelectedItem.ToString() == "sevktarihi")
            {
                dtp = new DateTimePicker();
                dtp.Location = new Point(259, 36);
                dtp.Size = new Size(131, 20);
                dtp.Name = "dtp_"+ cmbsutunlar.SelectedItem.ToString(); 
                dtp.Format = DateTimePickerFormat.Short;
                
                this.Controls.Add(dtp);
            }
            else
            {

                txt = new TextBox();
                txt.Location = new Point(259, 36);
                txt.Size = new Size(131, 20);
                txt.Name = "txt_" + cmbsutunlar.SelectedItem.ToString();
                this.Controls.Add(txt);
            }

        }

        private void btn_hastaarat_Click(object sender, EventArgs e)
        {
            DateTimePicker dtpveri = (DateTimePicker)this.Controls.Find("dtp_"+ cmbsutunlar.SelectedItem.ToString(), false).FirstOrDefault();
            TextBox txtveri = this.Controls.Find("txt_" + cmbsutunlar.SelectedItem.ToString(), false).FirstOrDefault() as TextBox;

            if (cmbsutunlar.SelectedItem.ToString() == "dogumtarihi"|| cmbsutunlar.SelectedItem.ToString() == "sevktarihi")
            {
              dgvHastaBilgileri.DataSource = dbhastalar.CokluVeriCek(cmbsutunlar.Text,
                    dtpveri.Value.ToString("yyyy-MM-dd"),rb_hepsi.Checked? "0 or 1=1":(rb_taburcu.Checked?"1":"0"));
            }
            else
            {
                dgvHastaBilgileri.DataSource = dbhastalar.CokluVeriCek(cmbsutunlar.Text, 
                    txtveri.Text, rb_hepsi.Checked ? "0 or 1=1" : (rb_taburcu.Checked ? "1" : "0"));
            }
        }
    }
}
