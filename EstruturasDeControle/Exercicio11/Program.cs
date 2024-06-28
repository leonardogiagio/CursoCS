/*
    11- Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
    inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
    quando isso ocorrer exibir uma mensagem de alerta)
*/


int menu = 0;
int primeiroNumero = 0;
int segundoNumero = 0;
string? operacao = null;
double resultado = 0;

while(menu != 2) {
    Console.WriteLine("1 - Calculadora" +
        "\n2 - Sair");
    menu = Convert.ToInt32(Console.ReadLine());

    if(menu == 2) {
        continue;
    }

    Console.WriteLine("Informe o primeiro número: ");
    primeiroNumero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe a operação: +, -, /, *");
    operacao = Console.ReadLine();

    Console.WriteLine("Informe o segundo número: ");
    segundoNumero = Convert.ToInt32(Console.ReadLine());

    switch(operacao) {
        case "+":
            resultado = primeiroNumero + segundoNumero;
            break;
        case "-":
            resultado = primeiroNumero - segundoNumero;
            break;
        case "*":
            resultado = primeiroNumero * segundoNumero;
            break;
        case "/":
            if (segundoNumero > 0) {
                resultado = primeiroNumero / segundoNumero;
            } else {
                Console.WriteLine("Não existe divisão por 0!");
                continue;
            }
            break;
        default:
            Console.WriteLine("Valor inválido.");
            break;
    }

    Console.WriteLine($"Resultado: {resultado}");
}

Console.WriteLine("Finalizando processamento!");
Console.ReadKey();