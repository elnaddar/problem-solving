string[] input = Console.ReadLine().Split(" ");
int a = Convert.ToInt32(input[0]);
int b = Convert.ToInt32(input[1]);
float div = (float)a/b;

Console.WriteLine($"floor {a} / {b} = {Math.Floor(div)}");
Console.WriteLine($"ceil {a} / {b} = {Math.Ceiling(div)}");
Console.WriteLine($"round {a} / {b} = {Math.Round(div, MidpointRounding.AwayFromZero)}");