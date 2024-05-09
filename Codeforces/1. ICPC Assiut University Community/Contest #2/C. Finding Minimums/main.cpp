// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/C
#include <iostream>
#include <cstdio>
#include <climits>

using namespace std;

int main()
{
    int a, b;
    cin >> a >> b;
    int mn = INT_MAX;
    int count = b;
    while (a-- > 0)
    {
        int n;
        cin >> n;
        mn = min(n, mn);
        if (--count <= 0 || a <= 0)
        {
            count = b;
            cout << mn << " ";
            mn = INT_MAX;
        }
    }
}