/*
 8- Escreva um programa para calcular o fatorial de um número inteiro. 
O fatorial de um número é representado por : n! =>  n * (n – 1) * (n – 2) ....2*1 
Exemplo : fatorial de 6 é representado por  6! = 6*5*4*3*2*1

 */

Console.WriteLine("Você quer saber o fatorial de qual inteiro?");
var number = Convert.ToInt32(Console.ReadLine());
var result = 1;

for(int i = 1; i <= number; i++) {
    result *= i;
}

Console.WriteLine($"\nResultado: {result}");
Console.ReadKey();