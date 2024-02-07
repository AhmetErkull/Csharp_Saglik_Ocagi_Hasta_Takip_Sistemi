using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    class DatabaseManager
    {

        private static DatabaseManager instance;

        private static string connectionstring = "Data Source=DESKTOP-UOAQUAS;Initial Catalog=SaglikOcagi;Integrated Security=True";

        public string DosyaNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public DateTime SevkTarihi { get; set; }

        private DatabaseManager()
        {
            SevkTarihi = DateTime.Now;
        }

        public static DatabaseManager Instance
        {

            get {
                if (instance ==null)
                {
                    con = new SqlConnection(connectionstring);
                    instance = new DatabaseManager();
                }
                return instance; 
            }
        }


        private static SqlConnection con;

        public void DosyaNumarasinaGoreCek(string val)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select h.dosyano,h.ad,h.soyad,h.dogumtarihi,h.cinsiyet,h.telefon,h.adres,h.sevktarihi " +
                    "from HastaBilgileri h where h.dosyano='" + val+"'", con);

                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (!rd.HasRows)
                {
                    System.Windows.Forms.MessageBox.Show("Böyle bir kayıt yok!");
                    return;
                }
                else
                {
                    while (rd.Read())
                    {
                        DosyaNo = rd[0].ToString();
                        Ad = rd[1].ToString();
                        Soyad = rd[2].ToString();
                        DogumTarihi = Convert.ToDateTime(rd[3]);
                        Cinsiyet = rd[4].ToString();
                        Telefon = rd[5].ToString();
                        Adres = rd[6].ToString();
                        if (rd[7] != DBNull.Value)
                        {
                            SevkTarihi = Convert.ToDateTime(rd[7]);
                        }
                        else
                        {
                            SevkTarihi = DateTime.Now;
                        }
                    }
   
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(),"Bağlandı sırasında hata oluştu");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable CokluVeriCek(string sutunAdi, string deger,string taburcudurumu)
        {
            DataTable dataTable = new DataTable();

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT h.dosyano,h.ad,h.soyad,h.dogumtarihi,h.cinsiyet,h.telefon,h.adres, h.sevktarihi " +
                                                    $"FROM HastaBilgileri h" +
                                                    $" WHERE h." +sutunAdi+" = '"+deger+"' and (taburcudurumu="+taburcudurumu+")", con);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), "Bağlandı sırasında hata oluştu");
                }
                finally
                {
                    con.Close();
                }
            return dataTable;
            

        }

        public ArrayList SutunIsımleriniCek()
        {
            ArrayList Sutunlar = new ArrayList();

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select h.ad,h.soyad,h.dogumtarihi,h.cinsiyet,h.telefon,h.adres,h.sevktarihi " +
                                                "from HastaBilgileri h", con);
                SqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.SchemaOnly);
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    Sutunlar.Add(rd.GetName(i));
                }
                return Sutunlar;


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), "Bağlandı sırasında hata oluştu");
            }
            finally
            {
                con.Close();
            }
            return Sutunlar;
        }

        public ArrayList cmbListesiCek(string tabloadi,string sutunadi)
        {
            ArrayList poliklinikler = new ArrayList();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from "+ tabloadi , con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    poliklinikler.Add(rd[sutunadi].ToString());
                }
                return poliklinikler;


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), "Bağlandı sırasında hata oluştu");
            }
            finally
            {
                con.Close();
            }
            return poliklinikler;
        }

        string fiyat;
        public string YapilanIslemeGoreFiyat(string islemad)
        {
           
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select birimfiyat from Islemler where islemad = '"+ islemad + "'", con);
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.SingleResult);
                while (rd.Read())
                {
                   fiyat= rd[0].ToString();
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


        public void KayitGir(ArrayList yapilanislemkaydi)
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
                    cmdyapilanislem.Parameters.AddWithValue("@taburcusaati",taburcusaati);
                }



                int result = cmdyapilanislem.ExecuteNonQuery();

                if (result>0)
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
