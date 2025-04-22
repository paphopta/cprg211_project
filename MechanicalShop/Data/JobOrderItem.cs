using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalShop.Data
{
    public class JobOrderItem
    {
        public string? PartId { get; set; }
        public int OrderQuantity { get; set; }
        public double Total { get; set; }
        public JobOrderItem(string partID, int orderQuantity)
        {
            this.PartId = partID;
            this.OrderQuantity = orderQuantity;
            this.Total = 0;
        }
        public JobOrderItem(string partID, int orderQuantity, double total)
        {
            this.PartId = partID;
            this.OrderQuantity = orderQuantity;
            this.Total = total;
        }
        public void CalculateTotal(double unitPrice)
        {
            this.Total = OrderQuantity * unitPrice;
        }
    }
}
