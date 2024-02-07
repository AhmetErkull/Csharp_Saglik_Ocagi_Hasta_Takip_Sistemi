using System;
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
    public partial class DoktorTanitma : Form
    {
        public DoktorTanitma(string drkodu)
        {
            InitializeComponent();
            txtkodu.Text =  drkodu.ToUpper();
        }

        DatabaseManager databaseManager = DatabaseManager.Instance;
        dbDoktorlar dbdoktorlar = new dbDoktorlar();

        public bool TextboxKontrol()
        {
            if (string.IsNullOrWhiteSpace(txtkodu.Text) || string.IsNullOrWhiteSpace(txtad.Text) || string.IsNullOrWhiteSpace(txtsoyad.Text))
            {
                MessageBox.Show("Boş alanlar mevcut. Lütfen bütün alanları doldurun.");
                return false;
            }
            return true;
           
        }

        private void DoktorKaydiGir_Load(object sender, EventArgs e)
        {
            dgv_doktorlar.DataSource= databaseManager.ButunVerileriCek("Doktorlar");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            if (dgv_doktorlar.SelectedCells.Count>0)
            {
                int selectedrow = dgv_doktorlar.SelectedCells[0].RowIndex;
                string drkodu = dgv_doktorlar.Rows[selectedrow].Cells[0].Value.ToString();
                DialogResult result=  MessageBox.Show("Silmek istediğinize emin misiniz?","Doktor Kayıd Silme",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgv_doktorlar.Rows.RemoveAt(selectedrow);
                    databaseManager.KaydiSil("Doktorlar","drkodu",drkodu);
                }
            }
        }

        private void dgv_doktorlar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string drkodu = dgv_doktorlar.Rows[e.RowIndex].Cells[0].Value.ToString();
                string deger = dgv_doktorlar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string sutun = dgv_doktorlar.Columns[e.ColumnIndex].Name;
                databaseManager.KayitGuncelle("Doktorlar",sutun, deger,"drkodu", drkodu);
            }
        }

        private void btnkayitgir_Click(object sender, EventArgs e)
        {
            if (TextboxKontrol())
            {
                dbdoktorlar.DoktorKaydiGir(new Dictionary<string, string>() { { "drkodu", txtkodu.Text }, { "doktorad", txtad.Text }, { "doktorsoyad", txtsoyad.Text } });
                this.Close();
            }
        }
    }
}
