using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JWTTokendemo.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TaskManagers_StatusId",
                table: "TaskManagers",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskManagers_UserId",
                table: "TaskManagers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskManagers_Statuses_StatusId",
                table: "TaskManagers",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskManagers_Users_UserId",
                table: "TaskManagers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskManagers_Statuses_StatusId",
                table: "TaskManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskManagers_Users_UserId",
                table: "TaskManagers");

            migrationBuilder.DropIndex(
                name: "IX_TaskManagers_StatusId",
                table: "TaskManagers");

            migrationBuilder.DropIndex(
                name: "IX_TaskManagers_UserId",
                table: "TaskManagers");
        }
    }
}
