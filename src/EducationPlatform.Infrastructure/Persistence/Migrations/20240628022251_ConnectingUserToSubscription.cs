using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationPlatform.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ConnectingUserToSubscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_UserClassConcluded_UserClassConcludedId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_UserClassConcludedId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "UserClassConcludedId",
                table: "Classes");

            migrationBuilder.CreateTable(
                name: "PaymentSubscription",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProcessingDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<int>(type: "integer", nullable: false),
                    UserSubscriptionId = table.Column<Guid>(type: "uuid", nullable: false),
                    PaymentLink = table.Column<string>(type: "text", nullable: true),
                    ExternalPaymentId = table.Column<string>(type: "text", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSubscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentSubscription_UserSubscription_UserSubscriptionId",
                        column: x => x.UserSubscriptionId,
                        principalTable: "UserSubscription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscription_UserId",
                table: "UserSubscription",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClassConcluded_ClassId",
                table: "UserClassConcluded",
                column: "ClassId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClassConcluded_UserId",
                table: "UserClassConcluded",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSubscription_UserSubscriptionId",
                table: "PaymentSubscription",
                column: "UserSubscriptionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClassConcluded_Classes_ClassId",
                table: "UserClassConcluded",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClassConcluded_Users_UserId",
                table: "UserClassConcluded",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubscription_Users_UserId",
                table: "UserSubscription",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClassConcluded_Classes_ClassId",
                table: "UserClassConcluded");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClassConcluded_Users_UserId",
                table: "UserClassConcluded");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscription_Users_UserId",
                table: "UserSubscription");

            migrationBuilder.DropTable(
                name: "PaymentSubscription");

            migrationBuilder.DropIndex(
                name: "IX_UserSubscription_UserId",
                table: "UserSubscription");

            migrationBuilder.DropIndex(
                name: "IX_UserClassConcluded_ClassId",
                table: "UserClassConcluded");

            migrationBuilder.DropIndex(
                name: "IX_UserClassConcluded_UserId",
                table: "UserClassConcluded");

            migrationBuilder.AddColumn<Guid>(
                name: "UserClassConcludedId",
                table: "Classes",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UserClassConcludedId",
                table: "Classes",
                column: "UserClassConcludedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_UserClassConcluded_UserClassConcludedId",
                table: "Classes",
                column: "UserClassConcludedId",
                principalTable: "UserClassConcluded",
                principalColumn: "Id");
        }
    }
}
