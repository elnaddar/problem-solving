// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/A
#include<iostream>
#include<cstdio>

using namespace std;
 
int main(){
    unsigned short x;
    unsigned int p;
    cin >> x >> p;
    x = 100 - x;
    float result = ((float)p/x) * 100;
    printf("%0.2f", result);
}