using TerceiroExercicio.Classes;

namespace TerceiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

             3) Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções.
                Dessa forma, crie um programa em C# que represente
                uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos
                (privados) posição x, posição y (do asteroide em
                um plano cartesiano), tamanho do asteroide (1 a 10), velocidade do asteroide (1 a 5) e energia (1 a 5).
                Para esses atributos privados, gerar os métodos de acesso
                (propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio,
                outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
                terceiro que constrói um asteroide com posição x e posição y. 
                O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário.
                Nesse programa principal, construir um método de classe que exiba todos os
                asteróides da lista.

             */

            List<Asteroide> asteroide = new List<Asteroide>();
 
            TAMANHOASTEROIDE: // Usando um goto para caso nao atenda o requisito volta aqui;
            CONTINUARCADASTRANDO:
            Console.Clear();
            Console.Write("Tamanho Asteroide (1 a 10): ");
             int tamanho = int.Parse(Console.ReadLine());

            if(tamanho < 1 || tamanho > 10) { goto TAMANHOASTEROIDE; }

            VELOCIDADEASTEROIDE:
            Console.Write("Velocidade Asteroide (1 a 5): ");
             int velocidade = int.Parse(Console.ReadLine());

            if (velocidade < 1 || velocidade > 5) { goto VELOCIDADEASTEROIDE; }

            ENERGIAASTEROIDE:
            Console.Write("Energia Asteroide (1 a 5): ");
            int energia = int.Parse(Console.ReadLine());

            if (energia < 1 || energia > 5) { goto ENERGIAASTEROIDE; }

            asteroide.Add(new Asteroide(posicao_X: new Random().NextDouble(), posicao_Y:new Random().NextDouble())// construtor  da classe Asteroide
            { EnergiaAsteroide = energia, TamanhoAsteroide = tamanho, VelocidadeAsteroide = velocidade }); // propiedades da classe Asteroide;

             Console.WriteLine("Continuar cadastrando ? (1-Sim/2-Nao): ");
              if( int.Parse(Console.ReadLine()) == 1) { goto CONTINUARCADASTRANDO;  }

            Console.WriteLine("\n=======ASTEROIDES=======\n");
            int cont = 1;
            foreach (var item in asteroide)
            {
                Console.WriteLine($"\n{cont}º Asteroide");
                Console.WriteLine("Energia: "+item.EnergiaAsteroide);
                Console.WriteLine("Velocidade: "+item.VelocidadeAsteroide);
                Console.WriteLine("Tamanho: "+item.TamanhoAsteroide);
                Console.WriteLine($"Coordenada X: {item.Posicao_X.ToString("F2")} Coordenada Y: {item.Posicao_Y.ToString("F2")}");
                cont++;
            }


            Console.ReadKey();
        }
    }
}