#include<iostream>
#include<math.h>
using namespace std;

int main()
{
	int loopNum;
	cin >> loopNum;

	int a, b;
	int result = 1;

	for (int i = 0; i < loopNum; ++i)
	{
		cin >> a >> b;
		result = 1;

		for (int j = 0; j < b; ++j)
		{
			result = (result * a) % 10;
		}

		if (result == 0)
			cout << 10 << endl;
		else
			cout << result << endl;

	}
}