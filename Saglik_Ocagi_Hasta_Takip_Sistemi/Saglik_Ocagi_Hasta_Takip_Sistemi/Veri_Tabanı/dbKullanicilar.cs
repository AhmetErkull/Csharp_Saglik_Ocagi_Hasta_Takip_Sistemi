using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    public class dbKullanicilar:DatabaseManager
    {
        DatabaseManager databaseManager = DatabaseManager.Instance;
        public dbKullanicilar():base()
        {
            
        }

      


        public void KullaniciKaydiGir(string kullaniciadi, string sifre)
        {
            try
            {
                con.Open();
                SqlCommand cmdsorgula = new SqlCommand("select count(*) from Kullanicilar where kullaniciad='" + kullaniciadi + "'", con);
                int varmi = (int)cmdsorgula.ExecuteScalar();
                if (varmi > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Bu kullanıcı zaten var.");
                }
                else
                {
                    SqlCommand cmdekle = new SqlCommand(
                  "insert into Kullanicilar values (@kullaniciadi,@sifre)", con);

                    cmdekle.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                    cmdekle.Parameters.AddWithValue("@sifre", sifre);

                    int result = cmdekle.ExecuteNonQuery();


                    if (result > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Ekleme işlemi başarıyla gerçekleşmiştir.");
                    }
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), "Ekleme sırasında hata oluştu");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
