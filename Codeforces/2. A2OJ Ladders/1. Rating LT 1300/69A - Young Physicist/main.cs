// http://codeforces.com/problemset/problem/69/A

using System;
using static System.Console;
using static System.Math;

namespace Codeforces.Assuit.Contest1
{
    class ProblemA
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(ReadLine());
            int x=0, y=0, z=0;
            while(n-->0){
                string[] input = Console.ReadLine().Split(" ");
                int xi = int.Parse(input[0]);
                int yi = int.Parse(input[1]);
                int zi = int.Parse(input[2]);
                x+=xi;
                y+=yi;
                z+=zi;
            }
            if(x == 0 && y == 0 && z == 0){
                WriteLine("YES");
            } else {
                WriteLine("NO");
            }
        }
    }
}
