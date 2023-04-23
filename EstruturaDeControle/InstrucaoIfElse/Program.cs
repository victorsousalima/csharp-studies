Console.WriteLine("## Instrução If-Else ##\n");

// Console.WriteLine("Informe a nota do aluno: ");
// int nota = Convert.ToInt32(Console.ReadLine());
//
// if (nota > 5)
// {
//     Console.WriteLine("Aluno Aprovado!");
// }
// else
// {
//     Console.WriteLine("Aluno Reprovado!");
// }

Console.WriteLine("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X é maior que Y");
}
else
{
    if (x < y)
    {
        Console.WriteLine("X é menor que Y");
    }
    else
    {
        Console.WriteLine("X é igual a Y");
    }
}