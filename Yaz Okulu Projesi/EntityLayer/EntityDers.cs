using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDers
    {
        private int dersid;
        private string dersad;
        private int minkontenjan;
        private int maxkontenjan;

        public int Dersid { get => dersid;
            set => dersid = value; }
        public string Dersad { get => dersad;
            set => dersad = value; }
        public int Minkontenjan { get => minkontenjan;
            set => minkontenjan = value; }
        public int Maxkontenjan { get => maxkontenjan;
            set => maxkontenjan = value; }
    }
}
