Console.WriteLine("Conversão de Tipos");
Console.WriteLine("--------------------");



// Só podemos converter implicitamente do menor para o maior. Ao contrário precisamos converter explicitamente

// implicitamente
int varInt = 10;
double varDouble = varInt;

Console.WriteLine(varDouble);


// explicitamente
double varDouble2 = 20.25;
int varInt2 = (int)varDouble2;

Console.WriteLine(varInt2);