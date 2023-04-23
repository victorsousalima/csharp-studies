Console.WriteLine("## Struct DateTime ##\n");

//Pegando a Data atual
DateTime hoje = DateTime.Now;
Console.WriteLine(hoje);

//Criando uma  data especifica, usando o formato : aaaa,mm,dd
DateTime dataHoje = new DateTime(2022,09,06);
Console.WriteLine(dataHoje);

//Difinindo Horas
DateTime dataHoraHoje = new DateTime(2022, 09, 06, 21, 10, 30);
Console.WriteLine(dataHoraHoje);

// Métodos DateTime:
//Extraindo informações
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

//Adicionando valores
Console.WriteLine(hoje.AddDays(30));    
Console.WriteLine(hoje.AddMonths(1));    
Console.WriteLine(hoje.AddHours(2));    
Console.WriteLine(hoje.AddYears(5));   

//Obtendo dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear); 

//Obtendo data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

//Obtendo horano formato longo e curto
Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());