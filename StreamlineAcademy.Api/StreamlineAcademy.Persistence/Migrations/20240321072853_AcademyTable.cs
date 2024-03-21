using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AcademyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademyDestinations");

            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("71c37af6-9f6b-4ea5-99ce-ca2f81522f93"));

            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "Academies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Academies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StateId",
                table: "Academies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("a034090a-99ab-4f8f-8140-44afc3721b58"), new DateTimeOffset(new DateTime(2024, 3, 21, 12, 58, 51, 936, DateTimeKind.Unspecified).AddTicks(7856), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$YH.qvSQZdK/xYUNayPqUweUY9dnaogjKJZJbq7fecyz0GhMNeFUbS", "7267636376", "$2a$11$YH.qvSQZdK/xYUNayPqUwe", "superadmin@123", (byte)1 });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Academies_Cities_CityId",
                table: "Academies",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Academies_Countries_CountryId",
                table: "Academies",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Academies_States_StateId",
                table: "Academies",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academies_Cities_CityId",
                table: "Academies");

            migrationBuilder.DropForeignKey(
                name: "FK_Academies_Countries_CountryId",
                table: "Academies");

            migrationBuilder.DropForeignKey(
                name: "FK_Academies_States_StateId",
                table: "Academies");

            migrationBuilder.DropIndex(
                name: "IX_Academies_CityId",
                table: "Academies");

            migrationBuilder.DropIndex(
                name: "IX_Academies_CountryId",
                table: "Academies");

            migrationBuilder.DropIndex(
                name: "IX_Academies_StateId",
                table: "Academies");

            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("a034090a-99ab-4f8f-8140-44afc3721b58"));

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Academies");

            migrationBuilder.CreateTable(
                name: "AcademyDestinations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcademyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademyDestinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademyDestinations_Academies_AcademyId",
                        column: x => x.AcademyId,
                        principalTable: "Academies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademyDestinations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademyDestinations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademyDestinations_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("71c37af6-9f6b-4ea5-99ce-ca2f81522f93"), new DateTimeOffset(new DateTime(2024, 3, 20, 13, 28, 33, 636, DateTimeKind.Unspecified).AddTicks(7377), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$fu6mGc0AQzujNuswVq.1hOCuw3Z7wS9oc4BjJnyBqqQWWBgP2KATG", "7267636376", "$2a$11$fu6mGc0AQzujNuswVq.1hO", "superadmin@123", (byte)1 });

            migrationBuilder.CreateIndex(
                name: "IX_AcademyDestinations_AcademyId",
                table: "AcademyDestinations",
                column: "AcademyId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademyDestinations_CityId",
                table: "AcademyDestinations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademyDestinations_CountryId",
                table: "AcademyDestinations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademyDestinations_StateId",
                table: "AcademyDestinations",
                column: "StateId");
        }
    }
}
