// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/F

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemF
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(Console.ReadLine());
            for(int i=1; i <= 12; i++){
                Console.WriteLine($"{n} * {i} = {(n*i)}");
            }
        }
    }
}
