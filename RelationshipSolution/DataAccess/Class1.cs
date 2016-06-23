using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class SampleDbContext : DbContext
    {
        public DbSet<Employee>  Employees { get; set; }
        public DbSet<Employer> Employers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // One to Many relationship 
            modelBuilder.Entity<Employee>().HasRequired(p => p.Employer)
                 .WithMany(p => p.Employees).HasForeignKey(x=>x.EmployeeId);

            base.OnModelCreating(modelBuilder);

        }

    }
}
