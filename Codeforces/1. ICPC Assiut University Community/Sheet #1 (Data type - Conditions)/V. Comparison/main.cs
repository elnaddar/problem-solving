// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/V

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemV
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int a = int.Parse(input[0]);
            int b = int.Parse(input[2]);
            char s = char.Parse(input[1]);

            bool isRight = false;
            switch (s)
            {
                case '>':
                    isRight = a > b; break;
                case '<':
                    isRight = a < b; break;
                case '=':
                    isRight = a == b; break;
            }

            Console.WriteLine((isRight ? "Right" : "Wrong"));
        }
    }
}
