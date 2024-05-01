// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/K

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest1
{
    class ProblemK
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++){
                if(n%i==0) WriteLine(i);
            }
        }
    }
}
