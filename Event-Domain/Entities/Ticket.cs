using System;
using System.Collections.Generic;
using System.Text;
using Event_Domain.Enum;

namespace Event_Domain.Entities
{
    public class Tickets
    {
        public Guid Id { get; private set; }

        public decimal Price { get; private set; }
        public DateTime DateTime { get; private set; }
        public TicketType TicketType { get; private set; }
        public string Location { get; private set; }
        public string Placement { get; private set; }
        
    }
}
