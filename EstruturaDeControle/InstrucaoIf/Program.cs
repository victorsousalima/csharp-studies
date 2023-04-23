Console.WriteLine("## Instrução If ##\n");

// Console.WriteLine("Cliente Especial (S/N): ");
// var resposta = Console.ReadLine();
//
// if (resposta == "S")
// {
//     Console.WriteLine("Desconto de 10%");
// }
//
// Console.WriteLine("Fim do processamento");

Console.WriteLine("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X é maior que Y");
}

if (x < y)
{
    Console.WriteLine("X é menor que Y");
}

if (x == y)
{
    Console.WriteLine("X é igual a Y");
}