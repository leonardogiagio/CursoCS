Console.WriteLine("Estrutura switch case");

int compra = 600;

Console.WriteLine("Valor da compra R$ 600,00");
Console.WriteLine("Informe o nº de parcelas (1 a 3)");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());



switch(numeroParcelas) {
    case 1:
        Console.WriteLine($"Prestação R$ {compra / numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"Prestação R$ {compra / numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"Prestação R$ {compra / numeroParcelas}");
        break;
    default:
        Console.WriteLine("Valor inválido");
        break;
}

Console.ReadKey();