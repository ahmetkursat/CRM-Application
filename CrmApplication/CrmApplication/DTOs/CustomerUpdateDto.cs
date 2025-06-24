using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.DTOs
{
    public class CustomerUpdateDto
    {
        public Guid Id { get; set; }

        public string CompanyName { get; set; } = string.Empty;

        public string ContactPerson { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; }

    }
}
