// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/W

#include <iostream>
using namespace std;

int main()
{
    int a, b, c, d;
    char s, _;
    cin >> a >> s >> b >> _ >> c;
    switch (s)
    {
    case '+':
        d = a + b;
        break;
    case '-':
        d = a - b;
        break;
    case '*':
        d = a * b;
        break;
    }
    if (c == d)
    {
        cout << "Yes\n";
    }
    else
    {
        cout << d << endl;
    }
}