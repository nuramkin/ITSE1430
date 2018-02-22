/******************************
   Name
   Date
   File Name template.cpp
   Description
********************************/

// Headers
#include <iostream>
#include <fstream>
#include <cstdlib>
#include <string>
#include <stack>
using namespace std;

// Global variables

// Function declarations

int main()
{
	ifstream file;
	int numCases;
	int numTowers;
	int height;
	stack<int> s;

	file.open("tower_input.txt");

	cout << "Please enter number of cases: \n";
	file >> numCases;

	for (int i = numCases; i > 0; i--)
	{
		cout << "Please enter number of towers: \n";
		file >> numTowers;

		for (int a = numTowers; a > 0; a--)
		{
			file >> height;
			s.push(height);
		}

	}

	while (!s.empty())
	{
		cout << s.top() << " ";
		s.pop();

	}

	system("pause");

    return 0;
}
