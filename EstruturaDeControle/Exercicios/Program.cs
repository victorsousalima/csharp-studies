Console.WriteLine("## Exercícios ##\n");

//Exercício 1
// Console.WriteLine("Primeiro número: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Segundo número: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Terceiro número: ");
// int n3 = Convert.ToInt32(Console.ReadLine());
//
// if (n1 > n2 && n1 > n3)
// {
//     Console.WriteLine($"O primeiro número {n1} é o maior");
// }
// else if (n2 > n1 && n2 > n3)
// {
//     Console.WriteLine($"O segundo número {n2} é o maior");
// }
// else if (n3 > n2 && n3 > n2)
// {
//     Console.WriteLine($"O terceiro número {n3} é o maior");
// }

//Exercício 2
// Console.WriteLine("Cálculo da equação do segundo grau (ax^2+bx+c): ");
// Console.Write("Informe o valor de a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Informe o valor de b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Informe o valor de c: ");
// int c = Convert.ToInt32(Console.ReadLine());
//
// double d = b * b - 4 * a * c;
// double x1, x2;
//
// if (d == 0)
// {
//     Console.Write("As duas raízes são iguais.\n");
//     x1 = -b / (2.0 * a);
//     x2 = x1;
//     Console.Write($"Primeira raiz x1 = {x1}\n");
//     Console.Write($"Segunda raiz x2 = {x2}\n");
// }
// else if (d > 0)
// {
//     Console.Write("As duas raízes são reais e diferentes.\n");
//     x1 = (-b + Math.Sqrt(d)) / (2 * a);
//     x2 = (-b - Math.Sqrt(d)) / (2 * a);
//     Console.Write($"Primeira raiz x1 = {x1}\n");
//     Console.Write($"Segunda raiz x2 = {x2}\n");
// }
// else
// {
//     Console.Write("As raízes são imaginárias;\nSem solução para os números reais. \n\n");
// }

//Exercício 3
// int soma = 0;
// for (int c = 1; c <= 10; c++)
// {
//     Console.Write(c);
//     soma += c;
// }
// int i = 1;
// while (i <= 10)
// {
//     Console.Write(i + " ");
//     soma += i;
//     i++;
// }
// do
// {
//     Console.Write(i + " ");
//     soma += i;
//     i++;
// } while (i <= 10);
//
// Console.WriteLine($"\nA soma dos números é: {soma}");

//Exercício 4
// int numero;
// do
// {
//     Console.Write("Informe um número inteiro (999 - Sair): ");
//     numero = Convert.ToInt32(Console.ReadLine());
//     
//     if (numero > 0)
//     {
//         for (int c = 1; c <= 10; c++)
//         {
//             Console.WriteLine($"{numero} x {c} = {numero * c}");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Número tem que ser maior que 0!");
//     }
// } while (numero != 999);

// while (true)
// {
//     Console.Write("Informe um número inteiro (999 - Sair): ");
//     int numero = Convert.ToInt32(Console.ReadLine());
//
//     if (numero == 999)
//     {
//         Console.WriteLine("Encerrando programa...");
//         break;
//     }
//
//     if (numero > 0)
//     {
//         for (int c = 1; c <= 10; c++)
//         {
//             Console.WriteLine($"{numero} x {c} = {numero * c}");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Número tem que ser maior que 0!");
//     }
// }


//Exercício 5
// string opcao;
// do
// {
//     Console.WriteLine("Qual a instrução para sair de um loop?\n" +
//                       "a.quit\n" +
//                       "b.continue\n" +
//                       "c.break\n" +
//                       "d.exit\n");
//     Console.WriteLine("Qual a opção correta? (Tecle x para sair) ");
//     opcao = Console.ReadLine().ToLower();
//
//     if (opcao != "c" && opcao != "x")
//     {
//         Console.WriteLine("Opção errada!");
//     }
//     else if (opcao == "c")
//     {
//         Console.WriteLine("Opção certa!");
//     }
// } while (opcao != "x");

//Exercício 6
// for (int c = 10; c <= 20; c += 2)
// {
//     if (c == 16)
//     {
//         continue;
//     }
//     
//     Console.WriteLine(c);
// }
// for (int c = 10; c <= 20; c++)
// {
//     if (c == 16)
//     {
//         continue;
//     }
//
//     if (c % 2 == 0)
//     {
//         Console.Write(c + " ");
//     }
// }
// int c = 10;
// while (true)
// {
//     if (c == 16)
//     {
//         c++;
//         continue;
//     }
//     else if (c > 20)
//     {
//         break;
//     }
//
//     if (c % 2 == 0)
//     {
//         Console.Write(c + " ");
//     }
//
//     c++;
// }

//Exercício 7
// Console.WriteLine("Informe o número de linhas: ");
// int linhas = Convert.ToInt32(Console.ReadLine());
//
// for (int i = 0; i <= linhas; i++)
// {
//     for (int j = 1; j <= i; j++)
//     {
//         Console.Write("*");
//     }
//     Console.Write("\n");
// }


//Exercício 8
// Console.Write("Informe um número: ");
// int numero = Convert.ToInt32(Console.ReadLine());
//
// int f = 1;
// for (int c = 1; c <= numero; c++)
// {
//    f = f * c;
// }
//
// Console.WriteLine($"O fatorial de {numero} é = {f}");


//Exercício 9
// int numero = 2;
// do
// {
//     for (int c = 1; c <= 10; c++)
//     {
//         Console.WriteLine($"{numero} x {c} = {numero * c}");
//     }
//
//     numero++;
//     Console.WriteLine();
// } while (numero <= 6);


//Exercício 10
// while (true)
// {
//     Console.WriteLine("Informe uma nota de 0 a 10 (999 - Sair): ");
//     int nota = Convert.ToInt32(Console.ReadLine());
//
//     if (nota == 999)
//         break;
//     
//     switch (nota)
//     {
//         case 10:
//             Console.WriteLine("A+");
//             break;
//         case 9:
//             Console.WriteLine("A");
//             break;
//         case 8:
//         case 7:
//             Console.WriteLine("B");
//             break;
//         case 6:
//             Console.WriteLine("C");
//             break;
//         case 5:
//             Console.WriteLine("E");
//             break;
//         case 4:
//         case 3:
//         case 2:
//         case 1:
//         case 0:
//             Console.WriteLine("F");
//             break;
//         default:
//             Console.WriteLine("Nota inválida");
//             break;
//     }
//     
// }


//Exercício 11
Console.Write("Informe o primeiro número: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("informe o operando (+, -, /, *): ");
string operando = Console.ReadLine();

Console.Write("Informe o segundo número: ");
int n2 = Convert.ToInt32(Console.ReadLine());

switch (operando)
{
    case "+":
        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        break;
    case "-":
        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        break;
    case "/":
        if (n1 == 0 || n2 == 0)
        {
            Console.WriteLine("Não existe divisão por zero!!");
            Console.WriteLine($"{n1} / {n2} = 8");
        }
        else
        {
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
        }

        break;
    case "*":
        Console.WriteLine($"{n1} x {n2} = {n1 * n2}");
        break;
}