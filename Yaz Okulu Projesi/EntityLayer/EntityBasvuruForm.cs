using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruid;
        private int basvurudersid;
        private int basvuruogrid;

        public int Basvuruid { get => basvuruid;
            set => basvuruid = value; }
        public int Basvurudersid { get => basvurudersid;
            set => basvurudersid = value; }
        public int Basvuruogrid { get => basvuruogrid;
            set => basvuruogrid = value; }
    }
}
