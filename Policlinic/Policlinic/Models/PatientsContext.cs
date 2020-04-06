using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models
{
    public class PatientsContext : DbContext
    {
        public PatientsContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Patients> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patients>().HasData(new Patients
            {
                PatientId = 1,
                FirstName = "Uncle",
                LastName = "Bob",
                DateOfBirth = new DateTime(1979, 04, 25),
                PhoneNumber = "999-888-7777"

            }, new Patients
            {
                PatientId = 2,
                FirstName = "Jan",
                LastName = "Kirsten",
                DateOfBirth = new DateTime(1981, 07, 13),
                PhoneNumber = "111-222-3333"
            });
        }

    }

    
}
