using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Kelime_Ezber
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();  
        }
        Kullanıcı Oturum = SQL.GetInstance().OturumuVer();
        bool IlkkezAcilis = true;

        public void IlkAcilis(bool t)
        {
            IlkkezAcilis = t;
        }

        private void btnİstatistikler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formİstatistik istatistik = new Formİstatistik();
            istatistik.ShowDialog();
            this.Close();          
        }

        private void btnKelimeHavuzu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelimeHavuzu kelimeHavuzu = new FormKelimeHavuzu();
            kelimeHavuzu.ShowDialog();
            this.Close();
        }

        private void btnKullaniciAyarlari_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKullaniciAyarlari kullaniciAyarlari = new FormKullaniciAyarlari();
            kullaniciAyarlari.ShowDialog();
            this.Close();
        }

        private void btnKelimeEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelimeEkleme kelimeEkleme = new FormKelimeEkleme();
            kelimeEkleme.ShowDialog();
            this.Close();
        }

        private void btnSozluk_Click(object sender, EventArgs e)
        {
            if (Oturum.istatistik.toplamKelime > 0)
            {
                this.Hide();
                FormSozluk formSozluk = new FormSozluk();
                formSozluk.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Hiç kelimeniz yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTestOl_Click(object sender, EventArgs e)
        {
            if(Oturum.istatistik.testKelime>9)
            {
                this.Hide();
                FormTest test = new FormTest();
                test.ShowDialog();
                this.Close();
            }
            else
               MessageBox.Show("Test için en az 10 kelimeniz olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);                
        }

        private void anaSayfa_Load(object sender, EventArgs e) 
        {
            lblAd.Text ="Hoşgeldin"+ " " + Oturum.Ad;
            if (IlkkezAcilis)
            {
                SQL.GetInstance().KullanicilariAl();
                SQL.GetInstance().KelimeleriEsle(Oturum.Ad);
                SQL.GetInstance().İstatistigiEsle(Oturum.Ad);
                Oturum.istatistik.ToplamKelimeGuncelle();
                IlkkezAcilis = false;
            }
                             
          if(  Oturum.istatistik.testKelime > 0) //HATIRLATMA
          {
                DateTime ŞimdikiZaman = DateTime.Now;
                foreach(Kelime a in Oturum.kelimes)
                {
                    if (a == null || a.Durum!="Test")
                        continue;

                    if (Convert.ToInt32((ŞimdikiZaman - a.EklendiğiTarih).TotalDays)== 182 && a.DogruBilinmeSayisi==3) //6 AY SONRA
                    {
                        MessageBox.Show("Bazı Kelimeler için son test vakti!");
                        break;
                    }
                    if (Convert.ToInt32((ŞimdikiZaman - a.EklendiğiTarih).TotalDays) == 30 && a.DogruBilinmeSayisi == 2) // 1 AY SONRA
                    {
                        MessageBox.Show("Bazı Kelimeler için üçüncü test vakti!");
                        break;
                    }
                    if (Convert.ToInt32((ŞimdikiZaman - a.EklendiğiTarih).TotalDays) == 7 && a.DogruBilinmeSayisi == 1) // 1 HAFTA SONRA
                    {
                        MessageBox.Show("Bazı Kelimeler için ikinci test vakti!");
                        break;
                    }
                    if (Convert.ToInt32((ŞimdikiZaman - a.EklendiğiTarih).TotalDays) == 1 && a.DogruBilinmeSayisi == 0) // 1 GÜN SONRA
                    {
                        MessageBox.Show("Bazı Kelimeler için ilk test vakti!");
                        break;
                    }
                }
          }               
        }      
    }
}
