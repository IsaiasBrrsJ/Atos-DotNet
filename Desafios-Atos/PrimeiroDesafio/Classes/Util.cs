using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroDesafio.Classes
{
    static class Util
    {
        public static void LerArquivoETratar(string caminho)
        {
            string pessoa = "";
            int qtdPessoas = 0;

            List<Aluno> aluno = new List<Aluno>();
            List<string> armazenaDadosDoArquivo = new List<string>();// Lista que vai receber os dados do arquivo

            try
            {
                StreamReader reader = new StreamReader(caminho);

                while (!reader.EndOfStream)
                {
                    armazenaDadosDoArquivo.Add(reader.ReadLine()); // Armazena os dados em uma lista para poder tratar essas informações
                }

                reader.Close();

            }
            catch(Exception ex){ }

            
            for (int i = 0; i < armazenaDadosDoArquivo.Count; i++)
            {
                string[] linhaPessoa_Z = armazenaDadosDoArquivo[i].Split('-');
                string[] linhaAluno_Y = linhaPessoa_Z;

                if ( (i+1) < armazenaDadosDoArquivo.Count) // Para não quebrar o sistema, só vai atibuir mais 1 em ( i ) enquanto ( i ) seja menor que o tamanho da lista
                    linhaAluno_Y = armazenaDadosDoArquivo[i + 1].Split('-'); // Pega sempre a próxima posição de I se I é 0 então aqui vai ser 1;
                else
                    linhaAluno_Y = armazenaDadosDoArquivo[i].Split('-'); // Aqui pega a última posição da lista, só entra aqui na ultima iteração;


                if (linhaPessoa_Z[0] == "Z" && linhaAluno_Y[0] == "Y") 
                {
                    aluno.Add(new Aluno(

                        nome:      linhaPessoa_Z[1], 
                        telefone:  linhaPessoa_Z[2],
                        cidade:    linhaPessoa_Z[3],
                        RG:        linhaPessoa_Z[4],
                        CPF:       linhaPessoa_Z[5], 

                        matricula: linhaAluno_Y[1],
                        codCurso:  linhaAluno_Y[2],
                        nomeCuros: linhaAluno_Y[3]
                     ));

                    i += 1; // Caso Y seja depois de Z então vai para posição depois de Y;
                }
                else
                {
                    if (linhaPessoa_Z[0] != "X")
                    {
                        Pessoa p = new 
                        Pessoa( nome: linhaPessoa_Z[1],telefone: linhaPessoa_Z[2], cidade: linhaPessoa_Z[3], rG: linhaPessoa_Z[4], cPF: linhaPessoa_Z[5]);

                        pessoa += "Nome: " + p.getNome() +
                          "\nTelefone: " +   p.getTelefone() +
                          "\nCidade: " +     p.getCidade() +
                          "\nRG: " +         p.getRG() +
                          "\nCPF: " +        p.getCPF() +
                          "\n==========\n";

                        qtdPessoas++;
                    }

                }
            }

            Console.WriteLine("Alunos: "+  aluno.Count);
            Console.WriteLine("Pessoas: "+ qtdPessoas+"\n");

            foreach (var item in aluno) 
            {
                Console.WriteLine($"Nome: {item.getNome()}");
                Console.Write($"Nome do curso: ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item.getNomeCurso());
                Console.ResetColor();

                Console.WriteLine("=========");
            }

            Console.WriteLine("\nPessoas\n"); 
            Console.WriteLine(pessoa);  //<== FUNCIONANDO NORMALMENTE, para testar basta remover o comentário. Exibe as pessoas que não são alunos.

        }
    }
}
