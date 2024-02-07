using Saglik_Ocagi_Hasta_Takip_Sistemi.Veri_Tabanı;
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
    public partial class PersonelTanitma : Form
    {
        public PersonelTanitma()
        {
            InitializeComponent();
        }
        dbPersoneller dbpersoneller = new dbPersoneller();
        DatabaseManager databaseManager = DatabaseManager.Instance;

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtad.Text)|| string.IsNullOrWhiteSpace(txtsoyad.Text) || string.IsNullOrWhiteSpace(txtgorev.Text) )
            {
                MessageBox.Show("Boş alan olamaz");
            }
            else
            {
                dbpersoneller.PersonelKaydiGir(txtad.Text, txtsoyad.Text, txtgorev.Text);
                dgvpersoneller.DataSource = dbpersoneller.ButunVerileriCek("Personeller");
                textboxtemizle();
            }
            
        }

        private void PersonelTanitma_Load(object sender, EventArgs e)
        {
            dgvpersoneller.DataSource = dbpersoneller.ButunVerileriCek("Personeller");
        }

        private void dgvpersoneller_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string id = dgvpersoneller.Rows[e.RowIndex].Cells[0].Value.ToString();
                string deger = dgvpersoneller.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string sutun = dgvpersoneller.Columns[e.ColumnIndex].Name;
                databaseManager.KayitGuncelle("Personeller", sutun, deger, "personelid", id);
            }
        }

        private void btnkayitsil_Click(object sender, EventArgs e)
        {

            if (dgvpersoneller.SelectedCells.Count > 0)
            {
                int selectedrow = dgvpersoneller.SelectedCells[0].RowIndex;
                string id = dgvpersoneller.Rows[selectedrow].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "Personel Kayıt Silme", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgvpersoneller.Rows.RemoveAt(selectedrow);
                    databaseManager.KaydiSil("Personeller", "personelid", id);
                }
            }
        }
        void textboxtemizle()
        {
            txtad.Clear();
            txtsoyad.Clear();
            txtgorev.Clear();
        }
    }
}
