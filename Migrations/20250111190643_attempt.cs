using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorldCup.Migrations
{
    /// <inheritdoc />
    public partial class attempt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tableFootballs_stadiums_StadiumId",
                table: "tableFootballs");

            migrationBuilder.DropForeignKey(
                name: "FK_transportation_transportations_TransportationCategories",
                table: "transportation");

            migrationBuilder.DropIndex(
                name: "IX_transportation_TransportationCategories",
                table: "transportation");

            migrationBuilder.DropIndex(
                name: "IX_tableFootballs_StadiumId",
                table: "tableFootballs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_transportations",
                table: "transportations");

            migrationBuilder.DropColumn(
                name: "StadiumId",
                table: "tableFootballs");

            migrationBuilder.RenameTable(
                name: "transportations",
                newName: "transportationcategoriess");

            migrationBuilder.RenameColumn(
                name: "TransportationCategories",
                table: "transportation",
                newName: "vehicle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_transportationcategoriess",
                table: "transportationcategoriess",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_transportationcategoriess",
                table: "transportationcategoriess");

            migrationBuilder.RenameTable(
                name: "transportationcategoriess",
                newName: "transportations");

            migrationBuilder.RenameColumn(
                name: "vehicle",
                table: "transportation",
                newName: "TransportationCategories");

            migrationBuilder.AddColumn<int>(
                name: "StadiumId",
                table: "tableFootballs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_transportations",
                table: "transportations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_transportation_TransportationCategories",
                table: "transportation",
                column: "TransportationCategories");

            migrationBuilder.CreateIndex(
                name: "IX_tableFootballs_StadiumId",
                table: "tableFootballs",
                column: "StadiumId");

            migrationBuilder.AddForeignKey(
                name: "FK_tableFootballs_stadiums_StadiumId",
                table: "tableFootballs",
                column: "StadiumId",
                principalTable: "stadiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transportation_transportations_TransportationCategories",
                table: "transportation",
                column: "TransportationCategories",
                principalTable: "transportations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
