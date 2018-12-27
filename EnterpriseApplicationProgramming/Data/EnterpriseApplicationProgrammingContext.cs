using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseApplicationProgramming.Models
{
    public class EnterpriseApplicationProgrammingContext : DbContext
    {
        public EnterpriseApplicationProgrammingContext (DbContextOptions<EnterpriseApplicationProgrammingContext> options)
            : base(options)
        {
        }

        public DbSet<EnterpriseApplicationProgramming.Models.Employee> Employee { get; set; }
    }
}
