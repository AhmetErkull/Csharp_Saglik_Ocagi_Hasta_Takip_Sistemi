using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    public class dbDoktorlar:DatabaseManager
    {
        DatabaseManager databaseManager = DatabaseManager.Instance;
        public dbDoktorlar():base()
        {
           
        }



        public void DoktorKaydiGir(Dictionary<string, string> kayitdic)
        {
            try
            {
                con.Open();
                SqlCommand cmdekle = new SqlCommand(
                    "insert into Doktorlar values (@drkodu,@doktorad,@doktorsoyad)", con);

                cmdekle.Parameters.AddWithValue("@drkodu", kayitdic["drkodu"]);
                cmdekle.Parameters.AddWithValue("@doktorad", kayitdic["doktorad"]);
                cmdekle.Parameters.AddWithValue("@doktorsoyad", kayitdic["doktorsoyad"]);
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
