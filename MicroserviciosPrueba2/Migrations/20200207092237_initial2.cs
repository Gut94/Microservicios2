using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroserviciosPrueba2.Migrations
{
    /*
     * En tools/nuget console ¿obsoleto?
     * PM> enable-migrations //esto te crea este archivo
     * PM> add-migrations initial //si quiero meter otra tabla lo repito cambiando el nombre initial
     * PM> update-database
     */
     //solo hace falta add-migration y update-database
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
