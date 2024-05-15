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
        if(tmp > 0){
            cout << 1 << " ";
        } else if (tmp < 0){
            cout << 2 << " ";
        } else{
            cout << 0 << " ";
        }
    }
    cout << endl;

}