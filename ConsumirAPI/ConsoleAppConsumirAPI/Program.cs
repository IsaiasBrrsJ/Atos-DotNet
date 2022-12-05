using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ConsoleAppConsumirAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string baseUrl = "http://localhost:5042/";
            int op = 0;


            do
            {

                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1 - Para efetuar uma consulta");
                Console.WriteLine("2 - Para efetuar um cadastro");
                Console.WriteLine("3 - Deletar um cadastro:");
                Console.WriteLine("4 - Atualizar Cadastro: ");
                Console.WriteLine("0 - Para Finalizar");

                op = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                switch (op)
                {
                    case 1:
                        List<Pessoa>? pessoas = new List<Pessoa>();

                        HttpClient client = new HttpClient();
                        client.BaseAddress = new Uri(baseUrl);
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(
                            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                            );


                        HttpResponseMessage response = await client.GetAsync("api/pessoas");

                        if (response.IsSuccessStatusCode)
                        {
                            var dados = response.Content.ReadAsStringAsync().Result;
                            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(dados);

                            foreach (Pessoa item in pessoas)
                            {
                                Console.WriteLine(item.Id + " " + item.Nome + " ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Erro: " + response.StatusCode.ToString());
                        }
                        break;
                    case 2:
                        Pessoa p = new Pessoa();
                        Console.Write("Informe o nome da pessoa: ");
                        p.Nome = Console.ReadLine();


                        try
                        {
                            HttpClient clientePos =new HttpClient();
                            HttpResponseMessage respondePost = await clientePos.PostAsJsonAsync(baseUrl+"api/pessoas", p);
                         
                            Console.WriteLine("Response: "+ respondePost.StatusCode);


                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("Erro: "+ ex.Message);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Informe o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());

                        HttpClient clientDelete = new HttpClient();
                        HttpResponseMessage responseDelete = await clientDelete.DeleteAsync(baseUrl + "api/pessoas/"+id);

                        Console.WriteLine("Responde: " + responseDelete.StatusCode.ToString());

                        break;
                    case 4:
                        Pessoa per = new Pessoa();
                        Console.WriteLine("Informe o Id: ");
                        int ids = int.Parse(Console.ReadLine());
                        HttpClient cliendFind = new HttpClient();
                        HttpResponseMessage resp = await cliendFind.GetAsync(baseUrl + "api/pessoas/" + ids);
                        
                        if (resp.IsSuccessStatusCode)
                        {
                            var dados = resp.Content.ReadAsStringAsync().Result;

                            per = JsonConvert.DeserializeObject<Pessoa>(dados);
                            Console.WriteLine("Nome atual: "+per.Nome);
                            Console.WriteLine("Informe o nome: ");
                            per.Nome = Console.ReadLine();


                            resp = await cliendFind.PutAsJsonAsync(baseUrl + "api/pessoas/" + ids, per);


                            if (resp.IsSuccessStatusCode)
                            {
                                Console.WriteLine(resp.StatusCode.ToString());
                            }
                            else
                            {
                                Console.WriteLine("Erro ao atualizar cliente");
                            }

                        }
                        else
                        {
                            Console.WriteLine(resp.StatusCode.ToString());
                        }
                        break;
                    default:
                        break;
                }





            } while (op != 0);


            Console.WriteLine("Hello, World!");
        }
    }
}