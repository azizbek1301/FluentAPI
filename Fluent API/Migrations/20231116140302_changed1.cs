using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fluent_API.Migrations
{
    /// <inheritdoc />
    public partial class changed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonCars_Cars_CarRustamId",
                table: "PersonCars");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonCars_Persons_PersonRustamId",
                table: "PersonCars");

            migrationBuilder.DropIndex(
                name: "IX_PersonCars_CarRustamId",
                table: "PersonCars");

            migrationBuilder.DropIndex(
                name: "IX_PersonCars_PersonRustamId",
                table: "PersonCars");

            migrationBuilder.DropColumn(
                name: "CarRustamId",
                table: "PersonCars");

            migrationBuilder.DropColumn(
                name: "PersonRustamId",
                table: "PersonCars");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCars_CarId",
                table: "PersonCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCars_PersonId",
                table: "PersonCars",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonCars_Cars_CarId",
                table: "PersonCars",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonCars_Persons_PersonId",
                table: "PersonCars",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonCars_Cars_CarId",
                table: "PersonCars");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonCars_Persons_PersonId",
                table: "PersonCars");

            migrationBuilder.DropIndex(
                name: "IX_PersonCars_CarId",
                table: "PersonCars");

            migrationBuilder.DropIndex(
                name: "IX_PersonCars_PersonId",
                table: "PersonCars");

            migrationBuilder.AddColumn<int>(
                name: "CarRustamId",
                table: "PersonCars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonRustamId",
                table: "PersonCars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PersonCars_CarRustamId",
                table: "PersonCars",
                column: "CarRustamId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCars_PersonRustamId",
                table: "PersonCars",
                column: "PersonRustamId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonCars_Cars_CarRustamId",
                table: "PersonCars",
                column: "CarRustamId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonCars_Persons_PersonRustamId",
                table: "PersonCars",
                column: "PersonRustamId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
