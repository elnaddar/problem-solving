// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/H
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    unsigned int num;
    bool isPrime = true;
    cin >> num;
    for (int i = 2; i <= sqrt(num); i++)
    {
        if (num % i == 0)
        {
            cout << "NO\n";
            return 0;
        }
    }
    cout << "YES\n";
}