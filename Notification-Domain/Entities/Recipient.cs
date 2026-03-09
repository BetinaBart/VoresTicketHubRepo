using System;
using System.Collections.Generic;
using System.Text;

namespace Notification_Domain.Entities
{
    public class Recipient
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
    }
}
