namespace decimoPrimeiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              11) Escreva um algoritmo para ler o número de eleitores de um município, 
                o número de votos brancos, nulos e válidos. 
                Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.
             
             */

            int quantidadeDeEleitoresNoMunicipio;
            int quantidadeDeVotosEmBranco;
            int quantidadeDeVotosNulos;
            int quantidadeDeVotosValidos;
            int quantidadeTotalDeVotos;
            string resultado;

            Console.Write("Quantidade de eleitores do município: ");
             quantidadeDeEleitoresNoMunicipio = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de votos em branco: ");
             quantidadeDeVotosEmBranco = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de votos nulos: ");
             quantidadeDeVotosNulos = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de votos válidos: ");
            quantidadeDeVotosValidos = int.Parse(Console.ReadLine());

            quantidadeTotalDeVotos = (quantidadeDeVotosEmBranco + quantidadeDeVotosNulos + quantidadeDeVotosValidos);

            resultado = $"\nVotos em branco: {( (quantidadeTotalDeVotos  * quantidadeDeVotosEmBranco ) / quantidadeDeEleitoresNoMunicipio).ToString("0.0")}%" +
                $"\nVotos nulos: {( (quantidadeTotalDeVotos * quantidadeDeVotosNulos ) / quantidadeDeEleitoresNoMunicipio).ToString("0.0")}%"+
                $"\nVotos válidos: {((quantidadeTotalDeVotos * quantidadeDeVotosValidos) / quantidadeDeEleitoresNoMunicipio).ToString("0.0")}%";

            Console.WriteLine(resultado);

            Console.ReadKey();
             
        }
    }
}