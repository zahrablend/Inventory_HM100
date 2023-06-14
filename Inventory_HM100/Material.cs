using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_HM100
{
    public class Material : Inventory
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public string? ColorCode { get; set; }
        public double Thickness { get; set; }

        public Material(string storageId, double price) : base(storageId, price) { }
    }
}
