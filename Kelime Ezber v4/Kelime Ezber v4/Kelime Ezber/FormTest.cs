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

        static Kullanıcı Oturum = SQL.GetInstance().OturumuVer();
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

            while(Test.SoruSor(Sira) == null)
                Sira++;

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
                anaSayfa.IlkAcilis(false);
                anaSayfa.ShowDialog();
                this.Close();          
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            int sira = 0;

            Test.soruKelimeleri = new Kelime[Oturum.istatistik.testKelime];

            for(int i=0;i<Oturum.istatistik.toplamKelime;i++)
            {
                while(Oturum.kelimes[i] == null)
                    continue;

                if(Oturum.kelimes[i].Durum == "Test")
                {
                    Test.soruKelimeleri[sira] = Oturum.kelimes[i];
                    sira++;
                }
            }
                          
            SoruSayfaHazirla();
            Zamanlayıcı.Start();
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
                Kelime kelime = Test.soruKelimeleri[Sira - 1];
                int indis = KelimeIndisiAra(kelime);

                Oturum.kelimes[indis] = kelime;
                Oturum.kelimes[indis].DogruBilmeGuncelle();
              

                    if (Oturum.kelimes[indis].DogruBilinmeSayisi == 4)
                    {
                       Oturum.kelimes[indis].DurumGuncelle("Ögrenilen");
                    Oturum.kelimes[indis].OgrenildigiAy = DateTime.Now.Month;
                    Oturum.kelimes[indis].OgrenildigiYil = DateTime.Now.Year;
                    Oturum.istatistik.TestKelimeGuncelle(-1);
                    Oturum.istatistik.OgrenilenKelimeGuncelle(1);
                    MessageBox.Show(kelime.Turkce + " kelimesini öğrendiniz!");
                    }

                 SQL.GetInstance().VeriKelimeGuncelle(Oturum.kelimes[indis]);
                 dogruCevapSayisi++;
                    Skor += 10;
                }
                else if (Cevap != dogruCevap)
                {
                Kelime kelime = Test.soruKelimeleri[Sira - 1];
                int indis = KelimeIndisiAra(kelime);

                Oturum.kelimes[indis] = kelime;
                Oturum.kelimes[indis].DogruBilmeSifirla();
                SQL.GetInstance().VeriKelimeGuncelle(Oturum.kelimes[indis]);

                yanlisCevapSayisi++;
                    Skor -= 3;
                }

                if (Sira != Oturum.istatistik.testKelime-1)
                    SoruSayfaHazirla();
                else
                {
                    Zamanlayıcı.Stop();

                    MessageBox.Show("Testi tamamladınız");

                   Oturum.istatistik.ToplamDogruGuncelle(dogruCevapSayisi);
                   Oturum.istatistik.ToplamYanlisGuncelle(yanlisCevapSayisi);
                   Oturum.istatistik.SkorGuncelle(Skor);
                   Oturum.istatistik.GirilenTestGuncelle(1);
                   Oturum.istatistik.toplamZamanGuncelle((dakika * 60) + saniye);
                   SQL.GetInstance().VeriİstatistikGuncelle(Oturum);

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

        private int KelimeIndisiAra(Kelime k)
        {           
            for (int i = 0; i < Oturum.kelimes.Length; i++)
            {
                if(Oturum.kelimes[i]==null)
                {
                    i++;
                    continue;
                }

                if (Oturum.kelimes[i].Turkce == "-1")
                    break;

                if (Oturum.kelimes[i] == k)
                    return i;
            }
            return -1;
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
    }
}
