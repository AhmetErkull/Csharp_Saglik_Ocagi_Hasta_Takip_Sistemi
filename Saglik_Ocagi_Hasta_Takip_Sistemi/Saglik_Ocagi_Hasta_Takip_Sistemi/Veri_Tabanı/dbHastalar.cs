using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    public class dbHastalar:DatabaseManager
    {
        DatabaseManager databaseManager = DatabaseManager.Instance;
        public dbHastalar() : base()
        {
            
        }

        public void DosyaNumarasinaGoreCek(string val)
        {
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select h.dosyano,h.ad,h.soyad,h.dogumtarihi,h.cinsiyet,h.telefon,h.adres,h.sevktarihi " +
                    "from HastaBilgileri h where h.dosyano='" + val + "'", con);

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
                        databaseManager.DosyaNo = rd[0].ToString();
                        databaseManager.Ad = rd[1].ToString();
                        databaseManager.Soyad = rd[2].ToString();
                        databaseManager.DogumTarihi = Convert.ToDateTime(rd[3]);
                        databaseManager.Cinsiyet = rd[4].ToString();
                        databaseManager.Telefon = rd[5].ToString();
                        databaseManager.Adres = rd[6].ToString();
                        if (rd[7] != DBNull.Value)
                        {
                            databaseManager.SevkTarihi = Convert.ToDateTime(rd[7]);
                        }
                        else
                        {
                            databaseManager.SevkTarihi = DateTime.Now;
                        }
                    }

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
        }

        public DataTable CokluVeriCek(string sutunAdi, string deger, string taburcudurumu, bool aralik = false)
        {
            DataTable dataTable = new DataTable();

            try
            {
                con.Open();
                if (!aralik)
                {
                    deger = "='" + deger + "'";
                }

                SqlCommand cmd = new SqlCommand($"SELECT h.dosyano,h.ad,h.soyad,h.dogumtarihi,h.cinsiyet,h.telefon,h.adres, h.sevktarihi " +
                                                $"FROM HastaBilgileri h" +
                                                $" WHERE h." + sutunAdi + deger + " and (taburcudurumu=" + taburcudurumu + ")", con);

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

        public void HastaKaydiGir(Dictionary<string, string> kayitdic)
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
                cmdekle.Parameters.AddWithValue("@dogumtarihi", Convert.ToDateTime(kayitdic["dogumtarihi"]));
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

        }

    }
}
