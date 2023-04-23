Console.WriteLine("## Instrução While ##\n");

//int i = 1;
// while (i <= 10)
// {
//     Console.WriteLine($"i = {i}");
//     i++;
// }

// int i = 10;
//
// while (i > 0)
// {
//     Console.WriteLine($"i = {i}");
//     i--;
// }

int i, numero;

Console.WriteLine("Informe um número para mostrar sua tabuada: ");
numero = Convert.ToInt32(Console.ReadLine());

i = 1;

if (numero > 0)
{
    while (i <= 10)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
        i++;
    }
}
else
{
    Console.WriteLine("Número deve ser maior que zero!");
}

Console.WriteLine("Fim do programa!");