/* 
* Name: JobOrder.cs
* Date: 24/04/2025
* Description: JobOrder class
*/

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
        public List<JobOrderItem> JobOrderItems { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public JobOrder()
        {
            this.OrderId = null;
            this.CustomerId = null;
            this.OrderDate = DateTime.Now;
            this.WorkDescription = null;
            this.ServiceCharge = 0;
            this.TotalPrice = 0;
            this.Status = 0;
            this.JobOrderItems = new List<JobOrderItem>();
            this.FirstName = null;
            this.LastName = null;
        }
        public JobOrder(string orderId, string customerId, DateTime orderDate, string workDescription, double serviceCharge, double totalPrice, int status, string firstName, string lastName)
        {
            this.OrderId = orderId;
            this.CustomerId = customerId;
            this.OrderDate = orderDate;
            this.WorkDescription = workDescription;
            this.ServiceCharge = serviceCharge;
            this.TotalPrice = totalPrice;
            this.Status = status;
            this.JobOrderItems = new List<JobOrderItem>();
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
