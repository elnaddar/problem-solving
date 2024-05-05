// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/T

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest1
{
    class ProblemT
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(Console.ReadLine());
            for(int i=1; i <= n; i++){
                for (int j = 0; j < (n - i); j++)
                    Write(" ");
                for (int j = 0; j < (i * 2 - 1); j++)
                    Write("*");
                WriteLine();
            }
        }
    }
}
