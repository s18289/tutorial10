using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tutorial10.Models;

namespace tutorial10.Configuration
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(e => e.IdDoctor)
                  .HasName("Doctor_pk");

            builder.Property(e => e.FirstName)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(e => e.LastName)
                      .IsRequired()
                      .HasMaxLength(100);

            builder.Property(e => e.Email)
                  .IsRequired()
                  .HasMaxLength(100);
        }
    }
}