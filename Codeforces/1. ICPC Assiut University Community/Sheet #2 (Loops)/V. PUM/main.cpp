// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/V
#include <bits/stdc++.h>
using namespace std;

int main()
{
    short n;
    cin >> n;
    n *= 4;
    for (int i = 1; i <= n; i++)
    {
        if (i % 4 != 0)
            cout << i << ' ';
        else
            cout << "PUM" << endl;
    }
}