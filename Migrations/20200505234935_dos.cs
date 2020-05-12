using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticaORM.Migrations
{
    public partial class dos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "cursoId",
                table: "Estudiantes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "cursoNavigatorCursoId",
                table: "Estudiantes",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "profesorId",
                table: "Cursos",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "profesorNavigatorprofesorID",
                table: "Cursos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Profesores",
                columns: table => new
                {
                    profesorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    sueldo = table.Column<decimal>(type: "decimal(15, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesores", x => x.profesorID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_cursoNavigatorCursoId",
                table: "Estudiantes",
                column: "cursoNavigatorCursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_profesorNavigatorprofesorID",
                table: "Cursos",
                column: "profesorNavigatorprofesorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Profesores_profesorNavigatorprofesorID",
                table: "Cursos",
                column: "profesorNavigatorprofesorID",
                principalTable: "Profesores",
                principalColumn: "profesorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Cursos_cursoNavigatorCursoId",
                table: "Estudiantes",
                column: "cursoNavigatorCursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Profesores_profesorNavigatorprofesorID",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Cursos_cursoNavigatorCursoId",
                table: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Profesores");

            migrationBuilder.DropIndex(
                name: "IX_Estudiantes_cursoNavigatorCursoId",
                table: "Estudiantes");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_profesorNavigatorprofesorID",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "cursoId",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "cursoNavigatorCursoId",
                table: "Estudiantes");

            migrationBuilder.DropColumn(
                name: "profesorId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "profesorNavigatorprofesorID",
                table: "Cursos");
        }
    }
}
