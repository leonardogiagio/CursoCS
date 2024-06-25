Console.WriteLine("Instrução if");

Console.WriteLine("Cliente especial? (S/N)");
var resposta = Console.ReadLine();

if(resposta == "S") {
    Console.WriteLine("Desconto de 10%");
}

Console.WriteLine("Fim do processamento");
Console.ReadKey();