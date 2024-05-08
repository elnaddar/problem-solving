// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/A
#include <iostream>
#include <cstdio>

using namespace std;

int main()
{
    int a, b;
    cin >> a >> b;
    cout << ((a - b) >= 0 ? (a - b) : 0) << endl;
}