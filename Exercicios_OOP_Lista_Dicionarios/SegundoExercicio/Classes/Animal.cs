using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoExercicio.Classes
{
    class Animal
    {
        private string _nome;
        private string _tipo;
        private List<Animal> animalList = new List<Animal>();
        public string Nome
        {
            get { return _nome; }
            set {
                _nome = value; 
            }
        }

        public string Tipo
        {
            get { return _tipo; }
            set { 
                _tipo = value;
            }
        }

        public void ExibirContagemAnimais()
        {
            Console.WriteLine("\n===================\nContagem dos Animais\n===================\n");
            Console.WriteLine($"Gatos cadastrados: {animalList.Count((animal) => animal.Tipo is "GATO")}");
            Console.WriteLine($"Cachorros cadastrados: {animalList.Count((animal) => animal.Tipo is "CACHORRO")}");
            Console.WriteLine($"Peixes cadastrados: {animalList.Count((animal) => animal.Tipo is "PEIXE")}");
        }

        public void AdcionarAnimais()
        {
            animalList.Add(new Animal(){ _nome = Nome, _tipo = Tipo}); // quando  nao temos construtor,  maneira que injetamos um novo animal na lista
        }
    }
}
