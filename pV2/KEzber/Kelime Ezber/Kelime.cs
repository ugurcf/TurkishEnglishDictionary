using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
    public class Kelime
    {
        public string Turkce { get; private set; }
        public string Ingilizce { get; private set; }
        private string Turu;
        public string Durumu { get; private set; }
        public int DogruBilinmeSayisi { get; private set; }
       

        public void KelimeEkle(string turkce,string ingilizce,string tur,string durum)
        {
            Kelime kelime = new Kelime();
            kelime.Turkce = turkce;
            kelime.Ingilizce = ingilizce;
            kelime.Turu = tur;
            kelime.Durumu = durum;
        }

        public void KelimeSil(Kelime k)
        {
            k = null;
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
