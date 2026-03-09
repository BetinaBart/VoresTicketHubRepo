using System;
using System.Collections.Generic;
using System.Text;

namespace Order_Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }



    }
}
