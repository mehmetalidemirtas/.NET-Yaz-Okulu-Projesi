using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;


namespace BusinessLogicLayer
{
    public class BLLGiris
    {
        public static bool GirisBLL(EntityGiris eg)
        {
            if (eg.Kullaniciad != null && eg.Kullanicisifre != null)
            {
                return DALGiris.KullaniciGiris(eg);
            }
            return false;
        }

        public static int KullaniciEkleBLL(EntityGiris eg)
        {
            if (eg.Kullaniciad != null && eg.Kullanicisifre != null)
            {
                return DALGiris.KullaniciEkle(eg);
            }
            return -1;
        }


        public static bool OgrenciGirisBLL(EntityGiris eg)
        {
            if (eg.Kullaniciad != null && eg.Kullanicisifre != null)
            {
                return DALGiris.OgrenciGiris(eg);
            }
            return false;
        }

        public static int OgrenciId(EntityGiris eg)
        {
            return DALGiris.OgrenciId(eg);
        }
    }
}
