using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Kelime_Ezber
{
    public partial class FormTest : Form
    {

        static Kullanıcı Oturum = SQL.GetInstance().suankiKullanici;
        static TestYapma Test = TurkceIngilizceTest.getInstance();
        Random rand = new Random();
        private int soruSayisi = Oturum.istatistik.testKelime;
        private string dogruCevap;
        private string Cevap="";
        public int dogruCevapSayisi = 0;
        public int yanlisCevapSayisi = 0;
        public int Skor = 0;
        private int Sira = 0;
        public int saniye = 0;
        public int dakika = 0;
        int rastgeleDogruRadio;


        public FormTest()
        {
            InitializeComponent();
        }

        private void SoruSayfaHazirla()
        {
            UncheckRadio();

            rastgeleDogruRadio = rand.Next(1, 6);


            lblSoru.Text = Test.SoruSor(Sira);
            lblDoğruSayisiTest.Text = "✓ Doğru sayısı:" + dogruCevapSayisi;
            lblYanlısSayisiTest.Text = "✗ Yanlış sayısı:" + yanlisCevapSayisi;
            lblxSoru.Text = Sira + 1 + ".Soru";


            rdioSecenek1.Text = Test.YanlisCevapKoy(Sira);
            rdioSecenek2.Text = Test.YanlisCevapKoy(Sira);
            rdioSecenek3.Text = Test.YanlisCevapKoy(Sira);
            rdioSecenek4.Text = Test.YanlisCevapKoy(Sira);
            rdioSecenek5.Text = Test.YanlisCevapKoy(Sira);

            AyniCevapKontrol();

            if (rastgeleDogruRadio == 1)
            {
                rdioSecenek1.Text = Test.DogruCevapKoy(Sira);
                dogruCevap = Test.DogruCevapKoy(Sira);
            }
            else if (rastgeleDogruRadio == 2)
            {

                rdioSecenek2.Text = Test.DogruCevapKoy(Sira);
                dogruCevap = Test.DogruCevapKoy(Sira);
            }
            else if (rastgeleDogruRadio == 3)
            {
                rdioSecenek3.Text = Test.DogruCevapKoy(Sira);
                dogruCevap = Test.DogruCevapKoy(Sira);
            }
            else if (rastgeleDogruRadio == 4)
            {
                rdioSecenek4.Text = Test.DogruCevapKoy(Sira);
                dogruCevap = Test.DogruCevapKoy(Sira);
            }
            else if (rastgeleDogruRadio == 5)
            {
                rdioSecenek5.Text = Test.DogruCevapKoy(Sira);
                dogruCevap = Test.DogruCevapKoy(Sira);
            }

            Sira++;
            Cevap = "";
        

        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
 
            this.Hide();
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.ShowDialog();
            this.Close();

        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            SoruSayfaHazirla();
            Zamanlayıcı.Start();

        }

        private void rdioSecenek1_CheckedChanged(object sender, EventArgs e)
        {
            Cevap = rdioSecenek1.Text;
        }

        private void rdioSecenek2_CheckedChanged(object sender, EventArgs e)
        {
            Cevap = rdioSecenek2.Text;
        }

        private void rdioSecenek3_CheckedChanged(object sender, EventArgs e)
        {
            Cevap = rdioSecenek3.Text;
        }

        private void rdioSecenek4_CheckedChanged(object sender, EventArgs e)
        {
            Cevap = rdioSecenek4.Text;
        }

        private void rdioSecenek5_CheckedChanged(object sender, EventArgs e)
        {
            Cevap = rdioSecenek5.Text;
        }

        private void UncheckRadio()
        {
            rdioSecenek1.Checked = false;
            rdioSecenek2.Checked = false;
            rdioSecenek3.Checked = false;
            rdioSecenek4.Checked = false;
            rdioSecenek5.Checked = false;
        }

        private void btnCevapla_Click(object sender, EventArgs e)
        {
            if(Cevap=="") 
            {
                MessageBox.Show("Hiçbir seçeneği işaretlemediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                if (Cevap == dogruCevap)
                {
                    Kelime kelime = Test.KelimeSec(Sira - 1);

                   Test.KelimeSec(Sira - 1).DogruBilmeGuncelle();

                    if (Test.KelimeSec(Sira - 1).DogruBilinmeSayisi == 4)
                    {
                    Test.KelimeSec(Sira - 1).DurumGuncelle(Kelime.Durumu.Ogrenilen);
                       kelime.OgrenildigiAy = DateTime.Now.Month;
                       kelime.OgrenildigiYil = DateTime.Now.Year;
                    }                        

                  Oturum.kelimes[Sira] = kelime;

                    dogruCevapSayisi++;
                    Skor += 10;
                }
                else if (Cevap != dogruCevap)
                {
                    Kelime kelime = Test.KelimeSec(Sira - 1);


                    Test.KelimeSec(Sira - 1).DogruBilmeSifirla();
                     Oturum.kelimes[Sira] = kelime;

                    yanlisCevapSayisi++;
                    Skor -= 3;
                }

                if (Sira != soruSayisi)
                    SoruSayfaHazirla();
                else
                {
                    Zamanlayıcı.Stop();

                    MessageBox.Show("Testi tamamladınız");

                   Oturum.istatistik.ToplamDogruGuncelle(dogruCevapSayisi);
                   Oturum.istatistik.ToplamYanlisGuncelle(yanlisCevapSayisi);
                   Oturum.istatistik.SkorGuncelle(Skor);
                   Oturum.istatistik.GirilenTestGuncelle();
                   Oturum.istatistik.toplamZamanGuncelle((dakika * 60) + saniye);
                    Sira = 0;

                    this.Hide();
                    FormSonuc formSonuc = new FormSonuc();
                    formSonuc.lblDogruTik.Text = dogruCevapSayisi + "✓";
                    formSonuc.lblYanlisCarpi.Text = yanlisCevapSayisi + "✗";
                    formSonuc.lblSkorr.Text = Skor.ToString();
                    formSonuc.ShowDialog();
                    this.Close();

                }      
        }

        private void Zamanlayıcı_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                dakika++;
                saniye = 0;
            }

            saniye++;
            lblGecenSure.Text = "Geçen süre" + " " + dakika + ":" + saniye;
        }

        private void AyniCevapKontrol()
        {
            while (rdioSecenek1.Text == rdioSecenek2.Text)
            {
                rdioSecenek1.Text = Test.YanlisCevapKoy(Sira);
                rdioSecenek2.Text = Test.YanlisCevapKoy(Sira);
            }
            while (rdioSecenek1.Text == rdioSecenek3.Text)
            {
                rdioSecenek1.Text = Test.YanlisCevapKoy(Sira);
                rdioSecenek2.Text = Test.YanlisCevapKoy(Sira);
            }
            while (rdioSecenek1.Text == rdioSecenek4.Text)
            {
                rdioSecenek1.Text = Test.YanlisCevapKoy(Sira);
                rdioSecenek4.Text = Test.YanlisCevapKoy(Sira);
            }
            while (rdioSecenek1.Text == rdioSecenek5.Text)
            {
                rdioSecenek1.Text = Test.YanlisCevapKoy(Sira);
                rdioSecenek5.Text = Test.YanlisCevapKoy(Sira);
            }


            while (rdioSecenek2.Text == rdioSecenek3.Text)
            {
                rdioSecenek2.Text = Test.YanlisCevapKoy(Sira);
                rdioSecenek3.Text = Test.YanlisCevapKoy(Sira);
            }

            while (rdioSecenek2.Text == rdioSecenek4.Text)
            {
                rdioSecenek2.Text = Test.YanlisCevapKoy(Sira);
                rdioSecenek4.Text = Test.YanlisCevapKoy(Sira);
            }
            while (rdioSecenek2.Text == rdioSecenek5.Text)
            {
                rdioSecenek2.Text = Test.YanlisCevapKoy(Sira);
                rdioSecenek5.Text = Test.YanlisCevapKoy(Sira);
            }


            while (rdioSecenek3.Text == rdioSecenek4.Text)
            {
                rdioSecenek3.Text = Test.YanlisCevapKoy(Sira);
                rdioSecenek4.Text = Test.YanlisCevapKoy(Sira);
            }

            while (rdioSecenek3.Text == rdioSecenek5.Text)
            {
                rdioSecenek3.Text = Test.YanlisCevapKoy(Sira);
                rdioSecenek5.Text = Test.YanlisCevapKoy(Sira);
            }

            while (rdioSecenek4.Text == rdioSecenek5.Text)
            {
                rdioSecenek4.Text = rdioSecenek5.Text = Test.YanlisCevapKoy(Sira);
                rdioSecenek5.Text = rdioSecenek5.Text = Test.YanlisCevapKoy(Sira);
            }
        }

        private void FormTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diyalog = MessageBox.Show("Eğer çıkarsanız bilgilerinizi kaybedeceksiniz!", "Çık", MessageBoxButtons.YesNo);

            if (diyalog == DialogResult.Yes)
            {
                this.Hide();
                anaSayfa anaSayfa = new anaSayfa();
                anaSayfa.ShowDialog();
                this.Close();
            }
            else if (diyalog == DialogResult.No)
            {
                e.Cancel = true;

            }
        }
    }

}
