using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class registeracademyChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("42acb63d-b863-4576-93e9-d17257eca913"));

            migrationBuilder.AddColumn<byte>(
                name: "RegistrationStatus",
                table: "Enquiries",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Academies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "Academies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "UserRole",
                table: "Academies",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("e1ada733-da73-4d76-b081-cec430550615"), new DateTimeOffset(new DateTime(2024, 3, 22, 10, 48, 19, 313, DateTimeKind.Unspecified).AddTicks(1150), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$Lb7aIVFFku2vTrwtklF6S.HHefwjpUnlJ.os4/4MAZtBJdSA33v/e", "7267636376", "$2a$11$Lb7aIVFFku2vTrwtklF6S.", "superadmin@123", (byte)1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("e1ada733-da73-4d76-b081-cec430550615"));

            migrationBuilder.DropColumn(
                name: "RegistrationStatus",
                table: "Enquiries");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "Academies");

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("42acb63d-b863-4576-93e9-d17257eca913"), new DateTimeOffset(new DateTime(2024, 3, 21, 13, 3, 17, 631, DateTimeKind.Unspecified).AddTicks(4749), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$w2U1zxvyoLIGw4aeWZ/S2.1GMjQkBcDNZkYaYIPR6sjllt/aPBQ2O", "7267636376", "$2a$11$w2U1zxvyoLIGw4aeWZ/S2.", "superadmin@123", (byte)1 });
        }
    }
}
