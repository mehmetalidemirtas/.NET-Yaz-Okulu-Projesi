using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityGiris
    {
        private int kullaniciid;
        private string kullaniciad;
        private string kullanicisifre;

        public int Kullaniciid { get => kullaniciid; 
            set => kullaniciid = value; }
        public string Kullaniciad { get => kullaniciad; 
            set => kullaniciad = value; }
        public string Kullanicisifre { get => kullanicisifre; 
            set => kullanicisifre = value; }
    }
}
