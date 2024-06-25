Console.WriteLine("Estrutura if else if");

Console.WriteLine("Digite sua nota");
var nota = Convert.ToInt32(Console.ReadLine());

if(nota > 5) {
    Console.WriteLine("Aprovado");
} else if(nota <= 5 && nota >= 3) {
    Console.WriteLine("Recuperação");
} else {
    Console.WriteLine("Reprovado");
}