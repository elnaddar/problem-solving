// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/W

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest1
{
    class ProblemW
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
            for(int i = n; i >= 1; i--){
                for (int j = 0; j < (n - i); j++)
                    Write(" ");
                for (int j = 0; j < (i * 2 - 1); j++)
                    Write("*");
                WriteLine();
            }
        }
    }
}
