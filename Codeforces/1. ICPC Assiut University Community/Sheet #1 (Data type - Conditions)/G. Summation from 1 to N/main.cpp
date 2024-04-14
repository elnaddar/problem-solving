// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/E
// I tried to get a formula that can calculate it.
// after ome calculations I found this: n * (n + 1) / 2
// which can be faster using bitwise shifting: n * (n + 1) >> 1

#include <iostream>
using namespace std;

int main()
{
    unsigned long long n;
    cin >> n;
    cout << (n * (n + 1LL) >> 1) << endl;
}