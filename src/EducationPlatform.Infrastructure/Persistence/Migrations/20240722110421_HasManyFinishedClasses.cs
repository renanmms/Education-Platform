using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationPlatform.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class HasManyFinishedClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FinishedClasses_ClassId",
                table: "FinishedClasses");

            migrationBuilder.CreateIndex(
                name: "IX_FinishedClasses_ClassId",
                table: "FinishedClasses",
                column: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FinishedClasses_ClassId",
                table: "FinishedClasses");

            migrationBuilder.CreateIndex(
                name: "IX_FinishedClasses_ClassId",
                table: "FinishedClasses",
                column: "ClassId",
                unique: true);
        }
    }
}
