// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/Z

#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    int a, c;
    long long b, d;
    cin >> a >> b >> c >> d;

    double logAB = b*log(a);
    double logCD = d*log(c);
    if(logAB > logCD){
        cout << "YES\n";
    }else{
        cout << "NO\n";
    }
}