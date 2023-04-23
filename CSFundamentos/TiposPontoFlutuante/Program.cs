using System.Threading.Channels;

Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();

double n1 = 1.234;
float n2 = 1.234F;

decimal n3;
n3 = 1.234M;

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);

Console.WriteLine();

Console.WriteLine("Comparando a precisão de float, double e decimal:");

float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m/ 3m;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);