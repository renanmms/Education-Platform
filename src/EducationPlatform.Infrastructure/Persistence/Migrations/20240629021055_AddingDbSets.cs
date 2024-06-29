using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationPlatform.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddingDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentSubscription_UserSubscription_UserSubscriptionId",
                table: "PaymentSubscription");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClassConcluded_Classes_ClassId",
                table: "UserClassConcluded");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClassConcluded_Users_UserId",
                table: "UserClassConcluded");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscription_Subscriptions_SubscriptionId",
                table: "UserSubscription");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscription_Users_UserId",
                table: "UserSubscription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSubscription",
                table: "UserSubscription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClassConcluded",
                table: "UserClassConcluded");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentSubscription",
                table: "PaymentSubscription");

            migrationBuilder.RenameTable(
                name: "UserSubscription",
                newName: "UserSubscriptions");

            migrationBuilder.RenameTable(
                name: "UserClassConcluded",
                newName: "FinishedClasses");

            migrationBuilder.RenameTable(
                name: "PaymentSubscription",
                newName: "PaymentSubscriptions");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubscription_UserId",
                table: "UserSubscriptions",
                newName: "IX_UserSubscriptions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubscription_SubscriptionId",
                table: "UserSubscriptions",
                newName: "IX_UserSubscriptions_SubscriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClassConcluded_UserId",
                table: "FinishedClasses",
                newName: "IX_FinishedClasses_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClassConcluded_ClassId",
                table: "FinishedClasses",
                newName: "IX_FinishedClasses_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentSubscription_UserSubscriptionId",
                table: "PaymentSubscriptions",
                newName: "IX_PaymentSubscriptions_UserSubscriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSubscriptions",
                table: "UserSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinishedClasses",
                table: "FinishedClasses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentSubscriptions",
                table: "PaymentSubscriptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FinishedClasses_Classes_ClassId",
                table: "FinishedClasses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FinishedClasses_Users_UserId",
                table: "FinishedClasses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentSubscriptions_UserSubscriptions_UserSubscriptionId",
                table: "PaymentSubscriptions",
                column: "UserSubscriptionId",
                principalTable: "UserSubscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubscriptions_Subscriptions_SubscriptionId",
                table: "UserSubscriptions",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubscriptions_Users_UserId",
                table: "UserSubscriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinishedClasses_Classes_ClassId",
                table: "FinishedClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_FinishedClasses_Users_UserId",
                table: "FinishedClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentSubscriptions_UserSubscriptions_UserSubscriptionId",
                table: "PaymentSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscriptions_Subscriptions_SubscriptionId",
                table: "UserSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscriptions_Users_UserId",
                table: "UserSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSubscriptions",
                table: "UserSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentSubscriptions",
                table: "PaymentSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FinishedClasses",
                table: "FinishedClasses");

            migrationBuilder.RenameTable(
                name: "UserSubscriptions",
                newName: "UserSubscription");

            migrationBuilder.RenameTable(
                name: "PaymentSubscriptions",
                newName: "PaymentSubscription");

            migrationBuilder.RenameTable(
                name: "FinishedClasses",
                newName: "UserClassConcluded");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubscriptions_UserId",
                table: "UserSubscription",
                newName: "IX_UserSubscription_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubscriptions_SubscriptionId",
                table: "UserSubscription",
                newName: "IX_UserSubscription_SubscriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentSubscriptions_UserSubscriptionId",
                table: "PaymentSubscription",
                newName: "IX_PaymentSubscription_UserSubscriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_FinishedClasses_UserId",
                table: "UserClassConcluded",
                newName: "IX_UserClassConcluded_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FinishedClasses_ClassId",
                table: "UserClassConcluded",
                newName: "IX_UserClassConcluded_ClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSubscription",
                table: "UserSubscription",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentSubscription",
                table: "PaymentSubscription",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClassConcluded",
                table: "UserClassConcluded",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentSubscription_UserSubscription_UserSubscriptionId",
                table: "PaymentSubscription",
                column: "UserSubscriptionId",
                principalTable: "UserSubscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_UserSubscription_Subscriptions_SubscriptionId",
                table: "UserSubscription",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
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
    }
}
