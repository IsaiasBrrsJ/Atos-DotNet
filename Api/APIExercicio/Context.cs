using APIExercicio.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace APIExercicio
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = @"Data Source=localhost;initial Catalog=ApiExec;User ID=ApiExec;password=execApi;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;";
            
            optionsBuilder.UseSqlServer(con);
        
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        
        public DbSet<Matricula> Matriculas { get; set; }
    }
}
