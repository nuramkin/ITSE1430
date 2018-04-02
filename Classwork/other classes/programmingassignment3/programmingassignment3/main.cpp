/* Nicholas Uramkin
   Programming Assignment 3
   COSC 2436
   3/30/2018
   4:30pm Mon/Wed
   main.cpp */

#include <iostream>
#include <fstream>
#include <string>
#include "todolist.h"

using namespace std;

int main()
{
	string fileName = "";//empty string tells save method to make new file
    bool filter = false;//filter is basically an on/off switch for filtering out completed tasks
	ToDoList tdl;//instantiating ToDoList class to access its methods
    char choice;
	
	while(true)
	{
        //print title and list of tasks(if any)
        cout << "-------- TO DO LIST --------\n";
        tdl.printTasks(filter);

		//print menu
		cout << "\n----- TO DO LIST MENU -----\n"
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
        cout << endl << endl;


		switch (choice)
		{
			case '1':
				tdl.addTaskToList();
				break;

			case '2':
				tdl.modifyTaskInList();
				break;

			case '3':
                tdl.removeTaskFromList();
				break;

			case '4':
				tdl.sortTasksByPriority();
				break;

			case '5':
				tdl.sortTasksByDate();
				break;

			case '6':
				filter = tdl.filterTasks(filter);//passes filter in to be turned on or off
				break;                         //returns filter to be passed into printTasks

			case '7':
				fileName = tdl.saveList(fileName);
				break;

			case '8':
				fileName = tdl.loadList(fileName);
				break;

			case '9':
				return false;
				break;

			default :
				cout << "\nERROR: Please enter a number between 1 and 9\n\n";
				system("pause");
		}
		system("CLS");
	}
	return 0;
}

