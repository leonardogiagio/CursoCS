Console.WriteLine("Nullable Types!");
Console.WriteLine();

Nullable<int> number1 = null;
int? number2 = null;
int number3 = number2 ?? 0;

int? n1 = null;
int? n2 = null;
int n3 = n1 ?? n2 ?? 100;

Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);
Console.WriteLine(n3);


if(number1.HasValue) {
    Console.WriteLine($"number1 = {number1}");
} else {
    Console.WriteLine("number1 não possui um valor (null)");
}

Console.ReadLine();