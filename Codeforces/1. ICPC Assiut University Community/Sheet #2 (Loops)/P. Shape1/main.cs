// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/P

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest1
{
    class ProblemP
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(Console.ReadLine());
            for(int i=n; i >= 1; i--){
                for(int j=0; j<i; j++)
                    Write("*");
                WriteLine();
            }
        }
    }
}
