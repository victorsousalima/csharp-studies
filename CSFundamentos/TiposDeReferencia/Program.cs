internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Definindo variáveis do tipo string e object e dynamic");
        Console.WriteLine();

        string nome = "Curso C#";
        String titulo = "Curso C# Essencial";

        Console.WriteLine(nome);
        Console.WriteLine(titulo);

        string valor = "Isto é uma string";
        valor = "Isto é uma string alterada";
        valor = "teste";

        //StringBuilder

        //object nota = 10;
        //object valor1 = 8.55M;
        //object nome1 = "Maria";
        //object ativa = true;
        //object letra = 'A';

        dynamic nota = 10;
        dynamic valor1 = 8.55M;
        dynamic nome1 = "Maria";
        dynamic ativa = true;
        dynamic letra = 'A';

        Console.WriteLine(nota);
        Console.WriteLine(valor1);
        Console.WriteLine(nome1);
        Console.WriteLine(ativa);
        Console.WriteLine(letra);
    }
}