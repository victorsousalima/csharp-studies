Console.WriteLine("## Precedência e associatividade de operadores ##\n");

// int x = (10 - 2) * 3;
// Console.WriteLine(x);

//bool b = !(9 != 8) && 5 >= 7 || 8 >= 6; ==> True
// bool b = !(9 != 8) && (5 >= 7 || 8 >= 6); // ==> False
// Console.WriteLine(b);

int a = 5, b = 6, c = 4;
int r = --a * b - ++c;
Console.WriteLine(r);