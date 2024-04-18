// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/Q

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemQ
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            float x = float.Parse(input[0]);
            float y = float.Parse(input[1]);

            if (x == 0 && y == 0)
                Console.WriteLine("Origem");
            else if (x == 0)
                Console.WriteLine("Eixo Y");
            else if (y == 0)
                Console.WriteLine("Eixo X");
            else if (x > 0)
            {
                if (y > 0)
                    Console.WriteLine("Q1");
                else
                    Console.WriteLine("Q4");
            }
            else
            {
                if (y > 0)
                    Console.WriteLine("Q2");
                else
                    Console.WriteLine("Q3");
            }
        }
    }
}
