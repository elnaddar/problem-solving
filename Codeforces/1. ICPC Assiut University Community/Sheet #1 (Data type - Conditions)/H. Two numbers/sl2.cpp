#include <iostream>
#include <cstdio>
#include <cmath>
using namespace std;

int main()
{
    int a, b;
    cin >> a >> b;
    float div = (float)a / b;
    printf("floor %d / %d = %d\n", a, b, (int)div);
    printf("ceil %d / %d = %.0f\n", a, b, ceil(div));
    printf("round %d / %d = %.0f\n", a, b, round(div));
}