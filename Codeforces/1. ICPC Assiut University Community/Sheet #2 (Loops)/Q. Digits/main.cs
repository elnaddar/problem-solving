// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/Q

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest1
{
    class ProblemQ
    {
        static void Main(string[] args)
        {
            ushort t = ushort.Parse(ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(ReadLine());
                do
                {
                    Write("{0} ", n % 10);
                    n /= 10;
                } while (n > 0);
                WriteLine();
            }
        }
    }
}
