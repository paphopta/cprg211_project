using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicalShop.Data
{
    public class Customer
    {
        public string? CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public Customer(string customerId, string firstName, string lastName, string phone, string email)
        {
            this.CustomerId = customerId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
        }
    }
}
