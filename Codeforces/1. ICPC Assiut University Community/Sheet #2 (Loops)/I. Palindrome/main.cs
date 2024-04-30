// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/I

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemI
    {
        static void Main(string[] args)
        {
            int x, pal=0;
            x = int.Parse(Console.ReadLine());
            int new_x = x;
            while(new_x > 0){
                pal *= 10;
                pal += new_x%10;
                new_x /=10;
            }
            Console.WriteLine(pal);
            Console.WriteLine((pal == x ? "YES" : "NO"));
        }
    }
}
