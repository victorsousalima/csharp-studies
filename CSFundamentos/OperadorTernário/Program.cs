Console.WriteLine("## Operádores Unário e Ternário ##\n");

// int x = 1;
// int resultado = +x;
// Console.WriteLine(resultado);

// Console.WriteLine("Informe o número: \n");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"O negativo de {n} é {-n}");

// Console.WriteLine("Informe a temperatura: \n");
// var temp = Convert.ToDouble(Console.ReadLine());
//
// var resultado = temp > 27 ? "Quente" : "Normal";
//
// Console.WriteLine($"O tempo está {resultado}");

Console.WriteLine("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

string resultado =  x > y ? "x é maior que y":
                    x < y ? "x é menor que y":
                    x == y ? "x é igual a y" : "Sem resultado";

Console.WriteLine(resultado);                    