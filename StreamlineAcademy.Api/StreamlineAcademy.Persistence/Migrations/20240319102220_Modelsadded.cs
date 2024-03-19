using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Modelsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("38701b28-7e1d-4c1a-a046-7bd1e4fbcfe8"));

            migrationBuilder.CreateTable(
                name: "AcademyTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Academies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AcademyTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Academies_AcademyTypes_AcademyTypeId",
                        column: x => x.AcademyTypeId,
                        principalTable: "AcademyTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Academies_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Academies_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Academies_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("406f9971-19c8-4dde-a8bc-e4da8e4cf17a"), new DateTimeOffset(new DateTime(2024, 3, 19, 15, 52, 20, 318, DateTimeKind.Unspecified).AddTicks(2500), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$yIH/PINKed/hDMZ9jN1N/u66XaDPRUICnK7q.EgySC3iC4Vdimavu", "7267636376", "$2a$11$yIH/PINKed/hDMZ9jN1N/u", "superadmin@123", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Academies_AcademyTypeId",
                table: "Academies",
                column: "AcademyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Academies_CityId",
                table: "Academies",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Academies_CountryId",
                table: "Academies",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Academies_StateId",
                table: "Academies",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryId",
                table: "States",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Academies");

            migrationBuilder.DropTable(
                name: "AcademyTypes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("406f9971-19c8-4dde-a8bc-e4da8e4cf17a"));

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("38701b28-7e1d-4c1a-a046-7bd1e4fbcfe8"), new DateTimeOffset(new DateTime(2024, 3, 19, 11, 13, 56, 895, DateTimeKind.Unspecified).AddTicks(4894), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$C0GyQL/Xz0n08Rh9UzTO/OPULZSx1DSdYkT/JoAxIqlhpVvYm7VhC", "7267636376", "$2a$11$C0GyQL/Xz0n08Rh9UzTO/O", "superadmin@123", 1 });
        }
    }
}
