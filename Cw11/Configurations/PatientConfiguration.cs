using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cw11.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {       
            public void Configure(EntityTypeBuilder<Patient> builder)
            {
                builder.HasKey(p => p.IdPatient); //[Key] primary key
                builder.Property(p => p.IdPatient).ValueGeneratedOnAdd();
                builder.Property(p => p.IdPatient).IsRequired();

                builder.Property(p => p.FirstName)
                       .HasMaxLength(100) //[MaxLength(100)]
                       .IsRequired(); //[Required]

                builder.Property(p => p.LastName)
                       .HasMaxLength(100)
                       .IsRequired();

                builder.Property(p => p.BirthDate)
                       .IsRequired();

                builder.HasMany(p => p.Prescriptions)
                       .WithOne(p => p.Patient)
                       .HasForeignKey(p => p.IdPatient)
                       .IsRequired();
            }
       
    }
}
