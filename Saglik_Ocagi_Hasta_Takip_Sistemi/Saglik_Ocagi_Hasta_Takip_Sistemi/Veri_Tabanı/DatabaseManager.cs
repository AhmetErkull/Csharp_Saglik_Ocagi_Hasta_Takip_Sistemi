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
    public class DatabaseManager
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

        protected DatabaseManager()
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


        protected static SqlConnection con;

       /*  public void DosyaNumarasinaGoreCek(string val)
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
        }*/

        /*public DataTable CokluVeriCek(string sutunAdi, string deger,string taburcudurumu,bool aralik = false)
        {
            DataTable dataTable = new DataTable();

                try
                {
                    con.Open();
                if (!aralik)
                {
                    deger = "='"+deger+"'";
                }

                    SqlCommand cmd = new SqlCommand($"SELECT h.dosyano,h.ad,h.soyad,h.dogumtarihi,h.cinsiyet,h.telefon,h.adres, h.sevktarihi " +
                                                    $"FROM HastaBilgileri h" +
                                                    $" WHERE h." +sutunAdi+deger+" and (taburcudurumu="+taburcudurumu+")", con);

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
            

        }*/

        /*public ArrayList SutunIsımleriniCek()
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
        }*/

        public ArrayList cmbListesiCek(string tabloadi,string sutunadi)
        {
            ArrayList tablo = new ArrayList();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from "+ tabloadi , con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tablo.Add(rd[sutunadi].ToString());
                }
                return tablo;


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), "Bağlandı sırasında hata oluştu");
            }
            finally
            {
                con.Close();
            }
            return tablo;
        }

        //string fiyat;
        /*public string YapilanIslemeGoreFiyat(string islemad)
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
        }*/

        /*public int MaxSiraNo()
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

        }*/


        /*public void yapilanislemKayitGir(ArrayList yapilanislemkaydi)
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
        }*/

        public void KayitGuncelle(string tablo,string sutunadi,string deger,string degistirileceksutun,string yenideger)
        {
            try
            {
                con.Open();
                SqlCommand cmdguncelleme = 
                    new SqlCommand("Update "+ tablo +" set "+sutunadi+"='"+deger+"' where "+degistirileceksutun+"='"+ yenideger + "'",con);

                int result = cmdguncelleme.ExecuteNonQuery();

                if (result > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşmiştir.");
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), "Güncelleme sırasında hata oluştu");
            }
            finally
            {
                con.Close();
            }
        }

        public void KaydiSil(string tablo, string sutun, string deger)
        {
            try
            {
                con.Open();
                SqlCommand cmdsil =
                    new SqlCommand("Delete from "+tablo+" where "+sutun+" = '"+deger+"'", con);

                int result = cmdsil.ExecuteNonQuery();

                if (result > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Silme işlemi başarıyla gerçekleşmiştir.");
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), "Silme sırasında hata oluştu");
            }
            finally
            {
                con.Close();
            }
        }

        /*public void HastaKaydiGir(Dictionary<string,string> kayitdic)
        {
            try
            {
                con.Open();
                SqlCommand cmdekle = new SqlCommand(
                    "INSERT INTO HastaBilgileri VALUES " +
                    "(@dosyano, @ad, @soyad, @dogumtarihi, @cinsiyet, @telefon, @adres, 'False', @sevktarihi)", con);

                cmdekle.Parameters.AddWithValue("@dosyano", kayitdic["dosyano"]);
                cmdekle.Parameters.AddWithValue("@ad", kayitdic["ad"]);
                cmdekle.Parameters.AddWithValue("@soyad", kayitdic["soyad"]);
                cmdekle.Parameters.AddWithValue("@dogumtarihi",Convert.ToDateTime(kayitdic["dogumtarihi"]));
                cmdekle.Parameters.AddWithValue("@cinsiyet", kayitdic["cinsiyet"]);
                cmdekle.Parameters.AddWithValue("@telefon", kayitdic["telefon"]);
                cmdekle.Parameters.AddWithValue("@adres", kayitdic["adres"]);
                cmdekle.Parameters.AddWithValue("@sevktarihi", Convert.ToDateTime(kayitdic["sevktarihi"]));

                int result = cmdekle.ExecuteNonQuery();

                if (result > 0)
                {
                    System.Windows.Forms.MessageBox.Show("Ekleme işlemi başarıyla gerçekleşmiştir.");
                }
                else
                {

                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // primary key ile çakışıyorsa
                {
                    System.Windows.Forms.MessageBox.Show("Böyle bir Doktor Kodu zaten bulunmakta.");
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

        }*/

        /*public void DoktorKaydiGir(Dictionary<string, string> kayitdic)
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

        }*/

        /*public void PoliklinikKaydiGir(string poliklinikad)
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
        }*/

        /*public void KullaniciKaydiGir(string kullaniciadi,string sifre)
        {
            try
            {
                con.Open();
                SqlCommand cmdsorgula = new SqlCommand("select count(*) from Kullanicilar where kullaniciad='"+kullaniciadi+"'",con);
                int varmi = (int)cmdsorgula.ExecuteScalar();
                if (varmi>0)
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
        }*/

        public DataTable ButunVerileriCek(string tabloadi)
        {
            DataTable dt = new DataTable(tabloadi);
                try
                 {
                con.Open();
                SqlCommand cmdcek = new SqlCommand(
                    "select * from "+tabloadi, con);

                SqlDataAdapter da = new SqlDataAdapter(cmdcek);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), "Veri çekme sırasında hata oluştu");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }



    }
}
