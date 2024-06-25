Console.WriteLine("Loop For");

Console.WriteLine("Digite um número para saber a tabuada até 10");
var numero = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 10; i++) {
    Console.WriteLine($"{numero} * {i} = {numero*i}");
}

Console.WriteLine("Fim do processamento");

Console.ReadKey();