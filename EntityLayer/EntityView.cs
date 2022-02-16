using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityView
    {
        private int basvuruid;
        private string ograd;
        private string ogrsoyad;
        private string dersad;

        public int Basvuruid { get => basvuruid; set => basvuruid = value; }
        public string Ograd { get => ograd; set => ograd = value; }
        public string Dersad { get => dersad; set => dersad = value; }
        public string Ogrsoyad { get => ogrsoyad; set => ogrsoyad = value; }
    }
}
