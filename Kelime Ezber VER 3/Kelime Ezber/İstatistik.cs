using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
    public class İstatistik
    {
       public int toplamSkor { get; private set; } 
       public int girilenTest { get; private set; } 
       public int toplamDogru { get; private set; } 
       public int toplamYanlis { get; private set; } 
       public int toplamZaman { get; private set; } 
       public int havuzKelime { get;  set; } = 0;
       public int ogrenilcekKelime { get; set; } 
       public int testKelime { get;  set; } 
       public int ogrenilenKelime { get;  set; } 
       public int toplamKelime { get; private set; } 

     public İstatistik()
        {
            this.toplamSkor = 0;
            this.girilenTest = 0;
            this.toplamDogru = 0;
            this.toplamYanlis = 0;
            this.toplamZaman = 0;
            this.havuzKelime = 0;
            this.ogrenilcekKelime = 0;
            this.testKelime = 0;
            this.ogrenilenKelime = 0;
            this.toplamKelime = 0;
        }
            



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

        public void HavuzKelimeGuncelle(int a)
        {

            this.havuzKelime = +a;
          
        }

        public void OgrenilcekKelimeGuncelle(int a)
        {

            this.ogrenilcekKelime += a;

        }
        
        public void TestKelimeGuncelle(int a)
        {
            this.testKelime += a;
  
        }
        public void OgrenilenKelimeGuncelle(int a)
        {

            this.ogrenilenKelime += a;

        }

        public void GirilenTestGuncelle()
        {
            this.girilenTest++;
        }

        public void ToplamKelimeGuncelle()
        {
            this.toplamKelime = havuzKelime + testKelime + ogrenilcekKelime + ogrenilcekKelime;
        }

    
    }
}
