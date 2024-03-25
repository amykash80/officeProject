using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Indexadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("26189a26-9dba-4623-8bea-e6a04358fc10"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Academies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Academies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Academies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Academies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AcademyName",
                table: "Academies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("189af09c-b3f7-4427-9568-2fa67ed51e8f"), new DateTimeOffset(new DateTime(2024, 3, 25, 10, 50, 32, 4, DateTimeKind.Unspecified).AddTicks(3983), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$MICjwzv3EWBKTByRHtogxOAPNNuZBcRt.PVTfMFR8BD8hCOegqdkK", "7267636376", "$2a$11$MICjwzv3EWBKTByRHtogxO", "superadmin@123", (byte)1 });

            migrationBuilder.CreateIndex(
                name: "IX_Academies_AcademyName",
                table: "Academies",
                column: "AcademyName");

            migrationBuilder.CreateIndex(
                name: "IX_Academies_Address",
                table: "Academies",
                column: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_Academies_Email",
                table: "Academies",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Academies_Name",
                table: "Academies",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Academies_PhoneNumber",
                table: "Academies",
                column: "PhoneNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Academies_AcademyName",
                table: "Academies");

            migrationBuilder.DropIndex(
                name: "IX_Academies_Address",
                table: "Academies");

            migrationBuilder.DropIndex(
                name: "IX_Academies_Email",
                table: "Academies");

            migrationBuilder.DropIndex(
                name: "IX_Academies_Name",
                table: "Academies");

            migrationBuilder.DropIndex(
                name: "IX_Academies_PhoneNumber",
                table: "Academies");

            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("189af09c-b3f7-4427-9568-2fa67ed51e8f"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Academies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Academies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Academies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Academies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "AcademyName",
                table: "Academies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("26189a26-9dba-4623-8bea-e6a04358fc10"), new DateTimeOffset(new DateTime(2024, 3, 22, 11, 32, 47, 115, DateTimeKind.Unspecified).AddTicks(6421), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$xMzXpD.xM61uOSfBiuG2weO82oo4p9SXfIzD9x8B2fKY.6Ln2AzwC", "7267636376", "$2a$11$xMzXpD.xM61uOSfBiuG2we", "superadmin@123", (byte)1 });
        }
    }
}
