// https://codeforces.com/group/MWSDmqGsZm/contest/326175/problem/M
#include <iostream>
using namespace std;
 
int main()
{
 unsigned int a, b, i, j;
 bool isLucky = true;
 cin >> a >> b;
 
 for(a; a <= b; a++){
    i = a;
    while(i != 0){
        j = i%10;
        if(j!=7 && j!=4) {
            i = 0;
            break;
        }
        if (i/10 == 0){
             cout << a << ' ';
             isLucky = false;
             break;
        }
        i = i/10;
    }
 }
 if(isLucky) cout << -1;
}