using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci entityOgrenci)
        {
            SqlCommand komut1 = new SqlCommand("insert into TableOgrenci" +
                "(OgrAd,OgrSoyad,OgrNumara,OgrMail,OgrSifre) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if(komut1.Connection.State!=ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", entityOgrenci.Ad);
            komut1.Parameters.AddWithValue("@p2", entityOgrenci.Soyad);
            komut1.Parameters.AddWithValue("@p3", entityOgrenci.Numara);
            komut1.Parameters.AddWithValue("@p4", entityOgrenci.Mail);
            komut1.Parameters.AddWithValue("@p5", entityOgrenci.Sifre);
            return komut1.ExecuteNonQuery();
        }
        public static List<EntityOgrenci> OgrenciListesi() 
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("Select * From TableOgrenci", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ogrid = Convert.ToInt32(dr["OgrId"].ToString());
                ent.Ad = dr["OgrAd"].ToString();
                ent.Soyad = dr["OgrSoyad"].ToString();
                ent.Numara = dr["OgrNumara"].ToString();
                ent.Sifre = dr["OgrSifre"].ToString();
                ent.Mail = dr["OgrMail"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut = new SqlCommand("Delete From TableOgrenci where OgrId=@p1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("Select * From TableOgrenci where OgrId=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = dr["OgrAd"].ToString();
                ent.Soyad = dr["OgrSoyad"].ToString();
                ent.Numara = dr["OgrNumara"].ToString();
                ent.Sifre = dr["OgrSifre"].ToString();
                ent.Mail = dr["OgrMail"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {           
            SqlCommand komut = new SqlCommand("Update TableOgrenci Set OgrAd=@p1,OgrSoyad=@p2,OgrNumara=@p3,OgrSifre=@p4,OgrMail=@p5 WHERE OgrId=@p6", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", deger.Ad);
            komut.Parameters.AddWithValue("@p2", deger.Soyad);
            komut.Parameters.AddWithValue("@p3", deger.Numara);
            komut.Parameters.AddWithValue("@p4", deger.Sifre);
            komut.Parameters.AddWithValue("@p5", deger.Mail);
            komut.Parameters.AddWithValue("@p6", deger.Ogrid);
            return komut.ExecuteNonQuery() > 0;
        }
        
    }
}
