using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cw11.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "jka@o2.pl", "Jan", "Kania" },
                    { 2, "kamilb@gmail.com", "Kamil", "Brzozowski" },
                    { 3, "asia.w@onet.pl", "Joanna", "Wisniewska" },
                    { 4, "marekpiasecki@gmail.com", "Marek", "Piasecki" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Krople do oczu", "Krople", "mocne" },
                    { 2, "Tabletki na gardło", "Tabletki", "extra" },
                    { 3, "Plaster na odciski", "Plaster", "15mm" },
                    { 4, "Maść na ugryzienia", "Maść", "anty-komar" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariusz", "Wisniewski" },
                    { 2, new DateTime(1982, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kamil", "Piotrowski" },
                    { 3, new DateTime(1987, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Konrad", "Jablonski" },
                    { 4, new DateTime(1976, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Piotrowska" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrecription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 3, new DateTime(2020, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 2, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 4, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "2 razy dziennie", 3 },
                    { 2, 3, "popić wodą", 5 },
                    { 4, 3, "nakładać czystymi rękami", 1 },
                    { 1, 2, "używać z umiarem", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrecription",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrecription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrecription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrecription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 3);
        }
    }
}
