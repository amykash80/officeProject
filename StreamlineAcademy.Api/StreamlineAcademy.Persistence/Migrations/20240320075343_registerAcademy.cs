using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class registerAcademy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academies_AcademyTypes_AcademyTypeId",
                table: "Academies");

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
                keyValue: new Guid("406f9971-19c8-4dde-a8bc-e4da8e4cf17a"));

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Academies");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Academies");

            migrationBuilder.AlterColumn<byte>(
                name: "UserRole",
                table: "SuperAdmins",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "AcademyTypeId",
                table: "Academies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "academyDestinations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcademyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_academyDestinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_academyDestinations_Academies_AcademyId",
                        column: x => x.AcademyId,
                        principalTable: "Academies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_academyDestinations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_academyDestinations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_academyDestinations_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("47319f0d-360e-42df-8316-f66dceab6c7c"), new DateTimeOffset(new DateTime(2024, 3, 20, 13, 23, 42, 106, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$LZtJHYEsa6qC0SbbWerWQuIb.ku5p6JSeqwOfya/.mfXE47BOVncy", "7267636376", "$2a$11$LZtJHYEsa6qC0SbbWerWQu", "superadmin@123", (byte)1 });

            migrationBuilder.CreateIndex(
                name: "IX_academyDestinations_AcademyId",
                table: "academyDestinations",
                column: "AcademyId");

            migrationBuilder.CreateIndex(
                name: "IX_academyDestinations_CityId",
                table: "academyDestinations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_academyDestinations_CountryId",
                table: "academyDestinations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_academyDestinations_StateId",
                table: "academyDestinations",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Academies_AcademyTypes_AcademyTypeId",
                table: "Academies",
                column: "AcademyTypeId",
                principalTable: "AcademyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Academies_AcademyTypes_AcademyTypeId",
                table: "Academies");

            migrationBuilder.DropTable(
                name: "academyDestinations");

            migrationBuilder.DeleteData(
                table: "SuperAdmins",
                keyColumn: "Id",
                keyValue: new Guid("47319f0d-360e-42df-8316-f66dceab6c7c"));

            migrationBuilder.AlterColumn<int>(
                name: "UserRole",
                table: "SuperAdmins",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<Guid>(
                name: "AcademyTypeId",
                table: "Academies",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "Academies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Academies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StateId",
                table: "Academies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "SuperAdmins",
                columns: new[] { "Id", "CreatedOn", "Email", "Name", "Password", "PhoneNumber", "Salt", "UserName", "UserRole" },
                values: new object[] { new Guid("406f9971-19c8-4dde-a8bc-e4da8e4cf17a"), new DateTimeOffset(new DateTime(2024, 3, 19, 15, 52, 20, 318, DateTimeKind.Unspecified).AddTicks(2500), new TimeSpan(0, 5, 30, 0, 0)), "ram@gmail.com", "Ram", "$2a$11$yIH/PINKed/hDMZ9jN1N/u66XaDPRUICnK7q.EgySC3iC4Vdimavu", "7267636376", "$2a$11$yIH/PINKed/hDMZ9jN1N/u", "superadmin@123", 1 });

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
                name: "FK_Academies_AcademyTypes_AcademyTypeId",
                table: "Academies",
                column: "AcademyTypeId",
                principalTable: "AcademyTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Academies_Cities_CityId",
                table: "Academies",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Academies_Countries_CountryId",
                table: "Academies",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Academies_States_StateId",
                table: "Academies",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");
        }
    }
}
