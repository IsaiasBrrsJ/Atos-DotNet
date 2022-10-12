using System;

IMC imc = new IMC(new Pessoa("Teste", 59, 1.78));


Console.WriteLine("Nome: " + imc.getPessoa().getNome());
Console.WriteLine("Peso: " + imc.getPessoa().getPeso());
Console.WriteLine("Altura: " + imc.getPessoa().getAltura());
Console.WriteLine(imc.Mensagem());