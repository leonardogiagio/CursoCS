/*
    1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
 
    Modelo de saída:

    Encontre o maior dentre 3 números:
    Primeiro Número :       
    Segundo Número :        
    Terceiro Número :       

    65465
    64658
    65464

    O primeiro número : 65465 é o maior
*/

Console.WriteLine("Encontre o maior dentre 3 números:");

Console.Write("Primeiro número: ");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());
Console.Write("Segundo número: ");
int segundoNumero = Convert.ToInt32(Console.ReadLine());
Console.Write("Terceiro número: ");
int terceiroNumero = Convert.ToInt32(Console.ReadLine());

int maior = 0;
string posicaoNumero = "";

if(primeiroNumero >= segundoNumero && primeiroNumero >= terceiroNumero) {
    maior = primeiroNumero;
    posicaoNumero = "primeiro número";
} else if(segundoNumero >= terceiroNumero && segundoNumero >= primeiroNumero) {
    maior = segundoNumero;
    posicaoNumero = "segundo número";
} else {
    maior = terceiroNumero;
    posicaoNumero = "terceiro número";
}

Console.WriteLine($"O {posicaoNumero} : {maior} é o maior");


Console.WriteLine("Fim do processamento");
Console.ReadKey();