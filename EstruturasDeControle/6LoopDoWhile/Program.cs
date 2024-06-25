Console.WriteLine("Loop Do While");

int optMenu = 0;

do {
    Console.WriteLine("Menu:" +
        "\n1 - Jogar" +
        "\n2 - Configurações" +
        "\n3 - Sair");
    optMenu = Convert.ToInt32(Console.ReadLine());
} while (optMenu != 3);

