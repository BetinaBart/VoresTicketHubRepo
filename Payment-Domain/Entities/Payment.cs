using System;
using System.Collections.Generic;
using System.Text;
using Payment_Domain.Enums;

namespace Payment_Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; private set; }
        public decimal Amount { get; private set; }
        public PaymentStatus Status { get; private set; }

    }
}
