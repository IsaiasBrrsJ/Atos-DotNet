using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec001
{
     class Paciente
    {
      public string nome { get; private set; }
      public DateTime dataNascimento { get;private set; }
      public string cpf { get; private set; }

        public Paciente(string nome, DateTime dataNascimento, string cpf)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
        }
    }
}
