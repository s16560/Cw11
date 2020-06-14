using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cw11.Configurations
{
    public class Prescription_MedicamentConfiguration 
        : IEntityTypeConfiguration<Prescription_Medicament>
    {    
        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            builder.HasKey(pm => new
            {
                pm.IdMedicament,
                pm.IdPrescription
            });
          
            builder.Property(pm => pm.Details)
                   .HasMaxLength(100)
                   .IsRequired();

        }
        
    }
}
