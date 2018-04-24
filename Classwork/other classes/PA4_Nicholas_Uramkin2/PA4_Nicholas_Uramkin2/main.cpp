#include <iostream>
#include <fstream>
#include <string>
#include <set>
#include <sstream>
#include "WordData.h"
#include "Code203_Tree.h"

using namespace std;

AVLTreeNode *node(WordData key);

	int main()
	{
		fstream file;
		int lineNum = 1;
		set<string> words;
		string line;
		string word;
		WordData wd;
		Code203_Tree avl;

		/*avl = new Code203_Tree();
		avl->Insert(node(1));*/
		file.open("GulliversTravelsExcerpt.txt");

		while (!file.eof())
		{
			getline(file, line);

			int temp = line.length();

			//remove special characters from line
			for (int i = 0; i < temp; ++i)
			{
				char c = line[i];
				if (((c >= 'A') && (c <= 'Z')) || ((c >= 'a') && (c <= 'z')))
				{
					if ((c >= 'A') && (c <= 'Z')) line[i] += 32; //convert Uppercase to Lowercase
				}
				else
				{
					line.replace(i, 1, " ");//change special characters to a blank space
				}
			}

			//use istringstream to get each word in line and store it in set of words
			istringstream iss(line);
			while (iss >> word)
			{
				words.insert(word);
			}

			//for each w in words insert WordData node into AVL tree
			for (auto w : words)
			{
				//avl = new Code203_Tree();

				wd.setWord(w.data());
				//wd.AddLineNumber(lineNum);

				avl.Insert(node(wd));
			}

			words.clear();
			lineNum++;
		}

		//avl = new Code203_Tree();

		avl.PrintTree();

		system("pause");

		return 0;
	}

	//---------------------------------------------
	// Create a new tree node with the given key
	//---------------------------------------------
	AVLTreeNode *node(WordData key)
	{
		AVLTreeNode *temp = new AVLTreeNode();
		temp->key = key;
		temp->left = NULL;
		temp->right = NULL;
		temp->parent = NULL;
		temp->balanceFactor = '=';
		return temp;
	}