Console.WriteLine("## Inferência Tipos (var) ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2.500M;

Console.WriteLine($"{nome} tem {idade} anos");

//var limitações
// var salario = null;
// var titulo;
// var salario, imposto, total;

//não posso mudar o tipo apos inicializar
// var num = 10;
// num = num + 20;
// num = "Teste";

var teste = new Teste();
teste.MeuMetodo();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu Método");
    }
}