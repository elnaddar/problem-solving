// https://codeforces.com/group/MWSDmqGsZm/contest/219158/problem/K

#include<iostream>
using namespace std;
 
int main(){
    long long x, y, z, min, max;
    cin >> x >> y >> z;
    min = x > y? y : x;
    max = x > y? x : y;
    if(min > z) min = z;
    if(max < z) max = z;
 
    cout << min << ' ' << max;
}
