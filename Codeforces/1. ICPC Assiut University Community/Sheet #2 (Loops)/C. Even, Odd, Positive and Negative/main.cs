// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/C

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemC
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(Console.ReadLine());
            int even=0, odd=0, pos=0, neg=0;
            string[] input = Console.ReadLine().Split(" ");
            while(n > 0){
                int x = int.Parse(input[--n]);
                if((x&1) == 1) ++odd;
                else ++even;

                if(x > 0) ++pos;
                else if(x < 0) ++neg;
            }
            Console.WriteLine($"Even: {even}");
            Console.WriteLine($"Odd: {odd}");
            Console.WriteLine($"Positive: {pos}");
            Console.WriteLine($"Negative: {neg}");
        }
    }
}
