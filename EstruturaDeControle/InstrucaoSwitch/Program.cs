Console.WriteLine("## Instrução Switch ##\n");

Console.WriteLine("Valor da Compra R$ 600,00\n");
Console.WriteLine("Informe o número de prestações (1 a n): ");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine($"Prestação R$ {600/num}");
        break;
    case 2:
        Console.WriteLine($"Prestação R$ {600/num}");
        break;
    case 3:
        Console.WriteLine($"Prestação R$ {600/num}");
        break;
    default:
        Console.WriteLine("Valor inválido, informe 1, 2 ou 3!");
        break;
}
Console.WriteLine("\nFim do processamento...");

// Console.WriteLine("Informe um número inteiro: ");
// int numero = Convert.ToInt32(Console.ReadLine());
//
// switch (numero % 2)
// {
//     case 0:
//         Console.WriteLine($"{numero} é PAR!");
//         break;
//     case 1:
//         Console.WriteLine($"{numero} é IMPAR!");
//         break;
// }