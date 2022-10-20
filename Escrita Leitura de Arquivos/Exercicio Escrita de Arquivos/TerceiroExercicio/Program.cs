namespace TerceiroExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2. Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
            Os emails digitados devem ser cadastrados em uma lista e depois em um arquivo .csv e não pode haver emails duplicados, 
            ou seja, o programa deve controlar essa situação. Quando o usuário solicitar a listagem dos emails, além dessa
            lista, o programa deve listar os domínios de emails cadastrados no programa.

            Menu
            1 - Cadastrar email
            2 - Listar 
            3 - Sair 
            Opção: 
             */
            List<string> listEmail = new List<string>();
            preencheListaComBaseDeDados(listEmail);
         
            Menu(ref listEmail);
        }
        static void Menu(ref List<String> emails)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("[1]-Cadastrar Email\n[2]-Listas Emails\n[3]-Sair\nOpção: ");
                string opc = Console.ReadLine();

                if(opc == "3")
                {
                    Environment.Exit(0);
                }
                else if(opc == "1")
                {
                    CadastrarEmail(ref emails);
                }
                else if(opc == "2")
                {
                    List<string> dominios = new List<string>();
                    Console.WriteLine("\nEmails Cadastrados\n");
                    
                    foreach (var item in emails)
                    {
                        Console.WriteLine(item);

                        if (!dominios.Contains(item.Substring(item.IndexOf("@")))){
                            dominios.Add(item.Substring(item.IndexOf("@")));
                        }
                    }
                    Console.WriteLine("\nDominios\n");
                    

                    foreach (var item in dominios)
                    {
                        Console.WriteLine(item);
                    }

                    Console.ReadKey();
                }
                else
                {
                    continue;
                }


            }
        }

        static void CadastrarEmail(ref List<string> listEmail)
        {
            string email = "";
            do
            {
                Console.WriteLine("Digite o email: ");
                email = Console.ReadLine();
            } while (!email.Contains("@"));

            if ( (listEmail.Contains(email)) )
            {
                Console.Write("Email: ["+email+"]"+", Já está cadastrado.");
                
            }
            else
            {
                listEmail.Add(email);
                EscreveNaBaseDeDados(email);
                Console.Write("Email cadastrado com sucesso.");
            }
            Console.Write(" Pressione qualquer tecla para continuar");
            Console.ReadKey();

        }
        static void EscreveNaBaseDeDados(string email)
        {
            try
            {
                StreamWriter writer = new StreamWriter(@"D:\Atos-Codigos\Escrita Leitura de Arquivos\Exercicio Escrita de Arquivos\TerceiroExercicio\Email.csv", append:true);
                writer.WriteLine(email);
                writer.Flush();
                writer.Close();
            }
            catch(Exception ex)
            {

            }
        }
        static void preencheListaComBaseDeDados(List<string> email)
        {
            try
            {
                StreamReader reader = new StreamReader(@"D:\Atos-Codigos\Escrita Leitura de Arquivos\Exercicio Escrita de Arquivos\TerceiroExercicio\Email.csv");

                while (!reader.EndOfStream)
                {
                    email.Add(reader.ReadLine());

                }

                reader.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}