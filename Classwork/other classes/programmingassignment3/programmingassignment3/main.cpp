#include <iostream>
#include <iomanip>
#include <fstream>
#include <string>
#include "todolist.h"

using namespace std;

void AddTask();
void ModifyTask();
void RemoveTask();
void DisplayByPriority();
void DisplayByDate();
void FilterOnOff();
void SaveList();
//void LoadList(string);

int main()
{
	fstream file;
	string fileName;
	string test;
	char choice;

	ToDoList t;

	

	
	for (int i = 1; i == 1;)
	{
		//print menu
		cout << "----- TO DO LIST MENU -----\n"
			<< "        1. Add a new task\n"
			<< "        2. Modify a task\n"
			<< "        3. Remove a task\n"
			<< "        4. Display tasks by priority\n"
			<< "        5. Display tasks by due date\n"
			<< "        6. Filter/Unfilter complete tasks\n"
			<< "        7. Save To Do List\n"
			<< "        8. Load To Do List\n"
			<< "        9. Quit Program\n";
			

		cin >> choice;


		switch (choice)
		{
			case '1':
				t.addTaskToList();
				break;

			case '2':
				ModifyTask();
				break;

			case '3':
				RemoveTask();
				break;

			case '4':
				t.printTasksByPriority();
				break;

			case '5':
				DisplayByDate();
				break;

			case '6':
				FilterOnOff();
				break;

			case '7':
				SaveList();
				break;

			case '8':
				t.loadList();
				break;

			case '9':
				i++;
				break;

			default :
				cout << "\nERROR: Please enter a number between 1 and 9\n\n";
				system("pause");
		}
		system("CLS");
	}
	

		/*cout << "Do you want to (L)oad a list or make a (N)ew list?: ";

		cin >> choice;

		if (choice == 'L' || choice == 'l')
		{

			cout << "Please enter filename: ";

			cin >> fileName;

			fileName = fileName + ".txt";

			file.open(fileName);

			file >> test;

			cout << endl << test << endl << endl;

			file.close();

			system("pause");
		}

		else
		{
			cout << "Please name file: ";
			cin >> fileName;

			fileName = fileName + ".txt";



			file.open(fileName, fstream::out);

			file << "new file";

			cout << endl << endl;

			file.close();
		}

		cout << "Do you want to quit?(Y/N): ";
		cin >> choice;
		cout << endl << endl;

		if (choice == 'Y' || choice == 'y')
			break;*/

	return 0;
}

void AddTask()
{
}

void ModifyTask()
{
}

void RemoveTask()
{
}

void DisplayByPriority()
{
}

void DisplayByDate()
{
}

void FilterOnOff()
{
}

void SaveList()
{
}

//void LoadList(string fileName)
//{
//}
