using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> DersListesi()
        {
            return DALDers.DersListesi();
        }
        public static int TalepEkleBLL(EntityBasvuruForm p)
        {
            if(p.Basvuruogrid!=null && p.Basvurudersid !=null)
            {
                return DALDers.TalepEkle(p);            
            }
            return -1;
        }        
        public static List<EntityDers> BllDersListele()
        {
            return DALDers.DersListesi();
        }

        public static bool DersSilBLL(int p)
        {
            if (p >= 0)
            {
                return DALDers.DersSil(p);
            }
            return false;
        }      
        public static int DersEkleBLL(EntityDers eo)
        {
            if (eo.Dersad != null && eo.Maxkontenjan != 0)
            {
                return DALDers.DersEkle(eo);
            }
            return -1;
        }

        public static List<EntityDers> BllDersDetay(int p)
        {
            return DALDers.DersDetay(p);
        }

        public static bool DersGuncellleBLL(EntityDers p)
        {
            if (p.Dersad != null)
            {
                return DALDers.DersGuncelle(p);
            }
            return false;
        }
    }
}
