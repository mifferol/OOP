using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace DAL.Models
{
    public class RepositoryContext : DbContext
    {
        //public RepositoryContext() { }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        { }

        public DbSet<Patients> Patients { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Visits> Visits { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Patients>().HasData(new Patients
            //{
            //    PatientId = 1,
            //    FirstName = "Uncle",
            //    LastName = "Bob",
            //    DateOfBirth = new DateTime(1979, 04, 25),
            //    PhoneNumber = "999-888-7777"

            //}, new Patients
            //{
            //    PatientId = 2,
            //    FirstName = "Jan",
            //    LastName = "Kirsten",
            //    DateOfBirth = new DateTime(1981, 07, 13),
            //    PhoneNumber = "111-222-3333"
            //});

            //modelBuilder.Entity<Doctors>().HasData(new Doctors
            //{
            //    DoctorId = 1,
            //    FirstName = "Uncle",
            //    LastName = "Bob"

            //}, new Doctors
            //{
            //    DoctorId = 2,
            //    FirstName = "Jan",
            //    LastName = "Kirsten"
            //});
        }

      
    }

    
}
