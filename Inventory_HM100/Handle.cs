using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_HM100
{
    public class Handle : Inventory
    {
        public double Length1 { get; set; }
        public double Length2 { get; set; }
        public double Diameter { get; set; }
        public string? Style { get; set; }

        public Handle(string storageId, double price) : base(storageId, price) { }
    }
}
