using System;
using System.Collections.Generic;
using System.Text;
using Event_Domain.Enum;

namespace Ticket_Domain.Entities
{
    public class Tickets
    {
        public Guid Id { get; private set; }

        public int Amount { get; private set; }
        public int Available { get; private set;}
        public TicketType TicketType { get; private set;}
        
    }
}
