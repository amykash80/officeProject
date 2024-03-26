using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class nullabe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("2dace831-c6db-40ed-82b3-71af97d3025d"));

            migrationBuilder.AlterColumn<string>(
                name: "ResetCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("59d6b316-1ba8-46a4-a247-2bd5ef7940ce"), new DateTimeOffset(new DateTime(2024, 3, 26, 9, 59, 5, 536, DateTimeKind.Unspecified).AddTicks(4800), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$Y2IjklB2fMwUCfSgNbhaBeRCF2tuImQNm86B4VsXeu0ctJm8hdnsu", "7267636376", "$2a$11$Y2IjklB2fMwUCfSgNbhaBe", "superadmin@123", (byte)1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("59d6b316-1ba8-46a4-a247-2bd5ef7940ce"));

            migrationBuilder.AlterColumn<string>(
                name: "ResetCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("2dace831-c6db-40ed-82b3-71af97d3025d"), new DateTimeOffset(new DateTime(2024, 3, 26, 9, 56, 3, 174, DateTimeKind.Unspecified).AddTicks(4752), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$XCUBzeYko354mnPakPSE/elxLLVA3VhCrBYkEm1riTs8ddcGITIjW", "7267636376", "$2a$11$XCUBzeYko354mnPakPSE/e", "superadmin@123", (byte)1 });
        }
    }
}
