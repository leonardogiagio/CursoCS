Console.WriteLine("DateTime");
Console.WriteLine();

DateTime dataAtual = DateTime.Now;
Console.WriteLine($"Hoje: {dataAtual}");

Console.WriteLine($"Ano: {dataAtual.Year}");
Console.WriteLine($"Mês: {dataAtual.Month}");
Console.WriteLine($"Dia: {dataAtual.Day}");
Console.WriteLine($"Hora: {dataAtual.Hour}");
Console.WriteLine($"Minuto: {dataAtual.Minute}");


Console.WriteLine($"AddDays: {dataAtual.AddDays(30)}");
Console.WriteLine($"AddMonths: {dataAtual.AddMonths(30)}");
Console.WriteLine($"AddYears: {dataAtual.AddYears(30)}");
Console.WriteLine($"DayOfWeek: {dataAtual.DayOfWeek}");
Console.WriteLine($"DayOfYear: {dataAtual.DayOfYear}");

Console.WriteLine($"Formato Longo: {dataAtual.ToLongDateString()}");
Console.WriteLine($"Formato Curto: {dataAtual.ToShortDateString()}");

Console.ReadLine();