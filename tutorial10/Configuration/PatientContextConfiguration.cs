using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tutorial10.Models;

namespace tutorial10.Controllers
{

    public class PatientContextConfiguration : IEntityTypeConfiguration<PatientContext>
    {
        public void Configure(EntityTypeBuilder<PatientContext> builder)
        {

        }
    }
}
