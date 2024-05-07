#include <iostream>
using namespace std;

int main()
{
    unsigned int a, b, i, j, k, count{0};
    cin >> a >> b;
    for (i = 0; i <= a; i++)
    {
        for (j = 0; j <= a; j++)
        {
            k = b - (i + j);
            if (k >= 0 && k <= a)
                count += 1;
        }
    }
    cout << count << endl;
}