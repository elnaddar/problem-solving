// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/H
#include <iostream>
#include <climits>
using namespace std;

int main()
{
    unsigned int a, b, c;
    cin >> a >> b >> c;
    long long mul = (long long)a * b;
    double eq = (double)mul / c;
    if (mul % c == 0)
    {
        if ((long long)eq <= 2147483647)
        {
            cout << "int";
        }
        else
        {
            cout << "long long";
        }
    }
    else
    {
        cout << "double";
    }
    cout << endl;
}