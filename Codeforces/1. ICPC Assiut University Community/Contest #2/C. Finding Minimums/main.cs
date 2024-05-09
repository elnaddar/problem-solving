// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/C

using System;
using static System.Console;
using static System.Math;
using System.Text;

namespace Codeforces.Assuit.Contest2
{
    class ProblemC
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
        static void Main(string[] args)
        {
            // string[] input = Console.ReadLine().Split(' '); // take one line input
            int a = int.Parse(cin());
            int b = int.Parse(cin()); 

            int mn = int.MaxValue;
            int count = b;
            int i = 0;
            while (a-- > 0)
            {
                int n = int.Parse(cin());
                mn = Min(n, mn);
                if (--count <= 0 || a <= 0)
                {
                    count = b;
                    Write($"{mn} ");
                    mn = int.MaxValue;
                }
            }
        }
    }
}
