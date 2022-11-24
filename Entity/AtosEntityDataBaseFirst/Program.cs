using Microsoft.EntityFrameworkCore;

namespace AtosEntityDataBaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite:\n" +
             "1 Para criar uma pessoa\n" +
             "2 Para alterar o nome da pessoa\n" +
             "3 Para inserir um email\n" +
             "4 para excluir uma pessoa\n" +
             "5 para consultar tudo\n" +
             "6 parar consultar pelo ID\n");

            int op = int.Parse(Console.ReadLine());

            Contexto contexto = new Contexto();

            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Digite o nome da pessoa: ");
                        Pessoa p = new Pessoa();
                        p.nome = Console.ReadLine();
                        Console.WriteLine("Informe um email: ");
                        string emailTemp = Console.ReadLine();

                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pAlt = contexto.Pessoas.Find(id);

                        Console.WriteLine("Informe o nome correto: ");
                        pAlt.nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);

                        contexto.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa: ");
                        int idEm = int.Parse(Console.ReadLine());

                        Pessoa pEm = contexto.Pessoas.Find(idEm);

                        Console.WriteLine("Informe o novo email: ");
                        string emailTemp = Console.ReadLine();

                        pEm.Emails = new List<Email>()
                        {
                             new Email(){email = emailTemp }
                        };
                        contexto.Pessoas.Update(pEm);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Informar o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Confirma a exclusão de " + p.nome);
                        Console.WriteLine("E dos seus emails: ");

                        foreach (Email item in p.Emails)
                        {
                            Console.WriteLine("\t" + item.email);
                        }
                        Console.WriteLine("1 para sim e 2 para não: ");
                        int opc = int.Parse(Console.ReadLine());

                        if (opc == 1)
                        {

                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine(p.nome + "Excluida com sucesso!");
                        }
                        else
                        {
                          
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                    Console.ReadKey();
                    break;
                case 5:
                    try
                    {
                        List<Pessoa> lista;
                        lista = (from Pessoa p in contexto.Pessoas
                                 select p).Include(pes => pes.Emails).ToList<Pessoa>();

                        foreach (Pessoa item in lista)
                        {
                            Console.WriteLine(item.id + " " + item.nome);
                            foreach (Email itemE in item.Emails)
                            {
                                Console.WriteLine("\t" + itemE.email);
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Digite o ID: ");
                    int idUser = int.Parse(Console.ReadLine());

                    var result = from p in contexto.Pessoas.Include(p => p.Emails) where p.id == idUser select p;


                    foreach (var item in result)
                    {
                        Console.WriteLine(item.nome + " ");
                        foreach (var item2 in item.Emails)
                        {
                            Console.WriteLine(item2.email);
                        }
                    }
                    Console.ReadKey();
                    break;
                default:
                    break;
            }

        }
    }
}