Console.WriteLine("## Loop For ##\n");

// int i = 1;
// for (; i <= 10;)
// {
//     Console.WriteLine($"i = {i}");
//     i++;
// }

for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        Console.Write($"({x}, {y})");
    }
    Console.WriteLine();
}
