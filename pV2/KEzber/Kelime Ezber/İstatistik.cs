using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
    public class İstatistik
    {
       private int toplamSkor = 0;
       private int girilenTest = 0;
       private int toplamDogru = 0;
       private int toplamYanlis = 0;
       private int toplamZaman = 0;
       private int havuzKelime = 0;
       private int ogrenilcekKelime = 0;
       public int TestKelime { get; private set; } = 0;
       private int OgrenilenKelime = 0;
       private int ToplamKelime = 0;


        public void SkorGuncelle(int a)
        {  
          this.toplamSkor += a;
        }

        public void ToplamDogruGuncelle(int a)
        {
           this.toplamDogru += a;
        }

        public void ToplamYanlisGuncelle(int a)
        {
            this.toplamYanlis += a;
        }

        public void toplamZamanGuncelle(int a)
        {
            this.toplamZaman += a;
        }

        public void HavuzKelimeGuncelle(bool artir)
        {
            if (artir)
                this.havuzKelime++;
            else
                this.havuzKelime--;
        }

        public void OgrenilcekKelimeGuncelle(bool artir)
        {
            if (artir)
                this.ogrenilcekKelime++;
            else
                this.ogrenilcekKelime--;
        }
        
        public void TestKelimeGuncelle(bool artir)
        {
            if (artir)
                this.TestKelime++;
            else
                this.TestKelime--;
        }
        public void OgrenilenKelimeGuncelle(bool artir)
        {
            if (artir)
                this.OgrenilenKelime++;
            else
                this.ogrenilcekKelime--;
        }

        public void GirilenTestGuncelle()
        {
            this.girilenTest++;
        }

        public void ToplamKelimeGuncelle()
        {
            this.ToplamKelime = havuzKelime + TestKelime + ogrenilcekKelime + ogrenilcekKelime;
        }

    
    }
}
