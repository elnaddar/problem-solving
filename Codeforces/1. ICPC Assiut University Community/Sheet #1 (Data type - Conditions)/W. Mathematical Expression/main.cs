// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/W

using System;

namespace Codeforces.Assuit.Sheet1
{
    class ProblemW
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int a = int.Parse(input[0]);
            int b = int.Parse(input[2]);
            int c = int.Parse(input[4]);
            char s = char.Parse(input[1]);
            int d = 0;

            switch (s)
            {
                case '+':
                    d = a + b;
                    break;
                case '-':
                    d = a - b;
                    break;
                case '*':
                    d = a * b;
                    break;
            }
            if (c == d)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine(d);
            }

        }
    }
}
