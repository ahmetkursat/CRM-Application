using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmApplication.Data
{
    public class AppDbContext : DbContext // Fixed the syntax error by replacing ':' with inheritance syntax.  
    {

        public class AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

}
}
