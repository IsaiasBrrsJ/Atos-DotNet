using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace APIExercicio.DataModels
{
    public class Aluno
    {
      
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }


        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<Matricula> Matriculas { get; set; }  

    }
}
