namespace ExemplosDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Primeiro Exemplo
            Dictionary<int, string> dic1 = new Dictionary<int, string>()
           {
               {1, "Banana" },
               {2, "Laranja"},
               {3, "Manga" },
               {4, "Abacate"},
               {5, "Maça"}
           };



            //foreach (KeyValuePair<int, string> item in dic1)
            //{   
            //    //É preciso passar o KeyValuePair
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}

            //string resultado;
            //Se não tivermos certeza da chave, temos que usar o exemplo abaixo para não ter erro no código,
            // o tipo de retorno é true or false

            //if(dic1.TryGetValue(4, out resultado))
            //{
            //  //tentar a chave no dicionario a KEY 4, se não tiver entra no else
            //    Console.WriteLine(resultado);
            //}
            //else
            //{
            //    Console.WriteLine("Não foi possível achar a chave especificado");
            //}


            //Console.WriteLine(dic1.ContainsKey(1));
            //Console.WriteLine(dic1.ContainsKey(6));

            //Console.WriteLine(dic1.ContainsValue("Manga"));


            #endregion

            #region Segundo Exemplo
            Dictionary<int, string> dic2 = new Dictionary<int, string>()
           {
               {1, "Banana" },
               {2, "Manga"},
               {3, "Morango" },
               {4, "Abacaxi"},
               {5, "Maça"}
           };

            //foreach (KeyValuePair<int, string> item in dic2)
            //{
            //    Console.WriteLine("Item: "+ item.Key+" "+item.Value);
            //}
            //dic2.Remove(2); //remover a chave 2

            //Console.WriteLine("\nAtualização\n");

            //foreach (KeyValuePair<int, string> item in dic2)
            //{
            //    Console.WriteLine("Item: " + item.Key + " " + item.Value);
            //}

            //string fruta;
            //dic2.Remove(3, out fruta);
            //Console.WriteLine(fruta+ " Removido com sucesso");
            //Console.WriteLine("Atualização 2");
            //foreach (KeyValuePair<int, string> item in dic2)
            //{
            //    Console.WriteLine("Item: " + item.Key + " " + item.Value);
            //}




            #endregion

            #region SortedDictionary

            //criando um dicionario ordenado
            SortedDictionary<string, int> dic12 = new SortedDictionary<string, int>();
            // Adcionando strings e chaves do tipo int

            dic12.Add("zebra", 5);
            dic12.Add("cachorro", 2);
            dic12.Add("gato", 9);
            dic12.Add("pardal", 4);
            dic12.Add("C#", 100);

            //Verifica se o gato existe no dicionario
            if (dic12.ContainsKey("gato"))
            {
                Console.WriteLine("Tem um gato ai...");
            }

            //Verifica se tem zebra
            if (dic12.ContainsKey("zebra"))
            {
                Console.WriteLine("Deu zebra, pois não tem zebra ai...");
            }

            //Verifica se contém c#
            //e se tiver pega valor
            int v;
            if(dic12.TryGetValue("C#", out v))
            {
                Console.WriteLine(v);  
            }
            Console.WriteLine();
            //Imprime o SortedDictionary em ordem alfabética

            foreach (KeyValuePair<string, int>  item in dic12)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }


            #endregion
        }
    }
}