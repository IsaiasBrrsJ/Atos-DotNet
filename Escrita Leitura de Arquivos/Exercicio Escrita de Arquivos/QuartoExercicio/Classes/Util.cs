using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoExercicio.Classes
{
    static class Util
    {   
        
        public static void RemoverFaltante(ref List<Figurinha> faltante, string caminhoFaltanteTxt, string caminhoFaltanteCsv)
        {
            try
            {
                Console.WriteLine("Digite o Código da figurinha: ");
                string codFigura = Console.ReadLine();
                StreamWriter writeTxt = new StreamWriter(caminhoFaltanteTxt);
                StreamWriter writerCsv = new StreamWriter(caminhoFaltanteCsv);
               
                
                foreach (var item in faltante)
                {
                    if (item.getCodFigura() == codFigura)
                    {
                        faltante.Remove(item);

                        writerCsv.WriteLine("");
                        writeTxt.WriteLine("");

                        Console.Write("Removido Com Sucesso. ");
                        break;
                    }
                }

                writerCsv.Close();
                writeTxt.Close();

                StreamWriter writerCSV = new StreamWriter(caminhoFaltanteCsv);
                foreach (var figura in faltante)
                {
                    writerCSV.WriteLine($"{figura.getCodFigura()};{figura.getNomeJogador()};{figura.getSelecao()}");
                }

                writerCSV.Close();
            }
            catch { }

            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }

        public static void PersistirRepetidaEmMemoria(Figurinha figura, string repetida)
        {
            try
            {
                StreamWriter writer = new StreamWriter(repetida, append: true, encoding: Encoding.UTF8);

                writer.WriteLine($"{figura.getCodFigura()};{figura.getNomeJogador()};{figura.getSelecao()}");
                writer.Flush();
                writer.Close();
            }
            catch(Exception ex)
            {

            }
        }

        public static void PersistirFaltanteEmMemoria(Figurinha figura, string faltante)
        {
            try
            {
                StreamWriter writer = new StreamWriter(faltante, append: true, encoding: Encoding.UTF8);

                writer.WriteLine($"{figura.getCodFigura()};{figura.getNomeJogador()};{figura.getSelecao()}");
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public static void PopularListaFigurasFaltantes(ref List<Figurinha> listFigura, string caminhoFigurasFaltante)
        {
            try
            {
                   StreamReader  reader = new StreamReader(caminhoFigurasFaltante);
                    while (!reader.EndOfStream)
                    {
                        string[] figura = reader.ReadLine().Split(";");

                        listFigura.Add(new Figurinha(codFigura: figura[0], selecao: figura[1], nomeJogador: figura[2]));
                    }

                    reader.Close();
                
            }
            catch { }
        }
     
        public static void PopularListaFigurasRepetidas(ref List<Figurinha> listFigura, string caminhoFigurasRepetidas)
        {

            try
            {
                StreamReader reader = new StreamReader(caminhoFigurasRepetidas);
                while (!reader.EndOfStream)
                {
                    string[] figura = reader.ReadLine().Split(";");

                    listFigura.Add(new Figurinha(codFigura: figura[0],selecao: figura[1], nomeJogador: figura[2]));
                }

                reader.Close();

            }
            catch { }
        }
        public static bool VerificaSeExisteNaLista(ref List<Figurinha> figura, string id_Figura)
        {
            foreach (var figurinha in figura)
	        {
                if(figurinha.getCodFigura() == id_Figura)
                { 
                    return true;
                }
        	}

            return false;
        }

        public static void ListagemDados(ref List<Figurinha> listFigura, string caminhoArquivo, string tipo)
        {
            try
            {
                if (listFigura.Count > 0)
                {
                    Console.WriteLine("Lista de figurinhas...." + tipo.ToUpper());
                    StreamWriter escritor = new StreamWriter(caminhoArquivo, append: false, Encoding.UTF8);
                    
                    foreach (var figuras in listFigura)
                    {   
                        
                        Console.WriteLine("Codigo: " + figuras.getCodFigura() + ". Seleção: " + figuras.getSelecao() + ". Jogador: " + figuras.getNomeJogador());
                        Console.WriteLine("----------------------------------");


                        
                        escritor.WriteLine("Codigo: " + figuras.getCodFigura() + ". Seleção: " + figuras.getSelecao() + ". Jogador: " + figuras.getNomeJogador());
                        escritor.WriteLine("----------------------------------");

                    }
                    escritor.Flush();
                    escritor.Close();
                }
                else
                {
                    Console.WriteLine("Lista Vazia");
                }
            }
            catch(Exception ex)
            {

            }
            Console.ReadKey();
        }
    }
}
