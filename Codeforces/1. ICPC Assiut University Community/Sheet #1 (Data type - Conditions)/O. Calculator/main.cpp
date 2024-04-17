// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/O

#include <iostream>
using namespace std;

int main()
{
    int a, b;
    char s;
    cin >> a >> s >> b;
    switch (s)
    {
    case '+':
        cout << a+b << endl; return 0;
    case '-':
        cout << a-b << endl; return 0;
    case '*':
        cout << a*b << endl; return 0; 
    default:
        cout << a/b << endl; return 0; 
    }
}