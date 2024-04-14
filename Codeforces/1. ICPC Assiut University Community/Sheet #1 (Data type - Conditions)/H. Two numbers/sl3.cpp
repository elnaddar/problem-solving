#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    int a, b;
    cin >> a >> b;
    float div = (float)a / b;
    cout << "floor " << a << " / " << b << " = " << floor(div) << endl;
    cout << "ceil " << a << " / " << b << " = " << ceil(div) << endl;
    cout << "round " << a << " / " << b << " = " << round(div) << endl;
}