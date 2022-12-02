using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIExercicio.Migrations
{
    /// <inheritdoc />
    public partial class atulizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Cursos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_AlunoId",
                table: "Cursos",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Alunos_AlunoId",
                table: "Cursos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Alunos_AlunoId",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_AlunoId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Cursos");
        }
    }
}
