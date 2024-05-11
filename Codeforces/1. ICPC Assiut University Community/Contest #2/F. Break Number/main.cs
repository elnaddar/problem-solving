// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/F

using System;
using static System.Console;
using static System.Math;
using System.Text;

namespace Codeforces.Assuit.Contest2
{
    class ProblemF
    {
        static string cin()
        {
            StringBuilder input = new();
            char ch;
            do
            {
                int readValue = Console.Read();
                if (readValue == -1) // No more characters are available to read
                    break;
                ch = (char)readValue;
                if (ch == '\r') // Carriage return might be read before newline on Windows
                    continue;
                if (ch == '\n' || ch == ' ') // Stop reading on newline or space
                    break;

                input.Append(ch);
            } while (true);

            return input.ToString();
        }

        static uint f(long x)
        {
            uint count = 0;
            while (x > 0)
            {
                if ((x & 1) == 0)
                {
                    count++;
                    x >>= 1;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(cin());
            uint mx_count = 0;
            while (n-- > 0)
            {
                long x = long.Parse(cin());
                mx_count = Max(mx_count, f(x));
            }
            WriteLine(mx_count);
        }
    }
}
