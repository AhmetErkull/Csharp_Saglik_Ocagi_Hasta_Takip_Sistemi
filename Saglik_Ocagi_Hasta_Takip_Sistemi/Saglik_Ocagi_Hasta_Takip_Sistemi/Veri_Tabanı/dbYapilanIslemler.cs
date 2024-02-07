using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iTextSharp.awt.geom.Point2D;
using System.Collections;

namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    public class dbYapilanIslemler:DatabaseManager
    {
        DatabaseManager databaseManager = DatabaseManager.Instance;
        public dbYapilanIslemler() : base()
        {
           
        }


        string fiyat;
        public string YapilanIslemeGoreFiyat(string islemad)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select birimfiyat from Islemler where islemad = '" + islemad + "'", con);
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                while (rd.Read())
                {
                    fiyat = rd[0].ToString();
                }

                return fiyat;


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), "Bağlandı sırasında hata oluştu");
            }
            finally
            {
                con.Close();
            }
            return fiyat;
        }

        public int MaxSiraNo()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(sirano) FROM YapilanIslemler", con);
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                while (rd.Read())
                {
                    return (int)rd[0] + 1;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), "Bağlandı sırasında hata oluştu");
            }
            finally
            {
                con.Close();
            }
            return -1;

        }

        public void yapilanislemKayitGir(ArrayList yapilanislemkaydi)
        {
            try
            {
                con.Open();


                SqlCommand cmdislemid = new SqlCommand("select islemid from Islemler where islemad=@islemad", con);
                cmdislemid.Parameters.AddWithValue("@islemad", yapilanislemkaydi[1]);
                object islemid = cmdislemid.ExecuteScalar();

                SqlCommand cmdyapilanislem = new SqlCommand("insert into YapilanIslemler(dosyano,islemid,drkodu,poliklinik,sirano,birimfiyat,miktar,tarih,kayitsaati,taburcusaati)" +
                                                            "values (@dosyano,@islemid,@drkodu,@poliklinik,@sirano,@birimfiyat,@miktar,@tarih,@kayitsaati,@taburcusaati)", con);



                cmdyapilanislem.Parameters.AddWithValue("@dosyano", yapilanislemkaydi[0]);
                cmdyapilanislem.Parameters.AddWithValue("@islemid", islemid.ToString());
                cmdyapilanislem.Parameters.AddWithValue("@drkodu", yapilanislemkaydi[2]);
                cmdyapilanislem.Parameters.AddWithValue("@poliklinik", yapilanislemkaydi[3]);
                cmdyapilanislem.Parameters.AddWithValue("@sirano", yapilanislemkaydi[4]);
                cmdyapilanislem.Parameters.AddWithValue("@birimfiyat", yapilanislemkaydi[5]);
                cmdyapilanislem.Parameters.AddWithValue("@miktar", yapilanislemkaydi[6]);
                cmdyapilanislem.Parameters.AddWithValue("@tarih", Convert.ToDateTime(yapilanislemkaydi[7]));

                TimeSpan kayitsaati = TimeSpan.Parse(yapilanislemkaydi[8].ToString());
                cmdyapilanislem.Parameters.AddWithValue("@kayitsaati", kayitsaati);

                if (yapilanislemkaydi[9] == null)
                {
                    cmdyapilanislem.Parameters.AddWithValue("@taburcusaati", DBNull.Value);
                }
                else
                {
                    TimeSpan taburcusaati = TimeSpan.Parse(yapilanislemkaydi[9].ToString());
                    cmdyapilanislem.Parameters.AddWithValue("@taburcusaati", taburcusaati);
                }



                int result = cmdyapilanislem.ExecuteNonQuery();

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
