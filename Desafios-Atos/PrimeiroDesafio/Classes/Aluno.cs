using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroDesafio.Classes
{
     class Aluno : Pessoa
    {
        private string _matricula;
        private string _codCurso;
        private string _nomeCurso;

        public Aluno(string nome, string telefone, string cidade, string RG, string CPF,
        string matricula, string codCurso, string nomeCuros) : base(nome, telefone, cidade, RG, CPF)
        {
            _matricula = matricula;
            _codCurso = codCurso;
            _nomeCurso = nomeCuros;
        }

        public string getMatricula() => _matricula;
        public string getCodCurso() => _codCurso; 
        public string getNomeCurso() => _nomeCurso; 
    }
}
