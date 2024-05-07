// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/Y
#include <bits/stdc++.h>
using namespace std;

int main()
{
    short n;
    cin >> n;
    int fib1 = 0, fib2 = 1;
    while (n--)
    {
        cout << fib1 << ' ';
        int tmp = fib1;
        fib1 = fib2;
        fib2 = fib2 + tmp;
    }
}