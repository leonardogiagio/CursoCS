/*
    Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado
*/
int i = 2;
int j = 1;

do {

    Console.WriteLine($"TABUADA DO {i}");
    do {
        Console.WriteLine($"{i} x {j} = {i*j}");
        j++;
    } while (j <= 10);

    j = 1;
    i++;
} while (i <= 6);


Console.WriteLine("Processamento finalizado!");
Console.ReadKey();