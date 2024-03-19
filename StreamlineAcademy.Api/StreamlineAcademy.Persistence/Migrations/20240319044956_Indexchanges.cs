using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StreamlineAcademy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Indexchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Enquiries_Email",
                table: "Enquiries");

            migrationBuilder.DropIndex(
                name: "IX_Enquiries_Name",
                table: "Enquiries");

            migrationBuilder.CreateIndex(
                name: "IX_Enquiries_Email",
                table: "Enquiries",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Enquiries_Name",
                table: "Enquiries",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Enquiries_Email",
                table: "Enquiries");

            migrationBuilder.DropIndex(
                name: "IX_Enquiries_Name",
                table: "Enquiries");

            migrationBuilder.CreateIndex(
                name: "IX_Enquiries_Email",
                table: "Enquiries",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enquiries_Name",
                table: "Enquiries",
                column: "Name",
                unique: true);
        }
    }
}
