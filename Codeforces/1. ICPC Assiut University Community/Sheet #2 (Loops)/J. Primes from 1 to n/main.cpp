// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/J
#include <iostream>
#include <cmath>
using namespace std;
 
int main()
{
    unsigned int num;
    bool isPrime = true;
    cin >> num;
    for (int n = 2; n <= num; n++)
    {
        for (int i = 2; i <= sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
            isPrime = true;
        }
        if (isPrime)
        {
            cout << n << ' ';
        }
    }
}