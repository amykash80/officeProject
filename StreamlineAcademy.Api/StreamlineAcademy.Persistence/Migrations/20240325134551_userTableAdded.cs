using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class userTableAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "Academies");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<byte>(type: "tinyint", nullable: false),
                    ResetCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResetExpirable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("f4fef0c2-6dac-49bc-8062-6920d867718b"), new DateTimeOffset(new DateTime(2024, 3, 25, 19, 15, 49, 249, DateTimeKind.Unspecified).AddTicks(199), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$O0JiJ.Ko6xgrj3.RGQ9c5.UcMFUrO2KXH75TrVyBmQzKDdSRnYD8.", "7267636376", "$2a$11$O0JiJ.Ko6xgrj3.RGQ9c5.", "superadmin@123", (byte)1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Academies_Users_Id",
                table: "Academies",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academies_Users_Id",
                table: "Academies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("f4fef0c2-6dac-49bc-8062-6920d867718b"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Academies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Academies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Academies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Academies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Academies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
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
                values: new object[] { new Guid("189af09c-b3f7-4427-9568-2fa67ed51e8f"), new DateTimeOffset(new DateTime(2024, 3, 25, 10, 50, 32, 4, DateTimeKind.Unspecified).AddTicks(3983), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$MICjwzv3EWBKTByRHtogxOAPNNuZBcRt.PVTfMFR8BD8hCOegqdkK", "7267636376", "$2a$11$MICjwzv3EWBKTByRHtogxO", "superadmin@123", (byte)1 });

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
    }
}
