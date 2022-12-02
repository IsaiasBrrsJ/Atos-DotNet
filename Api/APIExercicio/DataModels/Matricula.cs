
using System.Text.Json.Serialization;

namespace APIExercicio.DataModels
{
    public class Matricula
    {
    
        public int Id { get; set; }
        public string Ra { get; set; }


        [JsonIgnore]

        public virtual Aluno Aluno { get; set; }
        public int AlunoId { get; set; }

    }
}
