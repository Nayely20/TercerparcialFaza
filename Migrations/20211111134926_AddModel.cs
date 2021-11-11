using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFaza.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Muebles",
                columns: table => new
                {
                    Mueble = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Precio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enlace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muebles", x => x.Mueble);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Muebles");
        }
    }
}
