// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/O

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemO
    {
        static void Main(string[] args)
        {
            char[] ops = { '+', '-', '*', '/' };
            string input = Console.ReadLine();
            string[] parts = input.Split(
                ops,
                StringSplitOptions.RemoveEmptyEntries);

            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            char op = input[input.IndexOfAny(ops)];
            switch (op)
            {
                case '+':
                    Console.WriteLine(a + b);
                    return;
                case '-':
                    Console.WriteLine(a - b);
                    return;
                case '*':
                    Console.WriteLine(a * b);
                    return;
                case '/':
                    Console.WriteLine(a / b);
                    return;

            }
        }
    }
}
