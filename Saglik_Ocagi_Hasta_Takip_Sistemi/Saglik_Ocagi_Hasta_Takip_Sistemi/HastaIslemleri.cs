using System;
using System.Collections;
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
    public partial class HastaIslemleri : Form
    {
        DatabaseManager databaseManager = DatabaseManager.Instance;
        dbHastalar dbhastalar = new dbHastalar();
        dbYapilanIslemler dbyapilanislemler = new dbYapilanIslemler();
        public HastaIslemleri()
        {
            InitializeComponent();
        }

        private void txt_dosyano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dbhastalar.DosyaNumarasinaGoreCek(txt_dosyano.Text);
                hastaBilgileriniDoldur();
            }

        }

        private void hastaBilgileriniDoldur()
        {
            txt_dosyano.Text = databaseManager.DosyaNo;
            txt_hastaadi.Text = databaseManager.Ad;
            txt_soyadi.Text = databaseManager.Soyad;
            dt_sevktarihi.Value = databaseManager.SevkTarihi;
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            btnHastaBulFormu btnHastaBulFormu = new btnHastaBulFormu();
            btnHastaBulFormu.Show();
            this.Enabled = false;
            btnHastaBulFormu.FormClosed += new FormClosedEventHandler(this.btnHastaBulFormu_FormClosed);
        }

        public void btnHastaBulFormu_FormClosed(object sender, EventArgs e)
        {
            this.Enabled = true;
            hastaBilgileriniDoldur();
        }

        private void HastaIslemleri_Load(object sender, EventArgs e)
        {
            txtboxTemizle();
            cmbPoliklinikleriDoldur();
            txt_sirano.Text = dbyapilanislemler.MaxSiraNo().ToString();
            cmb_yapilanislemleriDoldur();
            cmbDrkodudoldur();
            txtFiyatiDoldur();
        }

        private void txtboxTemizle()
        {
            txt_dosyano.Clear();
            txt_hastaadi.Clear();
            txt_soyadi.Clear();
        }

        private void txtFiyatiDoldur()
        {
            txt_birimfiyat.Text = dbyapilanislemler.YapilanIslemeGoreFiyat(cmb_yapilanislem.Text);
        }

        private void cmb_yapilanislemleriDoldur()
        {

            cmb_yapilanislem.Items.AddRange(databaseManager.cmbListesiCek("Islemler", "islemad").ToArray());
            cmb_yapilanislem.SelectedIndex = 0;
        }

        private void cmbDrkodudoldur()
        {
            cmb_drkod.Items.Clear();
            cmb_drkod.Items.AddRange(databaseManager.cmbListesiCek("Doktorlar", "drkodu").ToArray());
            cmb_drkod.SelectedIndex = 0;
        }

        private void cmbPoliklinikleriDoldur()
        {
            cmb_poliklinik.Items.Clear();
            cmb_poliklinik.Items.AddRange(databaseManager.cmbListesiCek("Poliklinikler", "poliklinikad").ToArray());
            cmb_poliklinik.SelectedIndex = 0;
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            dgvyapilanislemler.DataSource = null;
            dgvyapilanislemler.Update();
            dgvyapilanislemler.Refresh();
        }

        private void btn_hastabilgileri_Click(object sender, EventArgs e)
        {
            HastaBilgileri hastaBilgileri = new HastaBilgileri();
            hastaBilgileri.Show();
            this.Enabled = false;
            hastaBilgileri.FormClosed  += new FormClosedEventHandler(this.HastaBilgileri_FormClosed);
        }

        private void HastaBilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled=true;
        }

        private void cmb_yapilanislem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiyatiDoldur();
        }


        double toplamfiyat = 0;
        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txt_hastaadi.Text))
            {
                toplamfiyat += (double)nm_miktar.Value * Convert.ToDouble(txt_birimfiyat.Text);
                lbl_toplamtutar.Text = toplamfiyat.ToString();
                string dosyano = txt_dosyano.Text;
                string poliklinik = cmb_poliklinik.Text;
                string sirano = txt_sirano.Text;
                string saat = DateTime.Now.ToString("HH:mm:ss");
                string yapilanislem = cmb_yapilanislem.Text;
                string drkodu = cmb_drkod.Text;
                decimal miktar = nm_miktar.Value;
                string birimfiyat = txt_birimfiyat.Text;
                string taburcu = "Değil";


                DataTable dataTable = (DataTable)dgvyapilanislemler.DataSource;
                if (dataTable == null)
                {
                    dataTable = new DataTable();
                    dataTable.Columns.Add("Dosya No", typeof(string));
                    dataTable.Columns.Add("Poliklinik", typeof(string));
                    dataTable.Columns.Add("Sıra No", typeof(string));
                    dataTable.Columns.Add("Saat", typeof(string));
                    dataTable.Columns.Add("Yapılan İşlem", typeof(string));
                    dataTable.Columns.Add("Doktor Kodu", typeof(string));
                    dataTable.Columns.Add("Miktar", typeof(string));
                    dataTable.Columns.Add("Birim Fiyatı", typeof(string));
                    dataTable.Columns.Add("Taburcu", typeof(string));
                }

                DataRow newRow = dataTable.NewRow();
                newRow["Dosya No"] = dosyano;
                newRow["Poliklinik"] = poliklinik;
                newRow["Sıra No"] = sirano;
                newRow["Saat"] = saat;
                newRow["Yapılan İşlem"] = yapilanislem;
                newRow["Doktor Kodu"] = drkodu;
                newRow["Miktar"] = miktar;
                newRow["Birim Fiyatı"] = birimfiyat;
                newRow["Taburcu"] = taburcu;

                dataTable.Rows.Add(newRow);

                dgvyapilanislemler.DataSource = dataTable;

                txt_sirano.Text = (Convert.ToInt16(txt_sirano.Text)+1).ToString();
            }
            else
            {
                MessageBox.Show("Hasta numarası girilmeli.");
            }
        }

        private void btn_secsil_Click(object sender, EventArgs e)
        {
            if (dgvyapilanislemler.SelectedCells.Count > 0)
            {
                int rowIndex = dgvyapilanislemler.SelectedCells[0].RowIndex;

                DialogResult result = MessageBox.Show(
                    "Seçili satırı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes )
                {
                    dgvyapilanislemler.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (dgvyapilanislemler.Rows.Count>0)
            {
                for (int i = 0; i < dgvyapilanislemler.Rows.Count; i++)
                {
                    ArrayList yapilanislemkaydi = new ArrayList();
                    string dosyano = dgvyapilanislemler.Rows[i].Cells[0].Value.ToString();
                    string poliklinik = dgvyapilanislemler.Rows[i].Cells[1].Value.ToString();
                    string sirano = dgvyapilanislemler.Rows[i].Cells[2].Value.ToString();
                    string kayitsaati = dgvyapilanislemler.Rows[i].Cells[3].Value.ToString();
                    string taburcusaati = null;
                    if (dgvyapilanislemler.Rows[i].Cells[8].Value.ToString() != "Değil")
                    {
                        taburcusaati = dgvyapilanislemler.Rows[i].Cells[8].Value.ToString();
                    }
                    string yapilanislem = dgvyapilanislemler.Rows[i].Cells[4].Value.ToString(); //id'sini çekicem
                    string drkod = dgvyapilanislemler.Rows[i].Cells[5].Value.ToString();
                    string tarih = DateTime.Now.ToString("yyyy-MM-dd");
                    string miktar = dgvyapilanislemler.Rows[i].Cells[6].Value.ToString();
                    string birimfiyat = dgvyapilanislemler.Rows[i].Cells[7].Value.ToString();

                    yapilanislemkaydi.Add(dosyano);
                    yapilanislemkaydi.Add(yapilanislem);
                    yapilanislemkaydi.Add(drkod);
                    yapilanislemkaydi.Add(poliklinik);
                    yapilanislemkaydi.Add(sirano);
                    yapilanislemkaydi.Add(birimfiyat);
                    yapilanislemkaydi.Add(miktar);
                    yapilanislemkaydi.Add(tarih);
                    yapilanislemkaydi.Add(kayitsaati);
                    yapilanislemkaydi.Add(taburcusaati);


                    dbyapilanislemler.yapilanislemKayitGir(yapilanislemkaydi);


                }
            }
            else
            {
                MessageBox.Show("Önce işlem yapmanız gerek.");
            }




        }

        private void btn_taburcu_Click(object sender, EventArgs e)
        {
            if (dgvyapilanislemler.SelectedCells.Count>0)
            {
                int rowindex = dgvyapilanislemler.SelectedCells[0].RowIndex;
                if (rowindex != dgvyapilanislemler.RowCount-1)
                {
                    dgvyapilanislemler.Rows[rowindex].Cells[8].Value = DateTime.Now.ToString("HH:mm:ss");
                }
                
            }
            else
            {
                MessageBox.Show("Önce işlem eklemeniz gerek.");
            }
     
        }

        private void cmb_drkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DoktorTanitmaFormunaGec();
            }

        }

        private void DoktorTanitma_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            cmbDrkodudoldur();
        }

        private void cmb_drkod_Leave(object sender, EventArgs e)
        {
            DoktorTanitmaFormunaGec();

            cmb_drkod.Text = cmb_drkod.Text.ToUpper();
        }

        private void DoktorTanitmaFormunaGec()
        {
            bool isExist = true;

            isExist = cmb_drkod.Items.Contains(cmb_drkod.Text.ToUpper());

            if (!isExist)
            {
                DialogResult result = MessageBox.Show("Böyle bir doktor kaydı yok. Eklensin mi?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DoktorTanitma doktorKaydiGir = new DoktorTanitma(cmb_drkod.Text);
                    doktorKaydiGir.Show();
                    this.Enabled = false;
                    doktorKaydiGir.FormClosed += new FormClosedEventHandler(this.DoktorTanitma_FormClosed);
                }
                else
                {
                    cmb_drkod.Text = "D001";
                }
            }
        }

        private void cmb_poliklinik_Leave(object sender, EventArgs e)
        {
            PoliklinikTanitmaFormunaGec();
        }

        private void PoliklinikTanitmaFormunaGec()
        {
            bool isExist = true;
            isExist = cmb_poliklinik.Items.Cast<string>().Any(item => item.ToLower() == cmb_poliklinik.Text.ToLower());

            if (!isExist)
            {
                DialogResult result = MessageBox.Show("Böyle bir poliklinik kaydı yok. Eklensin mi?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    PoliklinikTanitma poliklinikTanitma = new PoliklinikTanitma(cmb_poliklinik.Text);
                    poliklinikTanitma.Show();
                    this.Enabled = false;
                    poliklinikTanitma.FormClosed += new FormClosedEventHandler(this.PoliklinikTanitma_FormClosed);
                }
                else
                {
                    cmb_poliklinik.Text = "Dahiliye";
                }
            }
        }

        private void PoliklinikTanitma_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            cmbPoliklinikleriDoldur();
        }

        private void cmb_poliklinik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PoliklinikTanitmaFormunaGec();
            }
        }


        private void btnkullaniciformunagec_Click(object sender, EventArgs e)
        {
            KullaniciTanitma kullaniciTanitma = new KullaniciTanitma();
            kullaniciTanitma.Show();
            this.Enabled = false;
            kullaniciTanitma.FormClosed += new FormClosedEventHandler(this.KullaniciTanitma_FormClosed);
        }

        private void KullaniciTanitma_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }


        Yazdirma yazdirma = new Yazdirma();
        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            ArrayList list2d = new ArrayList();
            if (dgvyapilanislemler.Rows.Count>0)
            {
                for (int i = 0; i < dgvyapilanislemler.Rows.Count; i++)
                {
                    list.Clear();
                    string metin = "";
                    for (int j = 0; j < dgvyapilanislemler.Rows[i].Cells.Count; j++)
                    {
                        if (dgvyapilanislemler.Rows[i].Cells[j].Value.ToString()=="Değil")
                        {
                            metin = "Degil";
                        }
                        else
                        {
                            metin = dgvyapilanislemler.Rows[i].Cells[j].Value.ToString();
                        }
                        list.Add(metin);

                    }
                    list2d.Add(list);              
                }
                yazdirma.Yazdir(txt_sirano.Text, list2d);
            }
            else
            {
                MessageBox.Show("Yazdırmak için önce işlem yapmanız lazım");
            }
      
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelTanitma personelTanitma = new PersonelTanitma();
            personelTanitma.Show();
            this.Enabled = false;
            personelTanitma.FormClosed += new FormClosedEventHandler(this.personeltanitmaformclosed);
        }

        private void personeltanitmaformclosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
