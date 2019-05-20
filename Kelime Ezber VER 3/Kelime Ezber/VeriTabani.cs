using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
    abstract class VeriTabani
    {
        //TODO: EN SON SPRINT'TE GEREKSİNİMLERE GÖRE DEĞİŞEBİLİR
        public List<Kullanıcı> Kullanicilar = new List<Kullanıcı>();
        public Kullanıcı suankiKullanici = new Kullanıcı("Berke", "golat2052");
        

     

        public Kullanıcı KullaniciAra(string ad,string şifre)
        {
            foreach (Kullanıcı a in Kullanicilar)
            {
                if (a.Ad == ad && a.Şifre == şifre)       
                    return  a;        
            }
            return null;
        }


        public abstract void VeriKelimeEkle();
        public abstract void VeriKelimeSil();
        public abstract void VeriİstatistikGuncelle();
        public abstract void VeriKullaniciyiGuncelle();
        public abstract void VeriKullaniciEkle();
        public abstract void VeriKullaniciSil();
        

    }
}
