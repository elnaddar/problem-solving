// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/H

using System;

namespace Codeforces.Assuit.Contest1
{
    class ProblemH
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' '); // take one line input
            uint a = uint.Parse(input[0]);
            uint b = uint.Parse(input[1]); 
            uint c = uint.Parse(input[2]); 
            long mul = (long)a * b;
            double eq = (double) mul / c;
            if (mul%c == 0)
            {
                if ((long)eq <= 2147483647)
                {
                    Console.WriteLine("int");
                }
                else
                {
                    Console.WriteLine("long long");
                }
            }
            else
            {
                Console.WriteLine("double");
            }

        }
    }
}
