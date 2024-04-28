// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/E
#include<iostream>
#include<cstdio>

using namespace std;
 
int main(){
    unsigned short n;
    unsigned int mx=0;
    cin >> n;
    while(n--){
        unsigned int x;
        cin >> x;
        mx = max(mx, x);
    }
    cout << mx << endl;
}