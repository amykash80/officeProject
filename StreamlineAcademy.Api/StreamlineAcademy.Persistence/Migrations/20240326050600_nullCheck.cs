using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class nullCheck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("06b522d0-c272-4e28-854c-ec74bee0bae5"));

     

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("20f444a0-e430-4f50-9d55-8a401ccdf805"), new DateTimeOffset(new DateTime(2024, 3, 26, 10, 36, 0, 195, DateTimeKind.Unspecified).AddTicks(4656), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$tU5Q4U8doZiElvi.Tk9Lh.uKv5vQSIEGlZBsSZsN/19G0CdyAi99K", "7267636376", "$2a$11$tU5Q4U8doZiElvi.Tk9Lh.", "superadmin@123", (byte)1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("20f444a0-e430-4f50-9d55-8a401ccdf805"));

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("06b522d0-c272-4e28-854c-ec74bee0bae5"), new DateTimeOffset(new DateTime(2024, 3, 26, 10, 30, 30, 413, DateTimeKind.Unspecified).AddTicks(8489), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$VtiNiqoh16MLjFFX6aoypuozSUmji.ZsL2XEAx1gSrwMxhfgMz8Eu", "7267636376", "$2a$11$VtiNiqoh16MLjFFX6aoypu", "superadmin@123", (byte)1 });
        }
    }
}
