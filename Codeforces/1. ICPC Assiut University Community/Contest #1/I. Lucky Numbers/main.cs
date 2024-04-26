// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/I

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemI
    {
        static void Main(string[] args)
        {
            ushort a = ushort.Parse(Console.ReadLine());
            ushort b = (ushort)(a%10);
            a /= (ushort)10;
            if (b == 0 || a%b == 0 || b%a == 0){
                Console.WriteLine("YES");
            } else {
                Console.WriteLine("NO");
            }
        }
    }
}
