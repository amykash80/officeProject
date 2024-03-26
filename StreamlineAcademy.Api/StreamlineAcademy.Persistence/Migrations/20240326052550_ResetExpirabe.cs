using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ResetExpirabe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("20f444a0-e430-4f50-9d55-8a401ccdf805"));
            migrationBuilder.DropColumn(
name: "ResetExpirable",
table: "Users");

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("55ff487f-416b-4d86-9312-53978cea52f4"), new DateTimeOffset(new DateTime(2024, 3, 26, 10, 55, 49, 334, DateTimeKind.Unspecified).AddTicks(3065), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$zsMgAxd24yrqbAKeC/gORe8E0poE0ThHXbQrbGTPPY98rU4dzRHrO", "7267636376", "$2a$11$zsMgAxd24yrqbAKeC/gORe", "superadmin@123", (byte)1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("55ff487f-416b-4d86-9312-53978cea52f4"));

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("20f444a0-e430-4f50-9d55-8a401ccdf805"), new DateTimeOffset(new DateTime(2024, 3, 26, 10, 36, 0, 195, DateTimeKind.Unspecified).AddTicks(4656), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$tU5Q4U8doZiElvi.Tk9Lh.uKv5vQSIEGlZBsSZsN/19G0CdyAi99K", "7267636376", "$2a$11$tU5Q4U8doZiElvi.Tk9Lh.", "superadmin@123", (byte)1 });
        }
    }
}
