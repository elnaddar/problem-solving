// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/O

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest1
{
    class ProblemO
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(Console.ReadLine());
            for(int i=1; i <= n; i++){
                for(int j=0; j<i; j++)
                    Write("*");
                WriteLine();
            }
        }
    }
}
