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
        private bool İngSoru;

        private TurkceIngilizceTest()
        {
        }

        public static TestYapma getInstance()
        {
            if (instance == null)
                instance = new TurkceIngilizceTest();

            return instance;
        }

        public override string DogruCevapKoy(Kullanıcı k, int sayi)
        {
            Kelime a = KelimeSec(k, sayi);
            if (İngSoru)
                return a.Ingilizce;
            else
                return a.Turkce;
        }

        public override string YanlisCevapKoy(Kullanıcı k,int sayi)
        {
            Random random = new Random();
            int rastgeleSayi = random.Next(1, k.istatistik.TestKelime);
            Kelime dogruKelime = KelimeSec(k,sayi);
            Kelime rastgeleKelime = k.Kelimeler.First.Value;

            for (int i = 1; i < rastgeleSayi; i++)
                rastgeleKelime = k.Kelimeler.First.Next.Value;

            if (dogruKelime != rastgeleKelime && İngSoru)
                return rastgeleKelime.Ingilizce;
            else if (dogruKelime != rastgeleKelime && !İngSoru)
                return rastgeleKelime.Turkce;
            else
                return YanlisCevapKoy(k, sayi);
        }

        public override string SoruSor(Kullanıcı k, int sayi)
        {
            Kelime a = KelimeSec(k,sayi);
            Random random = new Random();
            string Soru = "";
            İngSoru=(random.NextDouble() >= 0.5);


            if (İngSoru)
                Soru += a.Turkce + "Kelimesinin İngilizcesi nedir?";
            else
                Soru += a.Ingilizce + "Kelimesinin Türkçesi nedir?";
      
            return Soru;         
        }
    }
}
