Console.WriteLine("## Operadores Lógicos ##\n");

bool c1 = 5 >= 7;
bool c2 = 6 != 8;
bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}\n");

//Operador AND -> &&
resultado = c1 && c2;
Console.WriteLine("Operador AND(&&) :" + resultado);

//Operador OR -> ||
resultado = c1 || c2;
Console.WriteLine("Operador OR(||) :" + resultado);

//Operador NOT -> !
resultado = !c1;
Console.WriteLine("Operador NOT(!) :" + resultado);
