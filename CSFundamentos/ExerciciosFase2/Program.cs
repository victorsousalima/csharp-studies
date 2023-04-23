Console.WriteLine("## Exercícios Fase 2 ##\n");

//Exercício 1 e 2
// string nome = "Paulo";
// int idade = 17;
// double nota = 7.5;
//
// Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");
// Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
// Console.WriteLine($"{nome}\n {idade}\n {nota}");

//Exerício 3
// Para qual tipo de dados você pode converter um float implicitamente ?
//( ) int
//(X) double
//( ) long
//(X) decimal

//Exercicio 4
// 4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long
// (X) double para long
// (X) double para float
// (X) decimal para float
// (X) long para int
// (X) double para decimal

//Exercício 5
// Console.WriteLine("Informe uma letra: ");
// char a = Console.ReadLine()[0];
// Console.WriteLine("Informe outra letra: ");
// char b = Console.ReadLine()[0];
// Console.WriteLine("Informe mais uma letra: ");
// char c = Console.ReadLine()[0];
//
// Console.WriteLine(c + " " + b + " " + a);
// Console.WriteLine($"{c} {b} {a}");

//Exercício 6
// 6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (V) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (F) A sequencia \t inclui uma tabulação vertical

//Exercício 7
// Console.WriteLine("Informe um valor: ");
// double valor1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Informe outro valor: ");
// double valor2 = Convert.ToDouble(Console.ReadLine());
//
// Console.WriteLine($"A soma entre {valor1} + {valor2} = {valor1 + valor2}");
// Console.WriteLine($"A subtração entre {valor1} - {valor2} = {valor1 - valor2}");
// Console.WriteLine($"A multiplicação entre {valor1} * {valor2} = {valor1 * valor2}");
// Console.WriteLine($"A exponenciação entre {valor1} elevado {valor2} = {Math.Pow(valor1, valor2)}");
// Console.WriteLine($"A divisão entre {valor1} / {valor2} = {valor1 / valor2}");
// Console.WriteLine($"O módulo entre {valor1} % {valor2} = {valor1 % valor2}");

//Exercício 8
// double a = 1.0;
// double b = 12.0;
// double c = -13.0;
//
// double delta = b * b - 4 * a * c;
// double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
// double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//
// Console.WriteLine($"X1 = {x1}");
// Console.WriteLine($"X2 = {x2}");

//Exercício 9
// Console.WriteLine("Informe o nome: ");
// string nome = Console.ReadLine();
// Console.WriteLine("Informe a senha: ");
// int senha = Convert.ToInt32(Console.ReadLine());
//
// string resultado = nome.Equals("admin") || nome.Equals("maria") && senha == 123 ? "Login feito com sucesso!" : "Login inválido!";
//
// Console.WriteLine(resultado);

//Exercício 10
// 10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando
// a nomenclatura usada:
// (V) string? nome; é um exemplo de nullable reference type;
// (F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
// (F) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
// (V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
// (F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
// (F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
// (V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
// (F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
// (F) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
// (V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
// (V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"

//Exercício 11
// Console.WriteLine("Informe o valor de x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Informe o valor de y: ");
// int y = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine(x % 2 == 0 ? "X é par" : "X não é par");
// Console.WriteLine(y % 2 == 0 ? "Y é par" : "Y não é par");

//Exercício 12
// Console.WriteLine("Informe o valor de x: ");
// int x = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine(-6  + x * 5);
// Console.WriteLine((13 -2) * x);
// Console.WriteLine((x + -2)*(20 / x));
// Console.WriteLine((12 + x) / (x - 4));
// Console.WriteLine(3 * Math.Pow(x, 2) + x + 10);
// Console.WriteLine(Math.PI * x * x);

//Exercício 13
// int y = 5 ;
// y = y++ +y+ ++y;
// Console.WriteLine(y);

//Exercício 14
// Console.WriteLine("Informe uma temperatura em Celsius: ");
// double temp = Convert.ToDouble(Console.ReadLine());
//
// double k = temp + 273;
// double f = (temp * 9) / 5 + 32;
//
// Console.WriteLine($"{temp} convertido para Kelvin = {k}");
// Console.WriteLine($"{temp} convertido para Farhenheit = {f}");

//Exercício 15
//(X) 5 2 2 2