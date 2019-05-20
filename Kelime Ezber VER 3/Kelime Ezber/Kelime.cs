using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
    public class Kelime
    {
        public enum Durumu
        {
            Havuz = 1,
            Ogrenilecek,
            Test,
            Ogrenilen
        };

        public string Turkce { get; private set; }
        public string Ingilizce { get; private set; }
        public string Turu { get; private set; }
        public Durumu Durum { get; private set; } 
        public int DogruBilinmeSayisi { get; private set; }
        public DateTime EklendiğiTarih { get; private set; }
        public int OgrenildigiAy { get;  set; }
        public int OgrenildigiYil { get;  set; }
        
       

        public static Kelime KelimeEkle(string turkce,string ingilizce,string tur,Durumu durumu)
        {
            Kelime kelime = new Kelime();
            kelime.Turkce = turkce;
            kelime.Ingilizce = ingilizce;
            kelime.Turu = tur;
            kelime.Durum = durumu;
            kelime.DogruBilinmeSayisi = 0;
            kelime.EklendiğiTarih = DateTime.Now;
            return kelime;

        }

        public static void KelimeSil(Kelime k)
        {
            k = null;
        }

        public void DurumGuncelle(Durumu durum)
        {
            this.Durum = durum;
        }
            

        public void DogruBilmeGuncelle()
        {
            this.DogruBilinmeSayisi++;
        }
        
        public void DogruBilmeSifirla()
        {
            this.DogruBilinmeSayisi = 0;
        }

    }
}
