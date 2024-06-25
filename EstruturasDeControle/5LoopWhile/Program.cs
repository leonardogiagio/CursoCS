Console.WriteLine("Loop while");

Console.WriteLine("Digite a um número para ver a tabuada até 10");
var numero = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i <= 10) {
    Console.WriteLine($"{numero} x {i} = {numero * i}");
    i++;
}

Console.WriteLine("Finalizando processamento");
Console.ReadKey();