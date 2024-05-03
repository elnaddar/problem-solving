// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/N
#include <iostream>
using namespace std;
 
int main()
{
    char s; cin >> s;
    unsigned short n; cin >> n;
    while(n--){
        unsigned short x; cin >> x;
        while(x--) cout << s;
        cout << endl;
    }
}