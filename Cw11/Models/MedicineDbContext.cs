using Cw11.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Cw11.Models
{
    public class MedicineDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }

        public MedicineDbContext() { }

        public MedicineDbContext(DbContextOptions options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new Prescription_MedicamentConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentConfiguration());
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            //doctors
            List<Doctor> doctors = new List<Doctor>();
            doctors.Add(new Doctor { IdDoctor = 1, FirstName = "Jan", LastName = "Kania", Email = "jka@o2.pl" });
            doctors.Add(new Doctor { IdDoctor = 2, FirstName = "Kamil", LastName = "Brzozowski", Email = "kamilb@gmail.com" });
            doctors.Add(new Doctor { IdDoctor = 3, FirstName = "Joanna", LastName = "Wisniewska", Email = "asia.w@onet.pl" });
            doctors.Add(new Doctor { IdDoctor = 4, FirstName = "Marek", LastName = "Piasecki", Email = "marekpiasecki@gmail.com" });

            modelBuilder.Entity<Doctor>().HasData(doctors);

            //patients
            List<Patient> patients = new List<Patient>();
            patients.Add(new Patient { IdPatient = 1, FirstName = "Mariusz", LastName = "Wisniewski", BirthDate = new DateTime(1980, 3, 4)});
            patients.Add(new Patient { IdPatient = 2, FirstName = "Kamil", LastName = "Piotrowski", BirthDate = new DateTime(1982, 5, 2) });
            patients.Add(new Patient { IdPatient = 3, FirstName = "Konrad", LastName = "Jablonski", BirthDate = new DateTime(1987, 12, 12) });
            patients.Add(new Patient { IdPatient = 4, FirstName = "Anna", LastName = "Piotrowska", BirthDate = new DateTime(1976, 11, 2) });

            modelBuilder.Entity<Patient>().HasData(patients);

            //prescriptions
            List<Prescription> prescriptions = new List<Prescription>();
            prescriptions.Add(new Prescription { IdPrecription = 1, Date = new DateTime(2020, 7, 11), DueDate = new DateTime(2020, 7, 1), IdPatient = 1, IdDoctor = 2 });
            prescriptions.Add(new Prescription { IdPrecription = 2, Date = new DateTime(2020, 6, 4), DueDate = new DateTime(2020, 6, 7), IdPatient = 3, IdDoctor = 1 });
            prescriptions.Add(new Prescription { IdPrecription = 3, Date = new DateTime(2020, 8, 6), DueDate = new DateTime(2020, 9, 12), IdPatient = 1, IdDoctor = 3 });
            prescriptions.Add(new Prescription { IdPrecription = 4, Date = new DateTime(2020, 6, 1), DueDate = new DateTime(2020, 6, 1), IdPatient = 4, IdDoctor = 1 });

            modelBuilder.Entity<Prescription>().HasData(prescriptions);

            //medicaments
            List<Medicament> medicaments = new List<Medicament>();
            medicaments.Add(new Medicament { IdMedicament = 1, Name = "Krople", Description = "Krople do oczu", Type = "mocne"});
            medicaments.Add(new Medicament { IdMedicament = 2, Name = "Tabletki", Description = "Tabletki na gardło", Type = "extra" });
            medicaments.Add(new Medicament { IdMedicament = 3, Name = "Plaster", Description = "Plaster na odciski", Type = "15mm" });
            medicaments.Add(new Medicament { IdMedicament = 4, Name = "Maść", Description = "Maść na ugryzienia", Type = "anty-komar" });

            modelBuilder.Entity<Medicament>().HasData(medicaments);

            //prescription_medicaments
            List<Prescription_Medicament> prescriptions_medicaments = new List<Prescription_Medicament>();
            prescriptions_medicaments.Add(new Prescription_Medicament { IdMedicament = 1, IdPrescription = 1, Dose = 3, Details = "2 razy dziennie" });
            prescriptions_medicaments.Add(new Prescription_Medicament { IdMedicament = 1, IdPrescription = 2, Dose = 2, Details = "używać z umiarem" });
            prescriptions_medicaments.Add(new Prescription_Medicament { IdMedicament = 2, IdPrescription = 3, Dose = 5, Details = "popić wodą" });
            prescriptions_medicaments.Add(new Prescription_Medicament { IdMedicament = 4, IdPrescription = 3, Dose = 1, Details = "nakładać czystymi rękami" });

            modelBuilder.Entity<Prescription_Medicament>().HasData(prescriptions_medicaments);
        }


    }
}
