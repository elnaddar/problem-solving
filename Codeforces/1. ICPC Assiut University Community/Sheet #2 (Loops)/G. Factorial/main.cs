// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/G

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemG
    {
        static void Main(string[] args)
        {
            ushort t, n;
            t = ushort.Parse(Console.ReadLine());
            while(t-- > 0){
                n = ushort.Parse(Console.ReadLine());
                ulong fact = (ulong)(n != 0 ? n : 1);
                for(int i=1; i<n; i++){
                    fact *= (ulong)i;
                }
                Console.WriteLine(fact);
            }
        }
    }
}
