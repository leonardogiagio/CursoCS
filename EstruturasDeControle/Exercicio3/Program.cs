/*
 3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop while, do-while e for 

 Os 10 primeiros números naturais são :
 1 2 3 4 5 6 7 8 9 10
 A soma dos números é : 55

 */


Console.WriteLine("Os 10 primeiros números naturais são : ");

int soma = 0;

for(int i = 1; i <= 10; i++) {
    Console.Write($"{i} ");
    soma += i;
}

Console.WriteLine($"\nA soma dos números é : {soma}");

soma = 0;
int count = 1;

while (count <= 10) {
    Console.Write($"{count} ");
    soma += count;
    count++;
}

Console.WriteLine($"\nA soma dos números é : {soma}");

Console.WriteLine("\n\nFim do processamento");

Console.ReadKey();