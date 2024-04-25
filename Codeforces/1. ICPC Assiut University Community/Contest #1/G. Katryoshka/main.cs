// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/G

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemG
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]); 
            long c = long.Parse(input[2]); 
            long sum = Math.Min(a, Math.Min(b, c));
            a -= sum;
            b -= sum;
            c -= sum;

            if(a == 0 || c == 0){
                Console.WriteLine(sum);
            } else{
                a /= 2;
                if( a <= c){
                    Console.WriteLine(sum + a);
                }else{
                    Console.WriteLine(sum + c);
                }
            }
        }
    }
}
