// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/W
#include <iostream>
#include <cstdio>

using namespace std;

int main()
{
    unsigned short n;
    cin >> n;
    for (int i = 1; i <= n; i++)
    {
        for (int j = 0; j < (n - i); j++)
            cout << " ";
        for (int j = 0; j < (i * 2 - 1); j++)
            cout << "*";
        cout << endl;
    }
    for (int i = n; i >= 1; i--)
    {
        for (int j = 0; j < (n - i); j++)
            cout << " ";
        for (int j = 0; j < (i * 2 - 1); j++)
            cout << "*";
        cout << endl;
    }
}