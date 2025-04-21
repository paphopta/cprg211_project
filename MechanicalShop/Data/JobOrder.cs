using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;

namespace MechanicalShop.Data
{
    public class JobOrder
    {
        public string? OrderId { get; set; }
        public string? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string? WorkDescription { get; set; }
        public double ServiceCharge { get; set; }
        public double TotalPrice { get; set; }
        public int Status { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public JobOrder(string orderId, string customerId, DateTime orderDate, string workDescription, double serviceCharge, double totalPrice, int status, string firstName, string lastName)
        {
            this.OrderId = orderId;
            this.CustomerId = customerId;
            this.OrderDate = orderDate;
            this.WorkDescription = workDescription;
            this.ServiceCharge = serviceCharge;
            this.TotalPrice = totalPrice;
            this.Status = status;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
