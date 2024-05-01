// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/L
#include <iostream>
using namespace std;
 
int main()
{
 unsigned short a, b, gcd;
 cin >> a >> b;
 unsigned short min = a > b? b : a;
 for (int i=1; i <= min; i++){
    if(a%i==0 && b%i==0) gcd = i;
 }
 cout << gcd << endl;
}