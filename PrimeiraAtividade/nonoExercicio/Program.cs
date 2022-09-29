namespace nonoExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
              9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
                do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
                Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
                se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
                Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
                da entrada e das duas prestações, de acordo com as regras acima. 
                Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
                conseqüente pagamento dos boletos das duas prestações.
             */

            double valorMercadoria; 
            double restoDivisao;
            double entradaInicial;
            double parcelasRestantes;
            string resultado;

            Console.Write("Valor da mercadoria: ");
            valorMercadoria = double.Parse(Console.ReadLine());

            restoDivisao = valorMercadoria % 3;

            entradaInicial = ((valorMercadoria - restoDivisao) / 3) + restoDivisao;
            parcelasRestantes = ((valorMercadoria - restoDivisao) / 3);

            resultado = ( "\nValor do produto: " + valorMercadoria.ToString("C") + "\nEntrada Inicial: "
           + entradaInicial.ToString("C") + "\nPrimeira Parcela: " + parcelasRestantes.ToString("C") + "\nSegunda Parcela: " + parcelasRestantes.ToString("C"));;

            Console.WriteLine(resultado);

            Console.ReadKey();


        }
    }
}