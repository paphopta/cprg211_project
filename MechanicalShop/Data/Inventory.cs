using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalShop.Data
{
    public class Inventory
    {
        public string? PartId { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? PartName { get; set; }
        public double UnitPrice { get; set; }
        public int InventoryQuantity { get; set; }
        public Inventory(string partId, string brand, string model, string partName, double unitPrice, int inventoryQuantity)
        {
            this.PartId = partId;
            this.Brand = brand;
            this.Model = model;
            this.PartName = partName;
            this.UnitPrice = unitPrice;
            this.InventoryQuantity = inventoryQuantity;
        }
    }
}