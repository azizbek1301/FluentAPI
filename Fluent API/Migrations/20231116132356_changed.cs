using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fluent_API.Migrations
{
    /// <inheritdoc />
    public partial class changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Persons_PersonId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_PersonId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Cars");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_PersonInfoId",
                table: "Cars",
                column: "PersonInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Persons_PersonInfoId",
                table: "Cars",
                column: "PersonInfoId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Persons_PersonInfoId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_PersonInfoId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_PersonId",
                table: "Cars",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Persons_PersonId",
                table: "Cars",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
