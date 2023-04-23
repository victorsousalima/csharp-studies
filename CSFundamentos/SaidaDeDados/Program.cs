Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";

//Escreve na mesma linha 'Maria tem 25 anos'
//Concatenação usando o operador +

Console.WriteLine(nome + " tem " + idade + " anos");

//Interpolação de strings : $ -> {}
Console.WriteLine($"{nome} tem {idade} anos");

//place holders ; usa {} com numeração com inicio zero
Console.WriteLine("{0} tem {1} anos", nome, idade);

//Sequencia de Escapes
string local = "C:\\dados\\poesias.txt";
string frase = "Ele falou: \"Não fui eu\"";

string pizza = "\nPizza\nde\nMussarela";
string bolo = "\nBolo\tde\tChocolate";

Console.WriteLine(pizza);
Console.WriteLine(bolo);