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

namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    public partial class HastaBilgileri : Form
    {
        DatabaseManager databaseManager = DatabaseManager.Instance;
        dbHastalar dbhastalar = new dbHastalar();
        public HastaBilgileri()
        {
            InitializeComponent();
        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            string deger = ">='" + dt_baslangic.Value.ToString("yyyy-MM-dd")+ 
                "' and h.sevktarihi <='" + dt_bitis.Value.ToString("yyyy-MM-dd")+ "'";
            dgvhastabilgileri.DataSource = dbhastalar.CokluVeriCek("sevktarihi",deger, rb_hepsi.Checked ? "0 or 1=1" : (rb_taburcu.Checked ? "1" : "0"),true);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            dgvhastabilgileri.DataSource = null;
            dgvhastabilgileri.Update();
            dgvhastabilgileri.Refresh();
        }

        private void dgvhastabilgileri_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0&&e.ColumnIndex >=0)
            {
                string dosyano = dgvhastabilgileri.Rows[e.RowIndex].Cells[0].Value.ToString();
                string deger = dgvhastabilgileri.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string sutun = dgvhastabilgileri.Columns[e.ColumnIndex].Name;
                databaseManager.KayitGuncelle("HastaBilgileri",sutun,deger,"dosyano",dosyano);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgvhastabilgileri.SelectedCells.Count > 0)
            {
                int rowIndex = dgvhastabilgileri.SelectedCells[0].RowIndex;
                string dosyano = dgvhastabilgileri.Rows[rowIndex].Cells[0].Value.ToString();

               

                DialogResult result = MessageBox.Show(
                    "Seçili satırı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvhastabilgileri.Rows.RemoveAt(rowIndex);
                    databaseManager.KaydiSil("HastaBilgileri", "dosyano", dosyano);
                }
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_dosyano.Text)|| string.IsNullOrWhiteSpace(txt_ad.Text)|| 
                string.IsNullOrWhiteSpace(txt_soyad.Text) || string.IsNullOrWhiteSpace(dt_dogumtarihi.Text) ||
                string.IsNullOrWhiteSpace(cmb_cinsiyet.Text) || string.IsNullOrWhiteSpace(txt_telefon.Text) ||
                string.IsNullOrWhiteSpace(txt_adres.Text) || string.IsNullOrWhiteSpace(dt_sevktarihi.Text))
            {
                MessageBox.Show("Boş alan kalmamalı!");
            }
            else if (txt_telefon.Text.Length<10)
            {
                MessageBox.Show("Telefon alanı 10 karakter olmalıdır.");
            }
            else if (txt_dosyano.Text.Length<4)
            {
                MessageBox.Show("Dosya numarası 4 karakterli olmalı.");
            }
            else if (!int.TryParse(txt_dosyano.Text,out _))
            {
                MessageBox.Show("Dosya numarası sayısal olmalı.");
            }
            else if (!long.TryParse(txt_telefon.Text, out _))
            {
                MessageBox.Show("Telefon numarası sayısal olmalı.");
            }
            else
            {
                Dictionary<string,string> kayitdic = new Dictionary<string,string>();
                kayitdic.Add("dosyano", txt_dosyano.Text);
                kayitdic.Add("ad", txt_ad.Text);
                kayitdic.Add("soyad", txt_soyad.Text);
                kayitdic.Add("dogumtarihi",dt_dogumtarihi.Text);
                kayitdic.Add("cinsiyet",cmb_cinsiyet.Text);
                kayitdic.Add("telefon",txt_telefon.Text);
                kayitdic.Add("adres",txt_adres.Text);
                kayitdic.Add("sevktarihi",dt_sevktarihi.Text);
                dbhastalar.HastaKaydiGir(kayitdic);
            }
            btn_sorgula_Click(sender,e);
        }
    }
}
