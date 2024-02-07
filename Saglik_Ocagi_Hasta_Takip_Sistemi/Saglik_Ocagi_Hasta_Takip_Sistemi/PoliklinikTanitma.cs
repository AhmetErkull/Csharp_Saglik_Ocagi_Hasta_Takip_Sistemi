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
    public partial class PoliklinikTanitma : Form
    {
        public PoliklinikTanitma(string poliklinikadi)
        {
            InitializeComponent();
            txtpoliklinikadi.Text = poliklinikadi;
        }

        DatabaseManager databaseManager = DatabaseManager.Instance;
        dbPoliklinikler dbpoliklinikler = new dbPoliklinikler();


        private void DoktorKaydiGir_Load(object sender, EventArgs e)
        {
            dgv_poliklinikler.DataSource = databaseManager.ButunVerileriCek("Poliklinikler");
        }


        private void dgv_poliklinikler_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string drkodu = dgv_poliklinikler.Rows[e.RowIndex].Cells[0].Value.ToString();
                string deger = dgv_poliklinikler.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string sutun = dgv_poliklinikler.Columns[e.ColumnIndex].Name;
                databaseManager.KayitGuncelle("Poliklinikler", sutun, deger, "poliklinikad", txtpoliklinikadi.Text);
            }
        }

        private void PoliklinikTanitma_Load(object sender, EventArgs e)
        {
            dgv_poliklinikler.DataSource = databaseManager.ButunVerileriCek("Poliklinikler");
        }

        private void btn_kayitgir_Click(object sender, EventArgs e)
        {
            dbpoliklinikler.PoliklinikKaydiGir(txtpoliklinikadi.Text);
            this.Close();
        }

        private void btnsil_Click_1(object sender, EventArgs e)
        {

            if (dgv_poliklinikler.SelectedCells.Count > 0)
            {
                int selectedrow = dgv_poliklinikler.SelectedCells[0].RowIndex;
                string poliklinikid = dgv_poliklinikler.Rows[selectedrow].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Poliklinik Kaydı Silme", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgv_poliklinikler.Rows.RemoveAt(selectedrow);
                    databaseManager.KaydiSil("Poliklinikler", "poliklinikid", poliklinikid);
                }
            }
        }
    }
}
