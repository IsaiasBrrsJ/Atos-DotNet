namespace ExemplosOOnativos {
    internal class Program {
        static void Main(string[] args) {

            // Console.WriteLine("Exibindo uma saudação");

            // Console é uma classe nativa
            //  WriteLine() é um método de classe da classe "Console"
            //  Beep() é uma método de classe da classe Console, sem retorno
            // ReadLine() é uma método de classe da classe Console, com retorno - string

            // métodos de classe
            // Classe.metodoDeClasse()

            // cubo método
            // chave de boca atributo

            // antes de sair criando classe, devemos olhar se temos classes nativas

            //  métodos de classe, precisamos chamar a classe pra ativa-los


            // Console.Beep();
            // Console.WriteLine("Digite uma frase: ");
            // string frase = Console.ReadLine();

            // frase é um objeto da classe string, que encapsula / recebe atributos e métodos da classe string

            // int tamanhoFrase = frase.Length;

            // Length é uma atributo da classe string, que informa a quantidade de caracteres
            // toUpper() é um método de instância, com retorno

            // Random gerador = new Random(); //o método construtor da classe Random é chamado
            // o construtor aloca memória para o objeto gerador


            // int numeroQualquer = gerador.Next(minValue: 10, maxValue: 50);
            // Next é um método de instância da classe Random com retorno
            //Next possui 3 opcoes de comportamento / funcionalidade - polimorfismo de sobrecarga
            // Console.WriteLine("Número sorteado até 50 :" + numeroQualquer);


            // Console.WriteLine(gerador.NextDouble());
            // NextDouble() da instância ferador, com retorno

            //List<string> nomesPessoas = new List<string>(); //construtor que instancia o objeto nomesPessoas em memória


            //nomesPessoas.Add("isaias");
            //nomesPessoas.Add("jesus");
            //nomesPessoas.Add("barros");

            ////Add é um método da instância nomesPessoas que insere uma string no final da lista

            //for (int i = 0; i < nomesPessoas.Count; i++) {

            //    Console.WriteLine(nomesPessoas[i].ToUpper());
            //}

            ////Count é um método de instância que sabe o tamanho da lista até aquele momento

            //string nome;
            //do {
            //    Console.WriteLine("Digite um nome ou 'sair': ");
            //    nome = Console.ReadLine().ToUpper();

            //    if (nome == "SAIR") {
            //        break;                
            //    }

            //    if (nomesPessoas.Contains(nome)) {
            //        Console.WriteLine("Nome já cadastrado! !");
            //    }
            //    else {
            //        nomesPessoas.Add(nome.ToUpper());
            //    }
            //} while (true);
            //// contains é um método de instância com retorno que verifica se um valor está na lista

            //for (int i = 0; i < nomesPessoas.Count; i++) {
            //    Console.WriteLine(nomesPessoas[i]);
            //}

            //Console.WriteLine("TAmanho da lista: " + nomesPessoas.Count);
            //nomesPessoas.Remove("ISAIAS");
            //Console.WriteLine("Tamanho da lista após remoção"+ nomesPessoas.Count);
            //Console.WriteLine("Lista ordenada");
            //nomesPessoas.Sort();
            //for (int i = 0; i < nomesPessoas.Count; i++) {
            //    Console.WriteLine(nomesPessoas[i]);
            //}




            //métodos e atributos da classe list

            //Add
            //Clear()
            //Contains()
            //Count
            //Remove()
            //Sort()

            //métodos e atributos da classe string
            //Length
            //Contains()
            //Replace()
            //string.IsNullOrWhiteSpace()
            //Split()

            string email = "isaias@ufn.edu.br";

            string[] dadosEmail = email.Split("@");
            Console.WriteLine("usuário:"+ dadosEmail[0]);
            Console.WriteLine("dominio: "+dadosEmail[1]);


            string frase = "A Margareth é do Rio de Janeiro e estuda C# em Santa Maria";
            string[] palavrasFrase = frase.Split(" ");

            //for (int i = 0; i < palavrasFrase.Length; i++) {
            //    Console.WriteLine(palavrasFrase[i]);
            //}

            foreach(var item in palavrasFrase){
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}