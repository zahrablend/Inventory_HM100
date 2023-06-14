using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_HM100
{
    public class Drawer : Inventory
    {
        public string? Type { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double LoadWeight { get; set; }

        public Drawer(string storageId, double price) : base(storageId, price) { }
    }
}
