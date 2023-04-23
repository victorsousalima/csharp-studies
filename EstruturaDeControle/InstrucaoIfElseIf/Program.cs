Console.WriteLine("## Instrução If-Else-If ##\n");

Console.WriteLine("Informe a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno Reprovado!");
}
else if (nota < 6)
{
    Console.WriteLine("Aluno em Recuperação!");
}
else if (nota <= 9)
{
    Console.WriteLine("Aluno Aprovado!");
}
else
{
    Console.WriteLine("Aluno Aprovado com Distinção!");
}