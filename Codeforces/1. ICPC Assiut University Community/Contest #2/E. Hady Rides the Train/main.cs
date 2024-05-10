// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/E

using System;
using static System.Console;
namespace Codeforces.Assuit.Contest2
{
    class ProblemE
    {
        static void Main(string[] args)
        {
            ulong n, row, col;
            n = ulong.Parse(ReadLine()!);
            row = n / 4;
            col = (1 & row) == 1 ? 3 - (n % 4) : n % 4;
            Console.WriteLine($"{row} {col}");
        }
    }
}
