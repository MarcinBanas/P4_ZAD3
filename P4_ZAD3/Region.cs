using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ZAD3
{
    internal class Region
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        public Territories Territories { get; set; }
    }
}
