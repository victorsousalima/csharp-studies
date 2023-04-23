Console.WriteLine("## Operadores Aritméticos ##\n");

Console.WriteLine("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"Potência de x elevado a y = {Math.Pow(x, y)}");
Console.WriteLine($"Valor mínimo entre x e y = {Math.Min(x, y)}");
Console.WriteLine($"Valor máximo entre x e y = {Math.Max(x, y)}");
Console.WriteLine($"Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"Seno de x = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}");

// Console.WriteLine($"Soma de x + y = {x + y}");
// Console.WriteLine($"Subtração de x - y = {x - y}");
// Console.WriteLine($"Multiplicação de x * y = {x * y}");
// Console.WriteLine($"Divisão de x / y = {(double)x / y}");
// Console.WriteLine($"Modulo de x % y = {x % y}");