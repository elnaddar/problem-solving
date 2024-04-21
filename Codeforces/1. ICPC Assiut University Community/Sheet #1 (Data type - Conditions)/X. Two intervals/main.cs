// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/X

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemX
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);
            int f = a > c ? a : c;
            int l = b > d ? d : b;

            if (f >= a && f <= b && f >= c && f <= d){
                Console.WriteLine($"{f} {l}");
            } else{
                Console.WriteLine(-1);
            }
        }
    }
}
