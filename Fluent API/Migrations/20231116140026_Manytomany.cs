using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fluent_API.Migrations
{
    /// <inheritdoc />
    public partial class Manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Persons_PersonInfoId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_PersonInfoId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PersonInfoId",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "PersonCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    PersonRustamId = table.Column<int>(type: "int", nullable: false),
                    CarRustamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonCars_Cars_CarRustamId",
                        column: x => x.CarRustamId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonCars_Persons_PersonRustamId",
                        column: x => x.PersonRustamId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonCars_CarRustamId",
                table: "PersonCars",
                column: "CarRustamId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonCars_PersonRustamId",
                table: "PersonCars",
                column: "PersonRustamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonCars");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonInfoId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
