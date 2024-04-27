// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/B

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemB
    {
        static void Main(string[] args)
        {
            ushort x = ushort.Parse(Console.ReadLine());
            ushort i = 0;
            if(x<2){
                Console.WriteLine(-1);
                return;
            }
            loop:
                Console.WriteLine(i+=2);
                if(i+1 < x) goto loop;
        }
    }
}
