using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCorePeliculas.Migrations
{
    public partial class inicialCorregidoNombrePropiedades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TiposalaDeCine",
                table: "SalasDeCine",
                newName: "TipoSalaDeCine");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Actores",
                newName: "Nombre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoSalaDeCine",
                table: "SalasDeCine",
                newName: "TiposalaDeCine");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Actores",
                newName: "nombre");
        }
    }
}
