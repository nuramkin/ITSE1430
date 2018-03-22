#include "todolist.h"
#include <iostream>
#include <fstream>
#include <string>

ToDoList::ToDoList()
{
}

ToDoList::ToDoList(std::string fileName)
{
	/*std::ifstream file;
	file.open(fileName);

	std::string name;
	std::string date;
	std::string priority;
	bool isCompleted;

	while (file >> name)
	{
		file >> name >> date >> priority >> isCompleted;

		tasks.push_back(Task(name, date, priority, isCompleted));
	}*/
}

void ToDoList::addTaskToList()
{
	std::string name;
	std::string date;
	int priority;
	bool isCompleted;
	std::cin.ignore();
	std::cout << "Task name: ";
	getline(std::cin, name);
	std::cout << "Due date: ";
	getline(std::cin, date);
	std::cout << "Priority: ";
	std::cin >> priority;
	std::cout << "Completed?: ";
	std::cin >> isCompleted;

	tasks.push_back(Task(name, date, priority, isCompleted));
}

void ToDoList::removeTaskFromList()
{
}

void ToDoList::modifyTaskInList()
{
}

void ToDoList::printTasksByPriority()
{
	for (auto l : tasks)
	{
		std::cout << l.getName() << std::endl << l.getDate() << std::endl; 
		
		if (l.getPriority() == 1)
			std::cout << "Low";
		else if (l.getPriority() == 2)
			std::cout << "Moderate";
		else if (l.getPriority() == 3)
			std::cout << "High";
		else
			std::cout << "Urgent";

		std::cout << std::endl;

		if (l.getIsCompleted())
			std::cout << "Completed";
		else
			std::cout << "Not completed";

		std::cout << std::endl << std::endl;
	}
	system("pause");
}

void ToDoList::printTasksByDate()
{
}

void ToDoList::saveList()
{
}

void ToDoList::loadList()
{
	std::string fileName;
	std::ifstream file;
	
	std::cout << "Please enter file name: ";

	//std::cin >> fileName;

	file.open("new.txt");

	std::string name;
	std::string date;
	int priority;
	bool isCompleted;

	while (getline(file, name))
	{
		getline(file, date);
		file >> priority;
		file >> isCompleted;
		file.get();

		tasks.push_back(Task(name, date, priority, isCompleted));
	}


}
