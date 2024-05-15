#include <bits/stdc++.h>
using namespace std;

#define fr(n) for (int i = 0; i < n; i++)

int main()
{
    int n;
    cin >> n;

    int tmp;
    fr(n)
    {
        cin >> tmp;
        if(tmp <= 10){
            printf("A[%d] = %d\n", i, tmp);
        }
    }
}