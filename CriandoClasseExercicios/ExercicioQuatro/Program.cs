using ExercicioQuatro.Classes;
using System.Reflection.PortableExecutable;

namespace ExercicioQuatro {
    internal class Program {
        static void Main(string[] args) {


            //4 - Faça um programa que represente a arvore genealógica da tua familia. Para isso,
            //uma classe Pessoa precisa ser indicar quem são seus pais, alem de informações básicas sobre a pessoa.


            Pessoa filho = new Pessoa();
            filho.nome = "Isaias";
            filho.sobrenome = "Jesus";
            filho.altura = 1.65;
            filho.idade = 24;

            Pessoa mae = new Pessoa();
            mae.nome = "Elieci";
            mae.sobrenome = "Jesus";
            mae.altura = 1.65;
            mae.idade = 45;

            Pessoa pai = new Pessoa();
            pai.nome = "Raimundo";
            pai.sobrenome = "Nonato";
            pai.altura = 1.77;
            pai.idade = 44;

            Pessoa avo = new Pessoa();
            avo.nome = "Raimundo";
            avo.sobrenome = "Ferreira";
            avo.altura = 1.77;
            avo.idade = 69;

            filho.mae = mae;
            filho.pai = pai;
            mae.pai = avo;
            
            

            Console.ReadKey();


        }
    }
}