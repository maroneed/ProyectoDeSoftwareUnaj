using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticaORM.Migrations
{
    public partial class cuatro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Profesores",
                columns: new[] { "profesorID", "nombre", "sueldo" },
                values: new object[] { 1, "guepardo", 15000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Profesores",
                keyColumn: "profesorID",
                keyValue: 1);
        }
    }
}
