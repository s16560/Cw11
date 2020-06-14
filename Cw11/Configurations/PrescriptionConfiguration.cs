using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cw11.Configurations
{
   
        public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
        {
            public void Configure(EntityTypeBuilder<Prescription> builder)
            {
                builder.HasKey(p => p.IdPrecription); //[Key] primary key
                builder.Property(p => p.IdPrecription).ValueGeneratedOnAdd();
                builder.Property(p => p.IdPrecription).IsRequired();

                builder.Property(p => p.Date).IsRequired();

                builder.Property(p => p.DueDate).IsRequired();

                builder.HasMany(p => p.Prescription_Medicaments)
                       .WithOne(p => p.Prescription)
                       .HasForeignKey(p => p.IdPrescription)
                       .IsRequired();

            }

        }
    
}
