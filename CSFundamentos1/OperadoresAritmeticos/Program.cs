Console.WriteLine("Operadores Aritméticos");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"soma de x+y = {x+y}");
Console.WriteLine($"subtração de x-y = {x-y}");
Console.WriteLine($"multiplicação de x*y = {x*y}");
Console.WriteLine($"divisão de x/y = {x / y}");
Console.WriteLine($"Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"Potencia de x elevado a y = {Math.Pow(x, y)}");

Console.ReadKey();