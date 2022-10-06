using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois {
    internal class Pessoa {

        private string Nome;
        private float Altura;
        private int Idade;
        private string CorDosOlhos;
        private string TipoCabelo;
        private string CorDoCabelo;
        private string CorDaPele;

        public Pessoa(string nome, float altura, int idade, string corDosOlhos, string tipoDeCabelo,
                      string corDoCabelo, string corDaPele)
        {
            Nome = nome;
            Altura = altura;
            Idade = idade;
            CorDosOlhos = corDosOlhos;
            TipoCabelo = tipoDeCabelo;
            CorDoCabelo = corDoCabelo;
            CorDaPele = corDaPele;
        }

        public void ExibirAtributos() {
            Console.WriteLine($"\nNome: {Nome}"+
                $"\nAltura: {Altura}" +
                $"\nIdade: {Idade}" +
                $"\nCor dos olhos: {CorDosOlhos}" +
                $"\nTipo de cabelo: {TipoCabelo}" +
                $"\nCor do cabelo: {CorDoCabelo}" +
                $"\nCor da sua pele: {CorDaPele}");
        }

    }
}
