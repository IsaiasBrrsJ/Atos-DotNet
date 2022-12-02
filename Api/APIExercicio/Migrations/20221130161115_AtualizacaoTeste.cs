using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIExercicio.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoTeste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AlunoCurso",
                columns: table => new
                {
                    AlunosId = table.Column<int>(type: "int", nullable: false),
                    CursosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoCurso", x => new { x.AlunosId, x.CursosId });
                    table.ForeignKey(
                        name: "FK_AlunoCurso_Alunos_AlunosId",
                        column: x => x.AlunosId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoCurso_Cursos_CursosId",
                        column: x => x.CursosId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoCurso_CursosId",
                table: "AlunoCurso",
                column: "CursosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoCurso");

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
    }
}
