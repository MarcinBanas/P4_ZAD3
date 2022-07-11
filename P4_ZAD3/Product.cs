using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ZAD3
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public Category Category { get; set; }
    }
}
