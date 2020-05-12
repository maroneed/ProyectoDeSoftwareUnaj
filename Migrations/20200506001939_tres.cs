using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticaORM.Migrations
{
    public partial class tres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Estudiantes",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Cursos",
                newName: "nombre");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Profesores",
                type: "varchar(45)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Estudiantes",
                type: "varchar(45)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Cursos",
                type: "varchar(45)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Estudiantes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Cursos",
                newName: "Nombre");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Profesores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Estudiantes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Cursos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldNullable: true);
        }
    }
}
