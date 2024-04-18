// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/P

#include<iostream>
using namespace std;
 
int main(){
    short x;
    cin >> x;
 
    x/=1000;
    cout << (x&1? "ODD\n": "EVEN\n");
}