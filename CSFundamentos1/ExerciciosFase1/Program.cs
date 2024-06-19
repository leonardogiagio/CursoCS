using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Exercícios Fase 1");
Console.WriteLine();

//1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
int idade = 35;
Console.WriteLine($"Idade: {idade}");

//2- Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor
string nome = "Maria";
Console.WriteLine($"Nome: {nome}");

//3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
float altura = 3.45f;
Console.WriteLine($"Altura: {altura}");

//4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine($"Data: {data.ToShortDateString()}");

//5- Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
const int ANO = 12;
Console.WriteLine($"Ano: {ANO}");

//6- Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.
double? nota = 7.80;
Console.WriteLine($"Nota: {nota}");


//7- Quais as diferenças entre os tipos por valor e os tipos por referência ?
/*
Tipos por valor – Armazenam os dados diretamente onde cada variável tem a cópia dos dados e são
armazenados na memória Stack
Tipos por referência – Não armazenam os dados diretamente e cada variável contém uma referência
ao local da memória onde os dados estão. São armazenados na memória Heap

*/


//8- Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:

/*
(int) x = 10;
(double) numero = 7.99;
(char) letra = 'C';
(float) temperatura = 27.4f;
(bool) ativo = false;
(string) nome = "Manoel";
(decimal) salario = 950.99m;
(DateTime) hoje = DateTime.Now;
 */


/*
9- Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por
referência (R) :
(valor) int n = 1;
(referencia) string titulo = "A vida";
(valor) float f = 12.45f;
(valor) double d = 5.45;
(valor) decimal valor = 10.99m;
(valor) char sexo = ‘M’;
(referencia) object o = null;
 */

/*
10- O que é um nullable type e qual a sua utilidade ?

Um nullable type é um tipo de dado que permite atribuir null a uma variável de um tipo qualquer.
*/


/*
11- O que é Camel Case ? Dê um exemplo de sua aplicação.

Camel Case é uma forma de padronizar criação de variáveis, por exemplo: salarioMensal
 
*/

/*
12- O que é Pascal Case ? Dê um exemplo de sua aplicação

Pascal Case é uma forma de padronizar classes, interfaces, metodos, etc... 
Ex: class MetodoDePagamento() {}
 */


/*
13- Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a
operação de soma)
*/
int x = 77;
int y = 66;
Console.WriteLine(x + y);

/*
14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e
string.

bool → false
char → ‘\0’ ou (U+000)
int, double, float e decimal → zero (0)
string → null
*/

/*
15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis
considerando a nomenclatura usada:
(F) double 1valor = 12.45;
(F) string #nome = "Pedro";
(V) float _temperatura = 12.45f;
(F) double int = 5;
(F) decimal renda extra = 91.45m;
(F) bool status$conta = false;
(V) string titulo3 = “Tópico 1”;
(V) float salario_mensal = 1999.55f;
(V) int percentualValorDesconto = 5;
(V) const bool MENSALIDADE_EM_DIA = true;
*/


Console.ReadLine();