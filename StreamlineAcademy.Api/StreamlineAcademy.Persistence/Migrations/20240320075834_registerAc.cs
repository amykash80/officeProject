using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class registerAc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_academyDestinations_Academies_AcademyId",
                table: "academyDestinations");

            migrationBuilder.DropForeignKey(
                name: "FK_academyDestinations_Cities_CityId",
                table: "academyDestinations");

            migrationBuilder.DropForeignKey(
                name: "FK_academyDestinations_Countries_CountryId",
                table: "academyDestinations");

            migrationBuilder.DropForeignKey(
                name: "FK_academyDestinations_States_StateId",
                table: "academyDestinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_academyDestinations",
                table: "academyDestinations");

            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("47319f0d-360e-42df-8316-f66dceab6c7c"));

            migrationBuilder.RenameTable(
                name: "academyDestinations",
                newName: "AcademyDestinations");

            migrationBuilder.RenameIndex(
                name: "IX_academyDestinations_StateId",
                table: "AcademyDestinations",
                newName: "IX_AcademyDestinations_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_academyDestinations_CountryId",
                table: "AcademyDestinations",
                newName: "IX_AcademyDestinations_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_academyDestinations_CityId",
                table: "AcademyDestinations",
                newName: "IX_AcademyDestinations_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_academyDestinations_AcademyId",
                table: "AcademyDestinations",
                newName: "IX_AcademyDestinations_AcademyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcademyDestinations",
                table: "AcademyDestinations",
                column: "Id");

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("71c37af6-9f6b-4ea5-99ce-ca2f81522f93"), new DateTimeOffset(new DateTime(2024, 3, 20, 13, 28, 33, 636, DateTimeKind.Unspecified).AddTicks(7377), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$fu6mGc0AQzujNuswVq.1hOCuw3Z7wS9oc4BjJnyBqqQWWBgP2KATG", "7267636376", "$2a$11$fu6mGc0AQzujNuswVq.1hO", "superadmin@123", (byte)1 });

            migrationBuilder.AddForeignKey(
                name: "FK_AcademyDestinations_Academies_AcademyId",
                table: "AcademyDestinations",
                column: "AcademyId",
                principalTable: "Academies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademyDestinations_Cities_CityId",
                table: "AcademyDestinations",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademyDestinations_Countries_CountryId",
                table: "AcademyDestinations",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademyDestinations_States_StateId",
                table: "AcademyDestinations",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademyDestinations_Academies_AcademyId",
                table: "AcademyDestinations");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademyDestinations_Cities_CityId",
                table: "AcademyDestinations");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademyDestinations_Countries_CountryId",
                table: "AcademyDestinations");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademyDestinations_States_StateId",
                table: "AcademyDestinations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcademyDestinations",
                table: "AcademyDestinations");

            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("71c37af6-9f6b-4ea5-99ce-ca2f81522f93"));

            migrationBuilder.RenameTable(
                name: "AcademyDestinations",
                newName: "academyDestinations");

            migrationBuilder.RenameIndex(
                name: "IX_AcademyDestinations_StateId",
                table: "academyDestinations",
                newName: "IX_academyDestinations_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_AcademyDestinations_CountryId",
                table: "academyDestinations",
                newName: "IX_academyDestinations_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_AcademyDestinations_CityId",
                table: "academyDestinations",
                newName: "IX_academyDestinations_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_AcademyDestinations_AcademyId",
                table: "academyDestinations",
                newName: "IX_academyDestinations_AcademyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_academyDestinations",
                table: "academyDestinations",
                column: "Id");

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("47319f0d-360e-42df-8316-f66dceab6c7c"), new DateTimeOffset(new DateTime(2024, 3, 20, 13, 23, 42, 106, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$LZtJHYEsa6qC0SbbWerWQuIb.ku5p6JSeqwOfya/.mfXE47BOVncy", "7267636376", "$2a$11$LZtJHYEsa6qC0SbbWerWQu", "superadmin@123", (byte)1 });

            migrationBuilder.AddForeignKey(
                name: "FK_academyDestinations_Academies_AcademyId",
                table: "academyDestinations",
                column: "AcademyId",
                principalTable: "Academies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_academyDestinations_Cities_CityId",
                table: "academyDestinations",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_academyDestinations_Countries_CountryId",
                table: "academyDestinations",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_academyDestinations_States_StateId",
                table: "academyDestinations",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
