using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("e1ada733-da73-4d76-b081-cec430550615"));

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("26189a26-9dba-4623-8bea-e6a04358fc10"), new DateTimeOffset(new DateTime(2024, 3, 22, 11, 32, 47, 115, DateTimeKind.Unspecified).AddTicks(6421), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$xMzXpD.xM61uOSfBiuG2weO82oo4p9SXfIzD9x8B2fKY.6Ln2AzwC", "7267636376", "$2a$11$xMzXpD.xM61uOSfBiuG2we", "superadmin@123", (byte)1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("26189a26-9dba-4623-8bea-e6a04358fc10"));

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("e1ada733-da73-4d76-b081-cec430550615"), new DateTimeOffset(new DateTime(2024, 3, 22, 10, 48, 19, 313, DateTimeKind.Unspecified).AddTicks(1150), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$Lb7aIVFFku2vTrwtklF6S.HHefwjpUnlJ.os4/4MAZtBJdSA33v/e", "7267636376", "$2a$11$Lb7aIVFFku2vTrwtklF6S.", "superadmin@123", (byte)1 });
        }
    }
}
