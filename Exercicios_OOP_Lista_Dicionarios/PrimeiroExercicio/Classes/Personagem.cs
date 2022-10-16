using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroExercicio.Classes
{
    class Personagem
    {
        public string Nome { get; private set; }
        public int Poder { get;  private set; }

        private List<Personagem> personagens = new List<Personagem>();
        public Personagem() { }

        public Personagem(string nome, int poder)
        {
            this.Nome = nome;
            this.Poder = poder;
            personagens.Add(this);
        }
        public void AddPersonagens(string nome, int poder)
        {
            personagens.Add(new(nome, poder));
        }

       public void ExibirDados()
       {
            Console.Clear();
            int poder = 0;
            string resultado = "";

            personagens.ForEach((personagem) =>
            {
                if(personagem.Poder > poder)
                {
                    poder = personagem.Poder;
                    resultado = $"\nPersonagem de maior poder\nPersonagem: {personagem.Nome} Poder: {personagem.Poder}";
                }
            });
            Console.WriteLine(resultado);
       } 
    }
}
