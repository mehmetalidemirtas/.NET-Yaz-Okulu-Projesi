using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci eo)
        { 
            if(eo.Ad!=null && eo.Soyad!=null && eo.Numara!=null &&
                eo.Sifre!=null && eo.Mail!=null)
            {
                return DALOgrenci.OgrenciEkle(eo);
            }
            return -1;
        }
        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBLL(int p)
        {
            if(p>=0 )
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;           
        }

        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncellleBLL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Ad!="" && p.Soyad != null && p.Soyad !="" && p.Numara != null && p.Numara !=""&&
               p.Sifre != null && p.Sifre !="" && p.Mail != null && p.Mail !="" && p.Ogrid>0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
      
    }
}
