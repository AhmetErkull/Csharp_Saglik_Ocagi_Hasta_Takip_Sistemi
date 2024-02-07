using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    public partial class KullaniciTanitma : Form
    {
        DatabaseManager databaseManager = DatabaseManager.Instance;
        dbKullanicilar dbkullanicilar = new dbKullanicilar();

        public KullaniciTanitma()
        {
            InitializeComponent();
        }

        private void btn_kullaniciekle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_kullaniciad.Text.Trim()) || string.IsNullOrEmpty(txt_sifre.Text.Trim()))
            {
                MessageBox.Show("boş alan olamaz");
            }
            else
            {
                dbkullanicilar.KullaniciKaydiGir(txt_kullaniciad.Text, txt_sifre.Text);
                this.Close();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_sifre.PasswordChar = '*';
            }
            else
            {
                txt_sifre.PasswordChar = '\0';
            }
        }
    }
}
