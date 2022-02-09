using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLBasvuruForm
    {
        public static List<EntityBasvuruForm> BllBasvuruListele()
        {
            return DALBasvuruForm.BasvuruListesi();
        }

        public static List<EntityView> BllListele()
        {
            return DALBasvuruForm.BasvuruListele();
        }

        public static bool BasvuruSilBLL(int p)
        {
            if (p >= 0)
            {
                return DALBasvuruForm.BasvuruSil(p);
            }
            return false;
        }

        public static List<EntityBasvuruForm> BllDetay(int p)
        {
            return DALBasvuruForm.BasvuruDetay(p);
        }

        public static bool BasvuruGuncelleBLL(EntityBasvuruForm p)
        {
            if (p.Basvurudersid > 0)
            {
                return DALBasvuruForm.BasvuruGuncelle(p);
            }
            return false;
        }
    }
}
