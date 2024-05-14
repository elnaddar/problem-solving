#include <bits/stdc++.h>
using namespace std;

#define fr(n) for (int i = 0; i < n; i++)

int main()
{
    int n;
    cin >> n;

    int *a = new int[n];
    fr(n)
    {
        cin >> a[i];
    }

    int x;
    cin >> x;

    fr(n)
    {
        if (x == a[i])
        {
            cout << i << endl;
            delete[] a;
            return 0;
        }
    }

    cout << -1 << endl;
    delete[] a;
}