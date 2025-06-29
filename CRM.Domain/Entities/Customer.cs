using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain.Entities
{

    public class Customer
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string CompanyName { get; set; } = string.Empty;
        public string ContactPerson { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        // Navigation Property
        public ICollection<Activities> Activities { get; set; } = new List<Activities>();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
