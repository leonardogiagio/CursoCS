Console.WriteLine("Saída de Dados!");
Console.WriteLine();

int idade = 25;
string nome = "Maria";

Console.WriteLine(nome);
Console.WriteLine(idade);

// interpolação
Console.WriteLine($"{nome} tem {idade} anos");

// concatenação
Console.WriteLine(nome + " tem " + idade + " anos");

//placeholders
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();