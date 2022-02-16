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
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select * From TableDersler", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Dersid = Convert.ToInt32(dr["DersId"].ToString());
                ent.Dersad = dr["DersAd"].ToString();
                ent.Minkontenjan = int.Parse(dr["DersMinKontenjan"].ToString());
                ent.Maxkontenjan = int.Parse(dr["DersMaxKontenjan"].ToString());

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TableBasvuruForm (OgrenciId,DersId)" +
                "values (@p1,@p2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.Basvuruogrid);
            komut.Parameters.AddWithValue("@p2", parametre.Basvurudersid);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }        

        public static bool DersSil(int parametre)
        {
            SqlCommand komut = new SqlCommand("Delete From TableDersler where DersId=@p1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre);
            return komut.ExecuteNonQuery() > 0;
        }

        public static int DersEkle(EntityDers entityDers)
        {
            SqlCommand komut1 = new SqlCommand("insert into TableDersler" +
                "(DersAd,DersMinKontenjan,DersMaxKontenjan) values (@p1,@p2,@p3)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", entityDers.Dersad);
            komut1.Parameters.AddWithValue("@p2", entityDers.Minkontenjan);
            komut1.Parameters.AddWithValue("@p3", entityDers.Maxkontenjan);
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityDers> DersDetay(int id)
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select * From TableDersler where DersId=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.Dersad = dr["DersAd"].ToString();
                ent.Minkontenjan = int.Parse(dr["DersMinKontenjan"].ToString());
                ent.Maxkontenjan = int.Parse(dr["DersMaxKontenjan"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool DersGuncelle(EntityDers deger)
        {
            SqlCommand komut = new SqlCommand("Update TableDersler Set DersAd=@p1,DersMinKontenjan=@p2,DersMaxKontenjan=@p3 WHERE DersId=@p4", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", deger.Dersad);
            komut.Parameters.AddWithValue("@p2", deger.Minkontenjan);
            komut.Parameters.AddWithValue("@p3", deger.Maxkontenjan);
            komut.Parameters.AddWithValue("@p4", deger.Dersid);
            return komut.ExecuteNonQuery() > 0;
        }

        public static void IsimDetay(int id)
        {
            SqlCommand komut = new SqlCommand("Select * From TableOgrenci where OgrId=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);                                   
        }
    }
}
