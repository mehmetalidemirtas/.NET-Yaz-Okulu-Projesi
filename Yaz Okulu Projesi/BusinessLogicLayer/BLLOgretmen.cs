using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgretmen
    {
        public static int OgretmenEkleBLL(EntityOgretmen eo)
        {
            if (eo.Ogrtad != null && eo.Ogrtbrans != 0)
            {
                return DALOgretmen.OgretmenEkle(eo);
            }
            return -1;
        }

        public static List<EntityOgretmen> BllListele()
        {
            return DALOgretmen.OgretmenListele();
        }

        public static List<EntityView> BllOgretmenListesi()
        {
            return DALOgretmen.OgretmenListesi();
        }

        public static bool OgretmenSilBLL(int p)
        {
            if (p >= 0)
            {
                return DALOgretmen.OgretmenSilBLL(p);
            }
            return false;
        }

        public static List<EntityOgretmen> BllDetay(int p)
        {
            return DALOgretmen.OgretmenDetay(p);
        }

        public static bool OgretmenGuncellleBLL(EntityOgretmen p)
        {
            if (p.Ogrtad != null && p.Ogrtad != "" && p.Ogrtbrans >0 && p.Ogrtid > 0)
            {
                return DALOgretmen.OgretmenGuncelle(p);
            }
            return false;
        }
    }
}
