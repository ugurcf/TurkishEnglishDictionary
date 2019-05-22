using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezber
{
    abstract class VeriTabani
    {
        public List<Kullanıcı> Kullanicilar = new List<Kullanıcı>();
        protected Kullanıcı Oturum;
                                 
        public Kullanıcı KullaniciAra(string ad,string şifre)
        {
            foreach (Kullanıcı a in Kullanicilar)
            {
                if (a.Ad == ad && a.Şifre == şifre)       
                    return  a;        
            }
            return null;
        }

        public bool KullaniciAdEşsizligi(string ad)
        {         
            foreach (Kullanıcı a in Kullanicilar)
            {
                if (a.Ad == ad)
                    return false;
            }
            return true;
        }

        public abstract void VeriKelimeEkle(string turkce, string ing, string tur, string durum);
        public abstract void VeriKelimeSil(string turkce,Kullanıcı kullanıcı);
        public abstract void VeriKelimeGuncelle(Kelime kelime);
        public abstract void KelimeleriEsle(string ad);
        public abstract void VeriİstatistikGuncelle(Kullanıcı kullanıcı);
        public abstract void İstatistigiEsle(string ad);
        public abstract void VeriKullaniciOturumDegistir(Kullanıcı kullanıcı);
        public abstract Kullanıcı OturumuVer();
        public abstract void VeriKullaniciEkle(string ad, string şifre);
        public abstract void VeriKullaniciSil(string ad, string şifre);
        public abstract void KullanicilariAl();
    }
}
