Console.WriteLine("Conversão de Tipos 2");
Console.WriteLine("---------------------");

int valorInt = 10;
double valorDouble = 5.35;
bool valorBoolean = true;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorBoolean.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

Console.WriteLine("---------------------");

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBoolean));
Console.WriteLine(Convert.ToInt32(valorDouble));
