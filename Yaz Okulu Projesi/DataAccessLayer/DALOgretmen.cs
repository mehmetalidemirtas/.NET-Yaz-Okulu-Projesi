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
    public class DALOgretmen
    {
        public static int OgretmenEkle(EntityOgretmen entityOgretmen)
        {
            SqlCommand komut1 = new SqlCommand("insert into TableOgretmen" +
                "(OgrtAdSoyad,OgrtBrans) values (@p1,@p2)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", entityOgretmen.Ogrtad);
            komut1.Parameters.AddWithValue("@p2", entityOgretmen.Ogrtbrans);            
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgretmen> OgretmenListele()
        {
            List<EntityOgretmen> degerler = new List<EntityOgretmen>();
            SqlCommand komut = new SqlCommand("Select * From TableOgretmen", Baglanti.bgl);
            //SqlCommand komut = new SqlCommand("Select * From TableBasvuruForm Inner Join TableDersler On TableBasvuruForm.OgrenciId = TableDersler.DersId Inner Join TableOgrenci On TableBasvuruForm.OgrenciId =TableOgrenci.OgrId", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ent = new EntityOgretmen();
                ent.Ogrtid = Convert.ToInt32(dr["OgrtId"].ToString());
                ent.Ogrtad = dr["OgrtAdSoyad"].ToString();
                ent.Ogrtbrans = Convert.ToInt32(dr["OgrtBrans"].ToString());                
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static List<EntityView> OgretmenListesi()
        {
            List<EntityView> degerler = new List<EntityView>();
            SqlCommand komut = new SqlCommand("Select * From Ogretmenler", Baglanti.bgl);
            //SqlCommand komut = new SqlCommand("Select * From TableBasvuruForm Inner Join TableDersler On TableBasvuruForm.OgrenciId = TableDersler.DersId Inner Join TableOgrenci On TableBasvuruForm.OgrenciId =TableOgrenci.OgrId", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityView ent = new EntityView();
                ent.Basvuruid = Convert.ToInt32(dr["OgrtId"].ToString());
                ent.Ograd= dr["OgrtAdSoyad"].ToString();
                ent.Dersad= dr["DersAd"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgretmenSilBLL(int parametre)
        {
            SqlCommand komut = new SqlCommand("Delete From TableOgretmen where OgrtId=@p1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgretmen> OgretmenDetay(int id)
        {
            List<EntityOgretmen> degerler = new List<EntityOgretmen>();
            SqlCommand komut = new SqlCommand("Select * From TableOgretmen where OgrtId=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ent = new EntityOgretmen();
                ent.Ogrtad = dr["OgrtAdSoyad"].ToString();
                ent.Ogrtbrans = int.Parse(dr["OgrtBrans"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgretmenGuncelle(EntityOgretmen deger)
        {
            SqlCommand komut = new SqlCommand("Update TableOgretmen Set OgrtAdSoyad=@p1,OgrtBrans=@p2 WHERE OgrtId=@p3", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", deger.Ogrtad);
            komut.Parameters.AddWithValue("@p2", deger.Ogrtbrans);            
            komut.Parameters.AddWithValue("@p3", deger.Ogrtid);
            return komut.ExecuteNonQuery() > 0;
        }

    }
}
