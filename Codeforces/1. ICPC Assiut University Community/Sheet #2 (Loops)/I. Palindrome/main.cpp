// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/I
#include <bits/stdc++.h>
using namespace std;
 
int main()
{
    int x, pal=0;
    cin >> x;
    int new_x = x;
 
    while(new_x){
        pal *= 10;
        pal += new_x%10;
        new_x /=10;
    }
    cout << pal << endl;
    cout << (pal == x ? "YES" : "NO");
    return 0;
}