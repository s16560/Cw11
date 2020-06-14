using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cw11.Configurations
{
    public class MedicamentConfiguration
        : IEntityTypeConfiguration<Medicament>
    {
        
            public void Configure(EntityTypeBuilder<Medicament> builder)
            {
                builder.HasKey(m => m.IdMedicament); //[Key] primary key
                builder.Property(m => m.IdMedicament).ValueGeneratedOnAdd();
                builder.Property(m => m.IdMedicament).IsRequired();

                builder.Property(m => m.Name)
                       .HasMaxLength(100) //[MaxLength(100)]
                       .IsRequired(); //[Required]

                builder.Property(m => m.Description)
                       .HasMaxLength(100)
                       .IsRequired();

                builder.Property(m => m.Type)
                       .HasMaxLength(100)
                       .IsRequired();

                builder.HasMany(m => m.Prescription_Medicaments)
                       .WithOne(m => m.Medicament)
                       .HasForeignKey(m => m.IdMedicament)
                       .IsRequired();

            }

        

    }
}
