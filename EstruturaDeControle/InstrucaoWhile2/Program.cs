Console.WriteLine("## Instrucao While com Break ##\n");

// while (true)
// {
//     Console.WriteLine("Digite um número inteiro: (Para sair tecle 999) ");
//
//     int numero = Convert.ToInt32(Console.ReadLine());
//
//     if (numero == 999)
//     {
//         Console.WriteLine("Encerrando programa...");
//         break;
//     }
//     else if (numero % 2 == 0)
//     {
//         Console.WriteLine($"{numero} é PAR");
//     }
//     else
//     {
//         Console.WriteLine($"{numero} é IMPAR");
//     }
//         
// }

int x = 0;
while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.Write($"({x}, {y})");
        y++;
    }

    x++;
    Console.WriteLine();
}