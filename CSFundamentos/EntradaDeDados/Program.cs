Console.WriteLine("## Entrada de Dados ##\n");

Console.Write("Informe o seu nome: ");
string nome = Console.ReadLine();

Console.Write("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nSeu nome é {nome} e tem {idade} anos!");
