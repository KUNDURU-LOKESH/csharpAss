using Microsoft.EntityFrameworkCore;
using Organization.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Data
{
    public class DemoContext:DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeOrganization> EmployeeOrganization { get; set; }    
        public DemoContext()
        { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LVVPEMG;Database=OrgDb;Trusted_Connection=True;");

        }

    }
}
