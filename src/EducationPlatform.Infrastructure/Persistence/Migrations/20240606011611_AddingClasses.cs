using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationPlatform.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddingClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClassConcluded_Class_ClassId",
                table: "UserClassConcluded");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropIndex(
                name: "IX_UserClassConcluded_ClassId",
                table: "UserClassConcluded");

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    LinkVideo = table.Column<string>(type: "text", nullable: true),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserClassConcludedId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_UserClassConcluded_UserClassConcludedId",
                        column: x => x.UserClassConcludedId,
                        principalTable: "UserClassConcluded",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ModuleId",
                table: "Classes",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UserClassConcludedId",
                table: "Classes",
                column: "UserClassConcludedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    LinkVideo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Class_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserClassConcluded_ClassId",
                table: "UserClassConcluded",
                column: "ClassId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Class_ModuleId",
                table: "Class",
                column: "ModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClassConcluded_Class_ClassId",
                table: "UserClassConcluded",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
