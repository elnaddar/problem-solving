// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/K
#include <bits/stdc++.h>
using namespace std;
 
int main()
{
    unsigned short n;
    cin >> n;
    for(int i=1;i<=n;i++){
        if(n%i==0) cout << i << endl;
    }
}