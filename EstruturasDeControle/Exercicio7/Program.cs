/*
 7- Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*).  
Ex:
 *
 **
 ***
 ****     (dica : loop aninhado)

 */


Console.WriteLine("Numeros de linhas: ");
var linhas = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < linhas; i++) {
    for(int j = 0; j <= i; j++) {
        Console.Write("*");
    }
    Console.Write("\n");
}

Console.WriteLine("Fim do processamento!");