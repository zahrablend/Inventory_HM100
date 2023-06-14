using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_HM100
{
    public class Edge : Inventory
    {
        public double Length { get; set; }
        public double Thickness { get; set; }
        public double Width { get; set; }

        public Edge(string storageId, double price) : base(storageId, price) { }
    }
}
