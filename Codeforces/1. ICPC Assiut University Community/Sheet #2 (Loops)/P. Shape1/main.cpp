// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/P
#include<iostream>
#include<cstdio>

using namespace std;
 
int main(){
    unsigned short n;
    cin >> n;
    for(int i=n; i >= 1; i--){
        for(int j=0; j<i; j++)
            cout << "*";
        cout << endl;
    }
}