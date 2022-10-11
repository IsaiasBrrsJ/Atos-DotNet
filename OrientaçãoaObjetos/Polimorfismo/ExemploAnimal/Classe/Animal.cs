using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAnimal.Classe {
    abstract class Animal {
        protected string nome;
        protected string raca;
        protected string sexo;

        public Animal(string nome, string raca, string sexo) {
            this.nome = nome;
            this.raca = raca;
            this.sexo = sexo;
        }

        public abstract void EmitirSom();

        public void Caminhar() {
            Console.WriteLine("Caminhando");
        }

        public void Dormir() {
            Console.WriteLine("Dormindo");
        }

        public void ExibirDados() {
            Console.WriteLine("Nome: " + nome + " Raça: " + raca + " Sexo: " + sexo);
        }

    }
}
