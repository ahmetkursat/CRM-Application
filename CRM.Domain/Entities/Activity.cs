using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain.Entities
{
    public class Activity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid CustomerId { get; set; }
        public string Type { get; set; } = string.Empty; // Call, Email, Meeting, etc.
        public string Note { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.UtcNow;

        // Navigation Property
        public Customer? Customer { get; set; }
    }
}
