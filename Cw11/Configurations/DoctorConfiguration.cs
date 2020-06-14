using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cw11.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {        
            public void Configure(EntityTypeBuilder<Doctor> builder)
            {
                builder.HasKey(d => d.IdDoctor); //[Key] primary key
                builder.Property(d => d.IdDoctor).ValueGeneratedOnAdd();
                builder.Property(d => d.IdDoctor).IsRequired();

                builder.Property(d => d.FirstName)
                       .HasMaxLength(100) //[MaxLength(100)]
                       .IsRequired(); //[Required]

                builder.Property(d => d.LastName)
                       .HasMaxLength(100) 
                       .IsRequired(); 

                builder.Property(d => d.Email)
                       .HasMaxLength(100) 
                       .IsRequired();

                builder.HasMany(d => d.Prescriptions)
                       .WithOne(p => p.Doctor)
                       .HasForeignKey(p => p.IdDoctor)
                       .IsRequired();               

            }

    }
}
