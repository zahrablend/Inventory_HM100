using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_HM100
{
    public class Leg : Inventory
    {
        public double Height { get; set; }
        public double Diameter { get; set; }

        public Leg(string storageId, double price) : base(storageId, price) { }
    }
}
