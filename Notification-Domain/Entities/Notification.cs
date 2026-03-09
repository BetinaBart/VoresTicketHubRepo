using System;
using System.Collections.Generic;
using System.Text;

namespace Notification_Domain.Entities
{
    public class Notification
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Message { get; private set; }   

    }
}
