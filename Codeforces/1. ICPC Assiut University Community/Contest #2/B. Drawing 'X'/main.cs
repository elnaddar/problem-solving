// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/B

using System;
using static System.Console;

namespace Codeforces.Assuit.Contest2
{
    class ProblemB
    {
        static void Main(string[] args)
        {
            int a = int.Parse(ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i == (a / 2) && j == i)
                    {
                        Write("X");
                    }
                    else if (j == i)
                    {
                        Write("\\");
                    }
                    else if (j == (a - 1 - i))
                    {
                        Write("/");
                    }
                    else
                    {
                        Write("*");
                    }
                }
                WriteLine();
            }
        }
    }
}
