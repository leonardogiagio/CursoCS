/*
4- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero 
    recebido via teclado                                                                                                  ----
 
- Verifique se o número é maior que zero e emita uma mensagem
- Considere a tabela de multiplicação de 1 até 10
- Após exibir a tabela torne a solicitar outro número 
- Para sair do loop defina uma condição de saída 

Dica:  Use os loop while e for e para sair a instrução break
 */


for (; ;) {
    Console.WriteLine("Digite um número para exibir a multiplicação até 10. (Pressione 0 para sair)");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 0)
        break;

    for(int i = 1; i <= 10; i++) {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}


Console.WriteLine("Fim do processamento");

Console.ReadKey();
