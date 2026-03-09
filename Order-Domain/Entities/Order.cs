using System;
using System.Collections.Generic;
using System.Text;
using Order_Domain.Enum;

namespace Order_Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }
        public  OrderStatus Status { get; private set; }
        public  bool IsPaid { get; private set; }

    }
}
