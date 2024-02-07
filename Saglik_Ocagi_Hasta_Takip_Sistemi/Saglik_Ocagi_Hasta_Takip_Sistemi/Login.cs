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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DatabaseManager databaseManager = DatabaseManager.Instance;
        private void btncikis_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkullanici.Text.Trim()) || string.IsNullOrEmpty(txtsifre.Text.Trim()))
            {
                MessageBox.Show("boş alan olamaz");
            }
            else
            {
                DataTable dt = databaseManager.ButunVerileriCek("Kullanicilar");
                object kad, sifre;
                bool girilebilir = false;

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        kad = item[1];
                        sifre = item[2];


                        if (kad != DBNull.Value)
                        {
                            if (kad.ToString() == txtkullanici.Text && sifre.ToString() == txtsifre.Text)
                            {
                                girilebilir = true;
                                break;
                            }
                        }
                    }


                }
                if (girilebilir)
                {
                    HastaIslemleri hastaIslemleri = new HastaIslemleri();
                    hastaIslemleri.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Kullanıcı adı veya şifre hatalı");}
            }
         


        }
    }
}
