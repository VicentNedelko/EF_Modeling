using EF_Modeling.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Modeling
{
    public class AppContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public AppContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = dbModeling; Trusted_Connection = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .Property(p => p.FName)
                .HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Doctor>()
                .Property(p => p.LName)
                .HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Doctor>()
                .Property(p => p.Position)
                .HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Doctor>()
                .HasMany(p => p.Visits)
                .WithOne(p => p.Doctor);
            modelBuilder.Entity<Doctor>()
                .HasOne(p => p.Department)
                .WithMany(p => p.Doctors);
            modelBuilder.Entity<Doctor>()
                .HasOne(p => p.Area)
                .WithOne(p => p.Doctor);
        }
    }
}
