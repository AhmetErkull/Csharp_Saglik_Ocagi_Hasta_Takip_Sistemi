using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Saglik_Ocagi_Hasta_Takip_Sistemi
{
    public class Yazdirma
    {
        public void Yazdir(string sirano, ArrayList yazilacaklar)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            Document hastarapor = new Document();


            PdfWriter.GetInstance(hastarapor, new FileStream(path + "Islem_" + sirano +".pdf", FileMode.Create));

            if (!hastarapor.IsOpen())
            {
                hastarapor.Open();
            }

            PdfPTable table = new PdfPTable(9);

            table.AddCell(new PdfPCell(new Phrase("Dosya Numarası")));
            table.AddCell(new PdfPCell(new Phrase("Poliklinik")));
            table.AddCell(new PdfPCell(new Phrase("Sıra No")));
            table.AddCell(new PdfPCell(new Phrase("Saat")));
            table.AddCell(new PdfPCell(new Phrase("Yapılan İşlem")));
            table.AddCell(new PdfPCell(new Phrase("Doktor Kodu")));
            table.AddCell(new PdfPCell(new Phrase("Miktar")));
            table.AddCell(new PdfPCell(new Phrase("Birim Fiyat")));
            table.AddCell(new PdfPCell(new Phrase("Taburcu Durumu")));

            table.CompleteRow();
            
            foreach (ArrayList yazilacaklarrow in yazilacaklar)
            {
                foreach (string yazilacaklarcell in yazilacaklarrow)
                {
                    table.AddCell(new PdfPCell(new Phrase(yazilacaklarcell)));
                }
                table.CompleteRow();

            }



            
            hastarapor.Add(table);

            hastarapor.Close();
            MessageBox.Show("Yazdırma işlemi başarılı");
        }
    }
}
