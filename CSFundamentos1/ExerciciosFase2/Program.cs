Console.WriteLine("Exercícios fase 2");
Console.WriteLine("------------------");

/*
 1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :  
Aluno <nome> tem <idade> anos e nota <nota> usando a concatenação e a interpolação de strings. 
 */

string nome = "Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine("Q1");
Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

/*
 3- Para qual tipo de dados você pode converter um float implicitamente ?
() int 
(x) double
() long
(x) decimal
 */


/*
 4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ? 
() int para long
(x) double para long
(x) double para float
(x) decimal para float
(x) long para int
(x) double para decimal
 */


/*
5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando 
a concatenação e também a interpolação de string
 */


Console.WriteLine("Q5");

Console.WriteLine("Informe a primeira Letra");
char primeiraLetra = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Informe a segunda letra");
char segundaLetra = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Informe a terceira letra");
char terceiraLetra = Convert.ToChar(Console.ReadLine());

Console.WriteLine($"{terceiraLetra}, {segundaLetra}, {primeiraLetra}\n");


/*
 6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
(F) long resultado = 1.32;
(V) var nome = “Maria”;
(V) string resultado =  100.ToString();
(V) A sequência de escape \n inclui uma nova linha
(F) float f  = 5.45;  
(V) decimal valor = (decimal) 10.99f;
(F) var status = null;
(V) object o = 12.45m;
(V) string titulo =  true.ToString(); 
(F) A sequencia \t inclui uma tabulação vertical
 */


/*
 7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir 
realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo 
exibindo o resultado
 */

Console.WriteLine("Q7");
Console.WriteLine("Digite o primeiro valor");
double valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo valor");
double valor2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");
Console.WriteLine($"{valor1} * {valor2} = {valor1 * valor2}");
Console.WriteLine($"{valor1} ** {valor2} = {Math.Pow(valor1, valor2)}");
Console.WriteLine($"{valor1} / {valor2} = {valor1 / valor2}");
Console.WriteLine($"{valor1} % {valor2} = {valor1 % valor2}\n");


/*
8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de 
a b e c.
 Valores :  a = 1 , b = 12  e  c = -13
 */

int a = 1, b = 12, c = -13;
double delta, x1, x2;

Console.WriteLine("Q8");

delta = Math.Pow(b, 2) - 4 * a * c;

x1 = ((-b) + Math.Sqrt(delta)) / 2 * a;
x2 = ((-b) - Math.Sqrt(delta)) / 2 * a;
Console.WriteLine(" x1 = " + x1);
Console.WriteLine(" x2 = " + x2 +  "\n");

Console.WriteLine(delta);

Console.ReadKey();