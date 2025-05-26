using Microsoft.EntityFrameworkCore;
using NotificationPOCSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationPOCSystem.DAL
{
    public class FinalSharjahContext :DbContext
    {
        public virtual DbSet<Employee> Employee { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Section> Sections { get; set; } = null!;
        public virtual DbSet<Branch> Branchs { get; set; } = null!;

        public FinalSharjahContext()
        {
        }
        public FinalSharjahContext(DbContextOptions<FinalSharjahContext> options)
              : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("employeesequence")
                .StartsAt(165424)     // Adjust this if needed based on current sequence value
                .IncrementsBy(1);

            modelBuilder.Entity<Employee>()
                 .Property(e => e.EmployeeID)
                 .HasDefaultValueSql("NEXT VALUE FOR employeesequence")
                 .ValueGeneratedOnAdd();
        }

        
    }

    
}
