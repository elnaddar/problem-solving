// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/F
#include<iostream>
#include<cstdio>

using namespace std;
 
int main(){
    unsigned short n;
    cin >> n;
    for(int i=1; i <= 12; i++){
        printf("%d * %d = %d\n", n, i, (n*i));
    }
}