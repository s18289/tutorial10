using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}