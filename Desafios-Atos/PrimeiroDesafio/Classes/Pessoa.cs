using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroDesafio.Classes
{
    class Pessoa
    {
        private string _nome;
        private string _telefone;
        private string _cidade;
        private string _RG;
        private string _CPF;

        public Pessoa(string nome, string telefone, string cidade, string rG, string cPF)
        {
            _nome = nome;
            _telefone = telefone;
            _cidade = cidade;
            _RG = rG;
            _CPF = cPF;
        }

        public string getNome() => _nome;
        public string getTelefone() => _telefone;
        public string getCidade() => _cidade;  
        public string getRG() => _RG;
        public string getCPF() => _CPF;
    }
}
