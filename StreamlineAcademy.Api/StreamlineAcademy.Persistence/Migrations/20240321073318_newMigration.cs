using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("a034090a-99ab-4f8f-8140-44afc3721b58"));

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("42acb63d-b863-4576-93e9-d17257eca913"), new DateTimeOffset(new DateTime(2024, 3, 21, 13, 3, 17, 631, DateTimeKind.Unspecified).AddTicks(4749), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$w2U1zxvyoLIGw4aeWZ/S2.1GMjQkBcDNZkYaYIPR6sjllt/aPBQ2O", "7267636376", "$2a$11$w2U1zxvyoLIGw4aeWZ/S2.", "superadmin@123", (byte)1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("42acb63d-b863-4576-93e9-d17257eca913"));

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("a034090a-99ab-4f8f-8140-44afc3721b58"), new DateTimeOffset(new DateTime(2024, 3, 21, 12, 58, 51, 936, DateTimeKind.Unspecified).AddTicks(7856), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$YH.qvSQZdK/xYUNayPqUweUY9dnaogjKJZJbq7fecyz0GhMNeFUbS", "7267636376", "$2a$11$YH.qvSQZdK/xYUNayPqUwe", "superadmin@123", (byte)1 });
        }
    }
}
