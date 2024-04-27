// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/C
#include<iostream>
#include<cstdio>

using namespace std;
 
int main(){
    unsigned short n;
    int even=0, odd=0, pos=0, neg=0;
    cin >> n;
    while(n--){
        int x;
        cin >> x;
        if((x&1) == 1) ++odd;
        else ++even;

        if(x > 0) ++pos;
        else if(x < 0) ++neg;
    }
    cout << "Even: " << even << endl;
    cout << "Odd: " << odd << endl;
    cout << "Positive: " << pos << endl;
    cout << "Negative: " << neg << endl;
}