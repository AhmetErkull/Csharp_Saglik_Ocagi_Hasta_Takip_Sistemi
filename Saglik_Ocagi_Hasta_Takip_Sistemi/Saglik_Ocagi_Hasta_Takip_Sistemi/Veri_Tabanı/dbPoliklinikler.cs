using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    public class dbPoliklinikler:DatabaseManager
    {
        DatabaseManager databaseManager = DatabaseManager.Instance;
        public dbPoliklinikler() :base()
        {
            
        }

        public void PoliklinikKaydiGir(string poliklinikad)
        {
            try
            {
                con.Open();
                SqlCommand cmdekle = new SqlCommand(
                    "insert into Poliklinikler values (@poliklinikadi)", con);

                cmdekle.Parameters.AddWithValue("@poliklinikadi", poliklinikad);

                int result = cmdekle.ExecuteNonQuery();


                if (result > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Ekleme işlemi başarıyla gerçekleşmiştir.");
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
