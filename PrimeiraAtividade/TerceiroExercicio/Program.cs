namespace TerceiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
            //si os valores de duas variáveis A e B.

            int A = 10;
            int B = 20;
            int temporaria;
            Console.WriteLine($"Valor de A: {A}. Valor de B: {B}");

            temporaria = A; // guarda o valor de A, pra nao ficar valores repetidos e, sim o valor original de A;
            A = B;
            B = temporaria;
            
            Console.WriteLine($"Valores Trocados,  \nA: {A}. B: {B}");

        }
    }
}