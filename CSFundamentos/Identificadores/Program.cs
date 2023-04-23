Console.WriteLine("Definindo Identificadores");
Console.WriteLine();

//Identificadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

//Identificadores inválidos
//int 5idade;
//int $valor;
//int valor#total;
//string nome Completo;

//Para nomes de variáveis: Camel Case
string descontoTotal;
string desconto_Total;

//Para nomes de constantes: maiúscula
double PI = 3.14;
string PREFIXO = "11";
string PREFIXO_SP = "11";

// Para nomes de classe e métodos: Pascal Case

class ImprimirTexto
{
    public void ImprimirNome()
    {
        Console.WriteLine("Macoratti");
    }
}