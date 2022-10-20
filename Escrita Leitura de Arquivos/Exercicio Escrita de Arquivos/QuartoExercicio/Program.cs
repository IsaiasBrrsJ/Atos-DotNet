using QuartoExercicio.Classes;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace QuartoExercicio
{
    internal class Program
    {   
         static string caminhoFigurasFaltantesCSV = @"D:\Atos-Codigos\Escrita Leitura de Arquivos\Exercicio Escrita de Arquivos\QuartoExercicio\Arquivos\FiguraFaltantes.csv";
         static string caminhoFigurasRepetidasCSV = @"D:\Atos-Codigos\Escrita Leitura de Arquivos\Exercicio Escrita de Arquivos\QuartoExercicio\Arquivos\FiguraRepetidas.csv";
         static string caminhoFigurasFaltantesTXT = @"D:\Atos-Codigos\Escrita Leitura de Arquivos\Exercicio Escrita de Arquivos\QuartoExercicio\Arquivos\FigurasFaltantes.txt";
         static string caminhoFigurasRepetidasTXT = @"D:\Atos-Codigos\Escrita Leitura de Arquivos\Exercicio Escrita de Arquivos\QuartoExercicio\Arquivos\FigurasRepetidas.txt";

        static void Main(string[] args)
        {
            /*
             3. Fazer um programa em VS para gerenciar figurinhas da copa. O programa deve possuir um Menu 

                Menu
                1 - Cadastrar figurinha repetida
                2 - Cadastrar figurinha faltante
                3 - Listar figurinhas repetidas
                4 - Listar figurinhas faltantes
                5 - Sair
                Opção:

                Para este programa, usar a classe Figurinha (codigo_figurinha, selecao, nome_jogador), lista que armazena as figurinhas em memória,
                arquivo .csv com os dados das figurinhas persistidos em disco.

                Para as figurinhas repetidas, deve haver uma lista e um arquivo .csv; o mesmo para as figurinhas faltantes.
               Toda vez que as opções 3 ou 4 foram selecionadas,
                além da listagem na tela, gerar um arquivo de saída com os mesmos dados da tela. Esse arquivo é o utilizado para mandar aos amigos.


                nos arquivos .csv. Por exemplo, arquivo de figurinhas repetidas, repetidas.csv

                codigo figurinha;seleçao;nome do jogador 
                codigo figurinha;seleçao;nome do jogador 
                codigo figurinha;seleçao;nome do jogador 
                codigo figurinha;seleçao;nome do jogador 
                codigo figurinha;seleçao;nome do jogador 
             
             */
            
           
            List<Figurinha> figuraRepetida = new List<Figurinha>();
            List<Figurinha> figuraFaltando = new List<Figurinha>();

           Util.PopularListaFigurasRepetidas(ref figuraRepetida, caminhoFigurasRepetidasCSV);
           Util.PopularListaFigurasFaltantes(ref figuraFaltando, caminhoFigurasFaltantesCSV);

            Menu(ref figuraRepetida, ref figuraFaltando);

        }
        static void Menu(ref List<Figurinha> repetida, ref List<Figurinha> faltando)
        {
           
            while (true)
            {   
                Console.Clear();

                Console.WriteLine("Menu\n");

                Console.WriteLine("1 - Cadastrar figurinha repetida");
                Console.WriteLine("2 - Cadastrar figurinha faltante");
                Console.WriteLine("3 - Listar figurinhas repetidas");
                Console.WriteLine("4 - Listar figurinhas faltantes");
                Console.WriteLine("5 - Remover Figura Faltante");
                Console.WriteLine("6 - Sair");
                Console.Write("\nOpção: ");
                string opc = Console.ReadLine();

                if(opc == "6")
                {
                    Environment.Exit(0);
                }
                else if(opc == "1")
                {
                    CadastrarFiguraRepetida(ref repetida);
                }
                else if(opc == "2")
                {
                    CadastrarFiguraFaltante(ref faltando, ref repetida);
                }
                else if( opc == "3")
                {
                    Util.ListagemDados(listFigura: ref repetida, caminhoArquivo: caminhoFigurasRepetidasTXT, tipo: "Repetidas\n");
                }
                else if(opc == "4")
                {
                    Util.ListagemDados(listFigura: ref faltando, caminhoArquivo: caminhoFigurasFaltantesTXT, tipo: "Faltantes\n");
                }
                else if(opc == "5")
                {
                    Util.RemoverFaltante(ref faltando, caminhoFigurasFaltantesTXT, caminhoFigurasFaltantesCSV);
                    
                }
            }
        }


        private static void CadastrarFiguraFaltante(ref List<Figurinha> faltando, ref List<Figurinha> repetida)
        {
            
            Console.Write("Código da figura: ");
            string codFigura = Console.ReadLine();

            var contem = false;
            faltando.ForEach((p) =>
            {
                if(p.getCodFigura() == codFigura)
                {
                    contem = true;
                }
            });

            if (Util.VerificaSeExisteNaLista(ref repetida, codFigura) || contem)
            {   
                Console.WriteLine("Figura já cadastrada, pressione para voltar ao menu");
            }
            else
            {
                Console.Write("Seleção: ");
                string selecao = Console.ReadLine();

                Console.WriteLine("Nome do jogador: ");
                string nomeJogador = Console.ReadLine();

                Figurinha figura = new Figurinha(codFigura, selecao, nomeJogador);

                faltando.Add(figura);

                Util.PersistirRepetidaEmMemoria(figura, caminhoFigurasFaltantesCSV);
                Console.WriteLine("Figura cadastrada com sucesso, pressione para voltar ao menu");

            }

            Console.ReadKey();

        }

        static void CadastrarFiguraRepetida(ref List<Figurinha> listFiguraRepetida)
        {
            Console.Write("Código da figura: ");
            string codFigura = Console.ReadLine();

            if(Util.VerificaSeExisteNaLista(ref listFiguraRepetida, codFigura))
            {
                Console.WriteLine("Figura já cadastrada, pressione para voltar ao menu");
                
            }
            else { 
                Console.Write("Seleção: ");
                string selecao = Console.ReadLine();

                Console.WriteLine("Nome do jogador: ");
                string nomeJogador = Console.ReadLine();

                Figurinha figura = new Figurinha(codFigura, selecao, nomeJogador);

                listFiguraRepetida.Add(figura);

                Util.PersistirRepetidaEmMemoria(figura, caminhoFigurasRepetidasCSV);
                Console.WriteLine("Figura cadastrada com sucesso, pressione para voltar ao menu");
            }

            Console.ReadKey();

               
        }
        
    }
}