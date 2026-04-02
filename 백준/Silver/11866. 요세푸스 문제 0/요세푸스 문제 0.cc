#include<iostream>
#include<queue>
using namespace std;

int main()
{
	int n, k;

	cin >> n >> k;

	queue<int> que;
	int length = 0;
	
	for (int i = 1; i < n+1; ++i)
	{
		que.push(i);
	}

	length = que.size();
	cout << "<";
	for (int i = 0; i < length; ++i)
	{
		for (int j = 0; j < k - 1; ++j)
		{
			int q = que.front();
			que.pop();
			que.push(q);
		}
		if (i == length - 1)
			cout << que.front();
		else
			cout << que.front() << ", ";
		que.pop();
	}
	cout << ">";
}