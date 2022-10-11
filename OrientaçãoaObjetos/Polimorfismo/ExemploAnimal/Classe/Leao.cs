using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAnimal.Classe{
    internal class Leao : Animal {
        public Leao(string nome, string raca, string sexo) : base(nome, raca, sexo) {
        }

        public override void EmitirSom() {

            Console.WriteLine("Leão Rugindo");
        }
    }
}
