// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/X

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest1
{
    class ProblemX
    {
        static void Main(string[] args)
        {
            ushort t = ushort.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                uint n = uint.Parse(Console.ReadLine());
                uint ones = 0;
                while (n > 0)
                {
                    ones += 1 & n;
                    n >>= 1;
                }
                uint bNum = 1;
                while (ones-- > 1)
                {
                    bNum <<= 1;
                    bNum ^= 1;
                }
                WriteLine(bNum);
            }
        }
    }
}
