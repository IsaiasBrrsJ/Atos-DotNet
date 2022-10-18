using System;

namespace TryCath
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            

            // tryCath boa prática, evitar erros
            try
            {//Tentar executar essa linha

                int x = 0;
                Console.WriteLine("Informe um valor para X: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("O valor de X é " + x);
                Console.WriteLine("O valor 50 divido por "+x+" resulta em "+ (50/x));
                //se der erro cai pra linha de baixo
            }
            catch (OverflowException ex) // numero além da capacidade da variável
            {
                Console.WriteLine("Numero largo");
            }
            catch(DivideByZeroException ex) // divisao por zero erro
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            catch(FormatException ex)// quando digita string e nao inteiro
            {
                Console.WriteLine("Apenas números devem ser digitados");
            }
            catch (Exception ex) // pega uma excessao, erro não tratado
            {
               // Exception generico;
                Console.WriteLine(ex.Message);
            }
            finally //opcional
            {
                //finally vai executar sempre dando certo ou não
                //fechar conexão com o banco
            }
           





            Console.ReadKey();
        }
    }
}