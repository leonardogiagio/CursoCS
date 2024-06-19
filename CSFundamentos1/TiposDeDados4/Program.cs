using System.Xml;

Console.WriteLine("Definindo variáveis do tipo string e boject e dynamic!");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);


object nota = 10;
object nome2 = "Léo";
dynamic ativo = true;

Console.WriteLine(nota);
Console.WriteLine(nome2);
Console.WriteLine(ativo);

Console.ReadLine();