// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/B

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemB
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]); 
            long k = long.Parse(input[2]); 

            if(a%k == 0 && b%k==0){
                Console.WriteLine("Both");
            } else if (a%k == 0){
                Console.WriteLine("Memo");
            } else if (b%k == 0){
                Console.WriteLine("Momo");
            } else {
                Console.WriteLine("No One");
            }
    }
    }
}
