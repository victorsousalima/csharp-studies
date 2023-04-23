Console.WriteLine("## NUllable Types ##\n");

//int? i = null;
//double? d = null;
//bool? b = null;

//Console.WriteLine(i);
//Console.WriteLine(d);
//Console.WriteLine(b);

//int? a = 1;

//int b = a ?? 0;
//Console.WriteLine(b);

int? x = 4;
int? y = 3;
int? z = x * y;
Console.WriteLine(z);

int? b = 100;
if (b.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b Não possui um valor (null)");
}