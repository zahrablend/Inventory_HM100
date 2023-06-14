using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    // Please create required classes to represent inventory storage.
    // There should be 5 different items we could store in the inventory.
    // Use inheritance.

namespace Inventory_HM100
{
    public class Inventory
    {
        public string? StorageId { get; private set; }

        public double Price { get; private set; }

        public string? Color { get; set; }

        public ushort Quantity { get; set; }

        public Inventory(string storageId, double price)
        {
            StorageId = storageId;
            Price = price;
        }
    }
}
