// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/Y

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest1
{
    class ProblemY
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(Console.ReadLine());
            int fib1 = 0, fib2 = 1;
            while (n-- > 0)
            {
                Write("{0} ", fib1);
                int tmp = fib1;
                fib1 = fib2;
                fib2 = fib2 + tmp;
            }
        }
    }
}
