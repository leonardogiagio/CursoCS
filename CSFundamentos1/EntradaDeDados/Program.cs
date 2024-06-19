Console.WriteLine("Entrada de Dados");
Console.WriteLine("-----------------");

Console.WriteLine("Qual é o seu nome?");
string? nome = Console.ReadLine();

Console.WriteLine("Qual é a sua idade?");
int idade = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos.");