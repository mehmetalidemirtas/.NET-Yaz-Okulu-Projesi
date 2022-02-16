using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using System.Web;


namespace DataAccessLayer
{
    public class DALGiris
    {
        public static bool KullaniciGiris(EntityGiris eg)
        {
            SqlCommand komut = new SqlCommand("Select * From TableGiris Where KullaniciAd=@p1 AND KullaniciSifre=@p2", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", eg.Kullaniciad);
            komut.Parameters.AddWithValue("@p2", eg.Kullanicisifre);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {               
                HttpContext.Current.Session["KullaniciAdi"] = "Giris";                
            }
            dr.Close();
            return komut.ExecuteNonQuery() > 0;
        }

        public static int KullaniciEkle(EntityGiris entityGiris)
        {
            SqlCommand komut1 = new SqlCommand("insert into TableGiris" +
                "(KullaniciAd,KullaniciSifre) values (@p1,@p2)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", entityGiris.Kullaniciad);
            komut1.Parameters.AddWithValue("@p2", entityGiris.Kullanicisifre);
            return komut1.ExecuteNonQuery();
        }


        public static bool OgrenciGiris(EntityGiris eg)
        {
            SqlCommand komut = new SqlCommand("Select OgrMail,OgrSifre From TableOgrenci Where OgrMail=@p1 AND OgrSifre=@p2", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", eg.Kullaniciad);
            komut.Parameters.AddWithValue("@p2", eg.Kullanicisifre);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                HttpContext.Current.Session["Ogrenci"] = "Giris";
            }
            dr.Close();
            return komut.ExecuteNonQuery() > 0;
        }

        public static int OgrenciId(EntityGiris eg)
        {
            List<EntityGiris> degerler = new List<EntityGiris>();
            int Kullaniciid = 0;
            SqlCommand komut = new SqlCommand("Select OgrId From TableOgrenci Where OgrMail=@p1 AND OgrSifre=@p2", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", eg.Kullaniciad);
            komut.Parameters.AddWithValue("@p2", eg.Kullanicisifre);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                
                Kullaniciid = int.Parse(dr["OgrId"].ToString());                
            }
            dr.Close();
            return Kullaniciid;          
        }
    }
}
