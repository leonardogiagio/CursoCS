/*
    10- Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
    um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
    instrução switch, break e default em um loop infinito e defina uma condição de saida.)
*/


int exit = 0;
int nota = 0;
string avaliacao = "";

while(exit != 2) {
    Console.WriteLine("1 - Inserir nota" +
                        "\n2 - Sair");
    exit = Convert.ToInt32(Console.ReadLine());
    if (exit == 2)
        continue;
    
    Console.WriteLine("Insira sua nota: ");
    nota = Convert.ToInt32(Console.ReadLine());

    switch(nota) {
        case 10:
            Console.WriteLine("A+");
            break;
        case 9:
            Console.WriteLine("A");
            break;
        case 8:
        case 7:
            Console.WriteLine("B");
            break;
        case 6:
            Console.WriteLine("C");
            break;
        case 5:
            Console.WriteLine("E");
            break;
        case 4:
        case 3:
        case 2:
        case 1:
        case 0:
            Console.WriteLine("F");
            break;
    }
}

Console.WriteLine("Processamento finalizado!");
Console.ReadLine();