using CampBrasileiro;

Time Santos = new("Santos");
Time Botafogo = new("Botafogo");
Partida BOTxSAN = new();

Console.WriteLine(Santos.Nome);
Console.WriteLine(Santos.Pontos);
Console.WriteLine(Santos.Jogos);
Console.WriteLine(Santos.Vitorias);
Console.WriteLine("-----------------------------------");
Console.WriteLine(Botafogo.Nome);
Console.WriteLine(Botafogo.Pontos);
Console.WriteLine(Botafogo.Jogos);
Console.WriteLine(Botafogo.Vitorias);
Console.WriteLine("-----------------------------------");

BOTxSAN.Pontuar(Botafogo, Santos, 3, 7);

Console.WriteLine("-----------------------------------");
Console.WriteLine(Santos.Nome);
Console.WriteLine(Santos.Pontos);
Console.WriteLine(Santos.Jogos);
Console.WriteLine(Santos.Vitorias);
Console.WriteLine("-----------------------------------");
Console.WriteLine(Botafogo.Nome);
Console.WriteLine(Botafogo.Pontos);
Console.WriteLine(Botafogo.Jogos);
Console.WriteLine(Botafogo.Vitorias);
Console.WriteLine("-----------------------------------");