// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/A

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemA
    {
        static void Main(string[] args)
        {
            ushort x = ushort.Parse(Console.ReadLine());
            ushort i = 1;
            loop:
                Console.WriteLine(i++);
                if(i <= x) goto loop;
        }
    }
}
