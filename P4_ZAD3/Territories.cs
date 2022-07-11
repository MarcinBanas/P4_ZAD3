using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ZAD3
{
    internal class Territories
    {
        public int regionid { get; set; }
        public int territoryID { get; set; }
        public string territoryDescription { get; set; }

        public Region Region { get; set; }
    }
}
