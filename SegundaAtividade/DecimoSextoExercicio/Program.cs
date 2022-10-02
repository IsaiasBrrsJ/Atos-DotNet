/*
 
 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil.
Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase.
Caso contrário, mostre uma mensagem indicando que os dois times irão se
enfrentar novamente em um novo jogo.
ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

 */
int golTimeDaCasa = 0;
int golTimeDeFora = 0;
string gols = "";
Console.Write("Informe os gols da partida ex (1x2): ");
gols = Console.ReadLine();

golTimeDaCasa = int.Parse(gols.Substring(0, 1));
golTimeDeFora = int.Parse(gols.Substring(2));


if( (golTimeDeFora  - golTimeDaCasa) > 2) {

    Console.WriteLine($"time da casa {golTimeDaCasa} x {golTimeDeFora} time de fora, mostra O time de fora já se classificou");
}
else if(golTimeDaCasa > golTimeDeFora) {
    Console.WriteLine($"time de casa {golTimeDaCasa} x {golTimeDeFora} time de fora,  O time de casa já se classificou");
}
else {
    Console.WriteLine($"time da casa {golTimeDaCasa} x {golTimeDeFora} time de fora, os times se enfrentarão em um novo jogo");

    Console.Write("Informe os gols da partida ex (1x2): ");
    gols = Console.ReadLine();

    golTimeDaCasa += int.Parse(gols.Substring(0, 1));
    golTimeDeFora += int.Parse(gols.Substring(2));


    if ((golTimeDeFora - golTimeDaCasa) > 2) {

        Console.WriteLine($"time de casa {golTimeDaCasa} x {golTimeDeFora} time de fora,  O time de fora já se classificou");
    }
    else {
        Console.WriteLine($"time de casa {golTimeDaCasa} x {golTimeDeFora} time de fora,  O time de fora já se classificou");
    }
}

Console.ReadKey();

