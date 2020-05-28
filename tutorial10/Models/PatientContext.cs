using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tutorial10.Configuration;
using tutorial10.Controllers;

namespace tutorial10.Models
{
    public class PatientContext : DbContext
    {
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Prescription> Prescription { get; set; }
        public virtual DbSet<Medicament> Medicament { get; set; }
        public virtual DbSet<Prescription_Medicament> Prescription_Medicament { get; set; }

        public PatientContext() { }

        public PatientContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionConfiguration());
            modelBuilder.ApplyConfiguration(new Prescription_MedicamentConfiguration());
        }
    }
}