using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sales_system.Models;

namespace sales_system.Data
{
    public class sales_systemContext : DbContext
    {
        public sales_systemContext (DbContextOptions<sales_systemContext> options)
            : base(options)
        {
        }

        public DbSet<sales_system.Models.Department> Department { get; set; } = default!;
    }
}
