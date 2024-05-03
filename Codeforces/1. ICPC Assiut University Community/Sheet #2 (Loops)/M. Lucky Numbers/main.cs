// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/M

using System;
using static System.Console;
using static System.Math;

namespace Codeforces.Assuit.Contest1
{
    class ProblemM
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            uint a, b, i, j;
            bool isLucky = true;
            uint x = uint.Parse(input[0]);
            b = uint.Parse(input[1]);

            for(a=x; a <= b; a++){
                i = a;
                while(i != 0){
                    j = i%10;
                    if(j!=7 && j!=4) {
                        i = 0;
                        break;
                    }
                    if (i/10 == 0){
                        Write($"{a} ");
                        isLucky = false;
                        break;
                    }
                    i = i/10;
                }
            }
            if(isLucky) WriteLine(-1);
         }
    }
}
