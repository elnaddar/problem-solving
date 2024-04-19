// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/R
#include<iostream>
using namespace std;
 
int main(){
    unsigned int n;
    cin >> n;
    cout << n/365 << " years\n";
    cout << (n%=365)/30 << " months\n";
    cout << (n%=30) << " days\n";
}
