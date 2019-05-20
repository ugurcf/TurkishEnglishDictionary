using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
    class TurkceIngilizceTest : TestYapma
    {
        private static TurkceIngilizceTest instance;
        private bool İngKelime;

        int rastgeleSayi;
        Random random = new Random();




        private TurkceIngilizceTest()
        {
        }

        public static TestYapma getInstance()
        {
            if (instance == null)
                instance = new TurkceIngilizceTest();

            return instance;
        }

        public override string DogruCevapKoy(int Kacinci)
        {
            Kelime a = KelimeSec(Kacinci);
            if (İngKelime)
                return a.Ingilizce;
            else
                return a.Turkce;
        }

        public override string YanlisCevapKoy(int Kacinci)
        {



            rastgeleSayi = random.Next(0, SQL.GetInstance().suankiKullanici.istatistik.testKelime); 

            while(rastgeleSayi==Kacinci)
                rastgeleSayi = random.Next(0, SQL.GetInstance().suankiKullanici.istatistik.testKelime);



            Kelime rastgeleKelime = KelimeSec(rastgeleSayi);


            if (İngKelime)
                return rastgeleKelime.Ingilizce;
            else
                return rastgeleKelime.Turkce;
            
        }


        public override string SoruSor(int Kacinci)
        {
            Kelime a = KelimeSec(Kacinci);
            Random random = new Random();
            string Soru = "";
           İngKelime=(random.NextDouble() >= 0.5);

            if (İngKelime)
                Soru += a.Turkce + " " +"Kelimesinin İngilizcesi nedir?";
            else
                Soru += a.Ingilizce + " " + "Kelimesinin Türkçesi nedir?";
      
            return Soru;         
        }
    }
}
