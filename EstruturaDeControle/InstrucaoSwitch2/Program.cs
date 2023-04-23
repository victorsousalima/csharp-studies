Console.WriteLine("## Instrução Switch 2 ##\n");

// Console.WriteLine("Informe o mês: ");
// string mes = Console.ReadLine().ToLower();
//
// switch(mes)
// {
//     case "janeiro":
//     case "março":
//     case "maio":
//     case "julho":
//     case "agosto":
//     case "outubro":
//     case "dezembro":
//         Console.WriteLine("Este mês tem 31 dias");
//         break;
//     case "fevereiro":
//         Console.WriteLine("Este mês tem 28 ou 29 dias");
//         break;
//     default:
//         Console.WriteLine("Este mês tem 30 dias");
//         break;
// }

int cargo = 0, funcao = 0;

Console.WriteLine("Informe o seu cargo (1 - Gerente) ou (2 - Programador): ");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.WriteLine("Você é (1 - Junior) ou (2 - Senior): ");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("Seja bem vindo Gerente!");
        break;
    case 2:
        Console.WriteLine("Seja bem vindo Programador!");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("Você é um Junior");
                break;
            case 2:
                Console.WriteLine("Você é um Senior");
                break;
            default:
                Console.WriteLine("Função desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("Não consigo identificar o seu cargo!");
        break;
}