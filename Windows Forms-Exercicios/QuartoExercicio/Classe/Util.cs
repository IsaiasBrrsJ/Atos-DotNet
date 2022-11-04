using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace QuartoExercicio.Classe
{

    static class Util
    {
        private static string caminho = @"D:\Atos-Codigos\Windows Forms-Exercicios\QuartoExercicio\BaseDeDados-Arquivo\baseJogadores.csv";
        private static List<string> lerOsdados = new List<string>();
        private static List<Jogador> criaJogador = new List<Jogador>();
        public static void LerBaseDeDados()
        {
            if (!File.Exists(caminho))
            {
                File.Create(caminho).Close();
            }
            else
            {
                try
                {
                    StreamReader reader = new StreamReader(caminho);

                    while (!reader.EndOfStream)
                    {
                       
                        string linha = reader.ReadLine();
                        lerOsdados.Add(linha);

                        string[] jogador = linha.Split(';');
                        criaJogador.Add(new Jogador(jogador[0].ToUpper(), jogador[1]));
                    }

                    reader.Close();
                }
                catch (Exception ex) { }
            }
        }
        public static List<Jogador> RetornarJogador()
        {
            return criaJogador;
        }
        public static void GerarEmailJogador(string nome)
        {

            string[] jogadorNome = nome.Split(' ');
            string sobrenomeJogador = "";

            if (jogadorNome.Length == 2)
            {
                sobrenomeJogador = jogadorNome[1];
            }
            else
            {
               sobrenomeJogador = jogadorNome[2];
            }

            string email = $"{sobrenomeJogador}.{jogadorNome[0]}@ufn.edu.br";
            criaJogador.Add(new Jogador(nome.ToUpper(), email));
        }
        public static bool jaEstaCadastrado(string nome)
        {
            if (criaJogador.Count > 0)
            {
                foreach (var item in criaJogador)
                {
                    if (item.getNomeJogador() == nome.ToUpper())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static void GravaNoArquivo()
        {
            try
            {
                StreamWriter writer = new StreamWriter(caminho, append: true, encoding: Encoding.UTF8);
                writer.WriteLine(criaJogador[criaJogador.Count-1].getNomeJogador() + ";" + criaJogador[criaJogador.Count - 1].getEmailJogador());
                writer.Close();
            }
            catch (Exception ex) { }
        }
    }
}
