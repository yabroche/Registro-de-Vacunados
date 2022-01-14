using Microsoft.EntityFrameworkCore.Migrations;

namespace Registro_de_Vacunados.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RvacunadosTab",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ci = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dosis1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lote1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dosis2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lote2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dosis3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lote3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Refuerzo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRefuerzo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoteRefuerzo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    progreso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RvacunadosTab", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RvacunadosTab");
        }
    }
}
