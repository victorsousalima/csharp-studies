Console.WriteLine("## Classe e Objeto ##\n");

Pessoa p1 = new Pessoa();
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminino";

Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");

Pessoa p2 = p1;

// Pessoa p2 = new();
// p2.nome = "Manoel";
// p2.idade = 23;
// p2.sexo = "masculino";
//

Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}