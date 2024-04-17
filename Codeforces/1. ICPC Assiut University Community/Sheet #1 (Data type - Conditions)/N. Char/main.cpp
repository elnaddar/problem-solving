// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/N

#include <iostream>
using namespace std;

int main()
{
    char c;
    cin >> c;
    if (islower(c))
    {
        cout << char(c - 32) << endl;
    }
    else
    {
        cout << char(c + 32) << endl;
    }
}