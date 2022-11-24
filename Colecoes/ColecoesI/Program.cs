namespace ColecoesI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region lista primitiva
            //List<string> palavras = new List<string>();

            //  for (int i = 0; i < 5; i++)
            //  {
            //      palavras.Add("nome "+i.ToString());
            //  }

            //  if (!palavras.Contains("nome2 "))
            //  {
            //      palavras.Add("nome2");
            //  }

            //  foreach (var item in palavras)
            //  {
            //      Console.WriteLine(item);
            //}
            #endregion


            //List<Pessoa> pessoas = new List<Pessoa>();
            //while (true)
            //{
            //    pessoas.Add(new Pessoa("Isaias", "333333", DateOnly.Parse("12-12-12")));

            //   if(pessoas.Contains()
            //    {

            //    }
            //}

            //foreach (var item in pessoas)
            //{
            //    Console.WriteLine(item);
            //}

            //Pessoa p;
            //SortedSet<Pessoa> pessoa = new SortedSet<Pessoa>();
            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    var n = r.Next(10);
            //    if (!pessoa.Add(new Pessoa("Nome" + n, "" + n, DateOnly.Parse("11/11/11"))))
            //    {
            //        Console.WriteLine("PEssoa já cadastrada");
            //    }
            //}

            //foreach (var item in pessoa)
            //{
            //    Console.WriteLine(item);
            //}

            //HashSet<Pessoa> pessoa = new HashSet<Pessoa>();
            //Random r = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    var n = r.Next(10);

            //    var a  = pessoa.Add(new Pessoa(n.ToString(),  n.ToString(), DateOnly.Parse("11/11/11")));

            //}

            //foreach (var item in pessoa)
            //{
            //    Console.WriteLine(item);
            //}

            List<Pessoa> pe = new List<Pessoa>();
            pe.Add(new Pessoa("Barros", "teste"));
            pe.Add(new Pessoa("teste", "TETE"));
            pe.Add(new Pessoa("Aline", "12"));
            pe.Sort();

            foreach (var item in pe)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}