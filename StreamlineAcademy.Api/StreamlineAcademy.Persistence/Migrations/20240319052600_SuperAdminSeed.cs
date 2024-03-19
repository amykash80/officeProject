using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SuperAdminSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Enquiries",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedOn",
                table: "Enquiries",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateTable(
                name: "SuperAdmins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperAdmins", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("727ec1ad-e091-459e-a95a-f8916386f46e"), new DateTimeOffset(new DateTime(2024, 3, 19, 10, 55, 58, 731, DateTimeKind.Unspecified).AddTicks(7196), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$wMw82eVOwAB.oFHLNk4JqOPsQlIadvtHKZGR4Z/cKt9JUAp8EDIoK", "7267636376", "$2a$11$wMw82eVOwAB.oFHLNk4JqO", "superadmin@123", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperAdmins");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Enquiries");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Enquiries",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
