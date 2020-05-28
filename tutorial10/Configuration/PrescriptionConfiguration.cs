using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tutorial10.Models;

namespace tutorial10.Configuration
{

    public class PerscriptionConfiguration : IEntityTypeConfiguration<PatientContext>
    {
        public void Configure(EntityTypeBuilder<PatientContext> builder)
        {

        }
    }
}