using Microsoft.OpenApi.Writers;
using System.Text.Json.Serialization;

namespace APIExercicio.DataModels
{
    public class Curso
    {   
        public int Id { get; set; }

        public string NomeCurso { get; set; }
        
        public int CargaHoraria { get; set; }

        public string Turno { get; set; }

        [JsonIgnore]
        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}
