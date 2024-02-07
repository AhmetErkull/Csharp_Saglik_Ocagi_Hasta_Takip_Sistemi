using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saglik_Ocagi_Hasta_Takip_Sistemi.Veri_Tabanı
{
    public class dbPersoneller:DatabaseManager
    {

        DatabaseManager databaseManager = DatabaseManager.Instance;
        public dbPersoneller() : base()
        {

        }


        public void PersonelKaydiGir(string personelad,string personelsoyad, string personelgorev)
        {
            try
            {
                con.Open();
                SqlCommand cmdsorgula = new SqlCommand("select count(*) from Personeller where personelad='" + personelad + "'", con);
                int varmi = (int)cmdsorgula.ExecuteScalar();
                if (varmi > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Bu kullanıcı zaten var.");
                }
                else
                {
                    SqlCommand cmdekle = new SqlCommand(
                  "insert into Personeller values (@personelad,@personelsoyad,@personelgorev)", con);

                    cmdekle.Parameters.AddWithValue("@personelad", personelad);
                    cmdekle.Parameters.AddWithValue("@personelsoyad", personelsoyad);
                    cmdekle.Parameters.AddWithValue("@personelgorev", personelgorev);

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
