namespace decimoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*              
             10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
             para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
             realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
             notas de menor valor fossem distribuídas em número mínimo possível. 
             Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
             uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
             Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
            de acordo com o critério da “distribuição ótima”. 
            */


            double valorDaQuantidadeSolicitada;
            string resultado;
            double
                notaDe100,
                notaDe50,
                notaDe20,
                notaDe10,
                notaDe5,
                notaDe2,
                notaDe1,
                restoDivisao;


            Console.Write("Valor que deseja sacar: ");
             valorDaQuantidadeSolicitada = double.Parse(Console.ReadLine());

            restoDivisao= valorDaQuantidadeSolicitada % 100; 
            notaDe100 = (Convert.ToInt32(valorDaQuantidadeSolicitada) / 100); 

            notaDe50 = (Convert.ToInt32(restoDivisao) / 50);
            restoDivisao = restoDivisao % 50;

            notaDe20 = (Convert.ToInt32(restoDivisao) / 20);
            restoDivisao = restoDivisao % 20;

            notaDe10 = (Convert.ToInt32(restoDivisao) / 10);
            restoDivisao = restoDivisao % 10;

            notaDe5 = (Convert.ToInt32(restoDivisao) / 5);
            restoDivisao = restoDivisao % 5;

            notaDe2 = (Convert.ToInt32(restoDivisao) / 2);
            restoDivisao = restoDivisao % 2;
            notaDe1 = (Convert.ToInt32(restoDivisao) / 1);

            resultado = $"\nValor requerido: {valorDaQuantidadeSolicitada.ToString("C")}" +
                $"\n{notaDe100}   nota(s) de R$ 100,00" +
                $"\n{notaDe50}   nota(s) de R$ 50,00" +
                $"\n{notaDe20}   nota(s) de R$ 20,00" +
                $"\n{notaDe10}   nota(s) de R$ 10,00" +
                $"\n{notaDe5}   nota(s) de R$ 5,00" +
                $"\n{notaDe2}   nota(s) de R$ 2,00" +
                $"\n{notaDe1}   nota(s) de R$ 1,00";
            


            Console.WriteLine(resultado);
            Console.ReadKey();

           



        }
    }
}