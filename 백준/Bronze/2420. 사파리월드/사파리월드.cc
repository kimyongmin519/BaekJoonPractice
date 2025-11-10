#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	long long a[2];
	long long result = 0;

	cin >> a[0] >> a[1];

	result = abs(a[0] - a[1]);

	cout << result;
}
