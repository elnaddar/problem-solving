#include <bits/stdc++.h>
using namespace std;
 
int main()
{
    int n;
    long long num, sum=0;
    cin >> n;
    while(n--){
        cin >> num;
        sum += num;
    }
    
    cout << abs(sum);
}