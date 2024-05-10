// https://codeforces.com/group/MWSDmqGsZm/contest/326907/problem/E
#include <iostream>
#include <cstdio>

using namespace std;

int main()
{
    unsigned long long n, row, col;
    cin >> n;
    row = n / 4;
    col = (1 & row) == 1 ? 3 - (n % 4) : n % 4;

    cout << row << " " << col << endl;
}