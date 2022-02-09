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
    public class DALBasvuruForm
    {
        public static List<EntityBasvuruForm> BasvuruListesi()
        {
            List<EntityBasvuruForm> degerler = new List<EntityBasvuruForm>();
            SqlCommand komut = new SqlCommand("Select * From TableBasvuruForm", Baglanti.bgl);
            //SqlCommand komut = new SqlCommand("Select TableBasvuruForm.BasvuruId, TableDersler.DersAd, TableOgrenci.OgrAd From TableDersler,TableOgrenci,TableBasvuruForm Where TableBasvuruForm.OgrenciId = TableOgrenci.OgrId and TableBasvuruForm.DersId = TableDersler.DersId", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityBasvuruForm ent = new EntityBasvuruForm();
                ent.Basvuruid = Convert.ToInt32(dr["BasvuruId"].ToString());
                ent.Basvuruogrid = Convert.ToInt32(dr["OgrenciId"].ToString());
                ent.Basvurudersid = int.Parse(dr["DersId"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static List<EntityView> BasvuruListele()
        {
            List<EntityView> degerler = new List<EntityView>();
            SqlCommand komut = new SqlCommand("Select * From BasvuruForm", Baglanti.bgl);
            //SqlCommand komut = new SqlCommand("Select TableBasvuruForm.BasvuruId, TableDersler.DersAd, TableOgrenci.OgrAd From TableDersler,TableOgrenci,TableBasvuruForm Where TableBasvuruForm.OgrenciId = TableOgrenci.OgrId and TableBasvuruForm.DersId = TableDersler.DersId", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityView ent = new EntityView();
                ent.Basvuruid = Convert.ToInt32(dr["BasvuruId"].ToString());
                ent.Ograd = dr["OgrAd"].ToString();
                ent.Ogrsoyad = dr["OgrSoyad"].ToString();
                ent.Dersad = dr["DersAd"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool BasvuruSil(int parametre)
        {
            SqlCommand komut = new SqlCommand("Delete From TableBasvuruForm where BasvuruId=@p1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityBasvuruForm> BasvuruDetay(int id)
        {
            List<EntityBasvuruForm> degerler = new List<EntityBasvuruForm>();
            SqlCommand komut = new SqlCommand("Select * From TableBasvuruForm where BasvuruId=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityBasvuruForm ent = new EntityBasvuruForm();
                ent.Basvuruogrid = Convert.ToInt32(dr["OgrenciId"].ToString());
                ent.Basvurudersid = Convert.ToInt32(dr["DersId"].ToString());                
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool BasvuruGuncelle(EntityBasvuruForm deger)
        {
            SqlCommand komut = new SqlCommand("Update TableBasvuruForm Set DersId=@p1 WHERE BasvuruId=@p3", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", deger.Basvurudersid);              
            komut.Parameters.AddWithValue("@p3", deger.Basvuruid);
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
