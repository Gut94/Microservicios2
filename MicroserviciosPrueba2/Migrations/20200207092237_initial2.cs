using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroserviciosPrueba2.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParkingDats",
                columns: table => new
                {
                    nombre = table.Column<string>(nullable: false),
                    nplazascoche = table.Column<int>(nullable: false),
                    nplazasmoto = table.Column<int>(nullable: false),
                    colorSel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingDats", x => x.nombre);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkingDats");
        }
    }
}
