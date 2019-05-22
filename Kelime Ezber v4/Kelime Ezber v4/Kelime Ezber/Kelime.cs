using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
    public class Kelime
    {
        public string Turkce { get;  set; }
        public string Ingilizce { get;  set; }
        public string Turu { get;  set; }
        public string Durum { get;  set; } 
        public int DogruBilinmeSayisi { get;  set; }
        public DateTime EklendiğiTarih { get;  set; }
        public int OgrenildigiAy { get;  set; }
        public int OgrenildigiYil { get;  set; }
              
        public static Kelime YeniKelimeEkle(string turkce,string ingilizce,string tur,string durumu)
        {
            Kelime kelime = new Kelime();
            kelime.Turkce = turkce;
            kelime.Ingilizce = ingilizce;
            kelime.Turu = tur;
            kelime.Durum = durumu;
            kelime.DogruBilinmeSayisi = 0;
            kelime.EklendiğiTarih = DateTime.Now;
            kelime.OgrenildigiAy = 0;
            kelime.OgrenildigiYil = 0;
            return kelime;

        }

        public static void KelimeSil(Kelime k)
        {
            k = null;
        }

        public void DurumGuncelle(string durum)
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
