/*
 6- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
maneiras diferentes

- Incrementando 2 em cada passo
- Incrementando 1 em cada passo 
- Com e loop infinito (use "break" e "continue")

 */


Console.WriteLine("Incrementando 2 em cada passo");
for (int i = 10; i <= 20; i+=2) {
    if(i == 16) {
        continue;
    }

    Console.WriteLine($"{i} ");
}

Console.WriteLine("Incrementando 1 em cada passo");
for (int i = 10; i <= 20; i++) {
    if (i % 2 == 0) {
        if (i == 16) {
            continue;
        }

        Console.WriteLine($"{i} ");
    }
}

Console.WriteLine("Com loop infinito");
int count = 10;
while(true) {
    if(count > 20) {
        break;
    }

    if(count % 2 == 0) {
        if(count == 16) {
            count++;
            continue;
        }
        Console.WriteLine($"{count} ");
    }
    count++;
}

Console.WriteLine("Fim do processamento!");

Console.ReadKey();