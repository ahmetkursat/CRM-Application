using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.DTOs
{
    public class ActivitiesUpdateDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}

