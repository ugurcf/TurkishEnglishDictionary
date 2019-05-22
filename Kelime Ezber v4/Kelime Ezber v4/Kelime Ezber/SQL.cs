using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kelime_Ezber
{
     class SQL : VeriTabani
    {
        private static SQL instance;       
        SqlConnection sqlConnection = new SqlConnection("Data Source = LAPTOP-ONB0MHF9; Initial Catalog = KelimeEzber; Integrated Security = True");

        private SQL()
        {

        }

        public static SQL GetInstance()
        {
            if (instance == null)
                instance = new SQL();

            return instance;

        }

        public override void VeriKelimeEkle(string turkce,string ing,string tur,string durum)
        {
          if (sqlConnection.State == System.Data.ConnectionState.Closed)
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "INSERT INTO khavuzu(KelimeTurkce,KelimeIngilizce,KelimeTuru,KelimeDurumu,KelimeDogruBilinmeSayisi,KelimeEklenmeTarihi,KimeAit,OgrenildigiAy,OgrenildigiYil) VALUES('" + turkce + "','" + ing + "','"+tur+"','" + durum + "','" + 0 + "','" + DateTime.Now.ToString() + "','" + SQL.GetInstance().OturumuVer().Ad + "','"+null+"','"+null+"')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();
        }

        public override void VeriKelimeSil(string turkce,Kullanıcı kullanıcı)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("Delete from khavuzu where KelimeTurkce=@p1 AND KimeAit=@p2",sqlConnection);
            cmd.Parameters.AddWithValue("@p1", turkce);
            cmd.Parameters.AddWithValue("@p2", kullanıcı.Ad);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public override void VeriKullaniciEkle(string ad,string şifre)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "INSERT INTO kullanici(KullaniciAdi,KullaniciSifre,SuankiKullanici) VALUES('"+ad+"','"+şifre+"','"+false+"')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = sqlConnection;
            cmd1.CommandText= "INSERT INTO istatistikler(ToplamSkor,GirilenTest,ToplamDogru,ToplamYanlis,ToplamZaman,HavuzKelime,OgrenilcekKelime,TestKelime,OgrenilenKelime,ToplamKelime,KimeAit) VALUES('" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + ad + "')";
            cmd1.ExecuteNonQuery();
            cmd1.Dispose();
            sqlConnection.Close();
        }

        public override void VeriKelimeGuncelle(Kelime kelime)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("UPDATE khavuzu SET KelimeDurumu = @p1, KelimeDogruBilinmeSayisi = @p2, OgrenildigiAy = @p3, OgrenildigiYil = @p4 WHERE KimeAit = @p5 AND KelimeTurkce = @p6", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", kelime.Durum);
            cmd.Parameters.AddWithValue("@p2", kelime.DogruBilinmeSayisi);
            cmd.Parameters.AddWithValue("@p3", kelime.OgrenildigiAy);
            cmd.Parameters.AddWithValue("@p4", kelime.OgrenildigiYil);
            cmd.Parameters.AddWithValue("@p5", Oturum.Ad);
            cmd.Parameters.AddWithValue("@p6", kelime.Turkce);

            cmd.ExecuteNonQuery();
            sqlConnection.Close();               
        }

        public override void VeriKullaniciSil(string ad, string şifre)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("Delete from kullanici where KullaniciAdi=@p1 AND KullaniciSifre=@p2", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", ad);
            cmd.Parameters.AddWithValue("@p2", şifre);
            cmd.ExecuteNonQuery();
           
            SqlCommand cmd1 = new SqlCommand("Delete from istatistikler where KimeAit=@p1", sqlConnection);
            cmd1.Parameters.AddWithValue("@p1", ad);

            cmd1.ExecuteNonQuery();
          
            SqlCommand cmd2 = new SqlCommand("Delete from khavuzu where KimeAit=@p1", sqlConnection);
            cmd2.Parameters.AddWithValue("@p1", ad);

            cmd2.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public override void VeriKullaniciOturumDegistir(Kullanıcı kullanıcı)
        {

            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
         
            bool OturumAcik=true;

            if (kullanıcı == Oturum)
                OturumAcik = true;
            else
                OturumAcik = false;
           
            if (OturumAcik)
            {
                SqlCommand cmd = new SqlCommand("UPDATE kullanici SET SuankiKullanici = @p1 WHERE trim(KullaniciAdi) = @p2", sqlConnection);
                cmd.Parameters.AddWithValue("@p1", false);
                cmd.Parameters.AddWithValue("@p2", Oturum.Ad);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE kullanici SET SuankiKullanici = @p1 WHERE trim(KullaniciAdi) = @p2", sqlConnection);
                cmd.Parameters.AddWithValue("@p1", true);
                cmd.Parameters.AddWithValue("@p2", kullanıcı.Ad);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
          
        }

        public override void VeriİstatistikGuncelle(Kullanıcı kullanıcı)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("UPDATE istatistikler SET ToplamSkor = @p1, GirilenTest = @p2, ToplamDogru = @p3, ToplamYanlis = @p4, ToplamZaman = @p5, HavuzKelime = @p6, OgrenilcekKelime = @p7, TestKelime = @p8, OgrenilenKelime = @p9, ToplamKelime = @p10 WHERE KimeAit = @p11",sqlConnection);   
            cmd.Parameters.AddWithValue("@p1", kullanıcı.istatistik.toplamSkor);
            cmd.Parameters.AddWithValue("@p2", kullanıcı.istatistik.girilenTest);
            cmd.Parameters.AddWithValue("@p3", kullanıcı.istatistik.toplamDogru);
            cmd.Parameters.AddWithValue("@p4", kullanıcı.istatistik.toplamYanlis);
            cmd.Parameters.AddWithValue("@p5", kullanıcı.istatistik.toplamZaman);
            cmd.Parameters.AddWithValue("@p6", kullanıcı.istatistik.havuzKelime);
            cmd.Parameters.AddWithValue("@p7", kullanıcı.istatistik.ogrenilcekKelime);
            cmd.Parameters.AddWithValue("@p8", kullanıcı.istatistik.testKelime);
            cmd.Parameters.AddWithValue("@p9", kullanıcı.istatistik.ogrenilenKelime);
            cmd.Parameters.AddWithValue("@p10", kullanıcı.istatistik.toplamKelime);
            cmd.Parameters.AddWithValue("@p11", kullanıcı.Ad);

            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public override Kullanıcı OturumuVer()
        {
            if (Oturum != null)
                return Oturum;

            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select KullaniciAdi,KullaniciSifre from Kullanici where suankiKullanici=@p1", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", "true");
            
            string ad = "";
            string şifre = "";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ad = dr[0].ToString();
                şifre = dr[1].ToString();
            }

            sqlConnection.Close();
            Oturum = new Kullanıcı(ad, şifre);
            return Oturum;
        }
        public override void KelimeleriEsle(string ad)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select trim(KelimeTurkce),trim(KelimeIngilizce),trim(KelimeTuru),trim(KelimeDurumu),KelimeDogruBilinmeSayisi,KelimeEklenmeTarihi,OgrenildigiAy,OgrenildigiYil from khavuzu where KimeAit=@p1", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", ad);
    
            int sayaç = 0;     
            SqlDataReader dr = cmd.ExecuteReader();     
            while (dr.Read())
            {
                OturumuVer().kelimes[sayaç].Turkce = dr[0].ToString(); ;
                OturumuVer().kelimes[sayaç].Ingilizce = dr[1].ToString();
                OturumuVer().kelimes[sayaç].Turu = dr[2].ToString();
                OturumuVer().kelimes[sayaç].Durum = dr[3].ToString();
                OturumuVer().kelimes[sayaç].DogruBilinmeSayisi = Convert.ToInt32(dr[4]);
                OturumuVer().kelimes[sayaç].EklendiğiTarih = Convert.ToDateTime(dr[5]);
                OturumuVer().kelimes[sayaç].OgrenildigiAy = Convert.ToInt32(dr[6]);
                OturumuVer().kelimes[sayaç].OgrenildigiYil = Convert.ToInt32(dr[7]);

                sayaç++;
            }
            sqlConnection.Close();
        }

        public override void İstatistigiEsle(string ad)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select ToplamSkor,GirilenTest,ToplamDogru,ToplamYanlis,ToplamZaman,HavuzKelime,OgrenilcekKelime,TestKelime,OgrenilenKelime from istatistikler where KimeAit=@p1", sqlConnection);
            cmd.Parameters.AddWithValue("@p1", ad);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Oturum.istatistik.SkorGuncelle(Convert.ToInt32(dr[0]));
                Oturum.istatistik.GirilenTestGuncelle(Convert.ToInt32(dr[1]));
                Oturum.istatistik.ToplamDogruGuncelle(Convert.ToInt32(dr[2]));
                Oturum.istatistik.ToplamYanlisGuncelle(Convert.ToInt32(dr[3]));
                Oturum.istatistik.toplamZamanGuncelle(Convert.ToInt32(dr[4]));
                Oturum.istatistik.HavuzKelimeGuncelle(Convert.ToInt32(dr[5]));
                Oturum.istatistik.OgrenilcekKelimeGuncelle(Convert.ToInt32(dr[6]));
                Oturum.istatistik.TestKelimeGuncelle(Convert.ToInt32(dr[7]));
                Oturum.istatistik.OgrenilenKelimeGuncelle(Convert.ToInt32(dr[8]));   
            }
            sqlConnection.Close();

        }

        public override void KullanicilariAl()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select trim(KullaniciAdi),trim(KullaniciSifre),SuankiKullanici from kullanici", sqlConnection);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
              Kullanicilar.Add(new Kullanıcı(dr[0].ToString(), dr[1].ToString()));       
            }

            sqlConnection.Close();
        }
    }
}
