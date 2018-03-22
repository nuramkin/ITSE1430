#include "todolist.h"
#include <iostream>
#include <fstream>
#include <string>

ToDoList::ToDoList()
{}

ToDoList::ToDoList(std::string fileName)
{}

void ToDoList::addTaskToList()
{
	std::string name;
    int month, day, year; 
    int priority;
	bool isCompleted;
	std::cin.ignore();
	std::cout << "Task name: ";
	getline(std::cin, name);
	std::cout << "Due Date (xx xx xxxx or x x xxxx): ";
    std::cin >> month >> day >> year;
    while (month < 1 || month > 12 || day < 1 || day > 31 || year < 1 || year > 9999)
    {
        std::cout << "Error: Month must be a number 1-12.\n" 
                  << "       Day must be a number between 1-31.\n" 
                  << "       Year must be Anno Domini(A.D), allowed range is 1 - 9999.\n";
        std::cout << "Due Date (xx xx xxxx or x x xxxx): ";
        std::cin >> month >> day >> year;
    }
   
	std::cout << "Priority: ";
	std::cin >> priority;
	std::cout << "Completed?: ";
	std::cin >> isCompleted;

	tasks.push_back(Task(name, month, day, year, priority, isCompleted));
}

void ToDoList::removeTaskFromList()
{
    int t;

    std::cout << "Please enter number of the task you want to delete: ";
    std::cin >> t;

    std::list<Task>::iterator it = tasks.begin();
    std::advance(it, t - 1);
    tasks.erase(it);
}

void ToDoList::modifyTaskInList()
{
    //tasks.assign()
}

void ToDoList::printTasks(bool filter)
{
    int taskNum = 1;

    if (tasks.empty())
        return;


    if (filter)
    {
        for (auto l : tasks)
        {
            std::cout << taskNum << ":  ";
            taskNum++;

            std::cout << l.getName() << std::endl << l.getMonth() << " " << l.getDay() << " " << l.getYear() << std::endl;

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
    }
    else
    {
        for (auto l : tasks)
        {
            if (!l.getIsCompleted())
            {
                std::cout << taskNum << ":  ";
                taskNum++;

                std::cout << l.getName() << std::endl << l.getMonth() << " " << l.getDay() << " " << l.getYear() << std::endl;

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
        }
        std::cout << "\n(Filtering out completed tasks)\n\n";
    }
}

void ToDoList::printTasksByDate()
{
}

bool ToDoList::filterTasks(bool filter)
{
    if (filter)
        return false;
    else
        return true;
}

void ToDoList::saveList(std::string fileName)
{
    std::ofstream file;

    if (fileName == "")
    {
        std::cout << "Please enter file name";

        std::cin >> fileName;

        file.open(fileName);

        for (auto l : tasks)
        {
            file << l.getName() << std::endl << l.getMonth() << " " << l.getDay() << " " << l.getYear() << std::endl << l.getPriority() << std::endl << l.getIsCompleted() << std::endl;
        }
    }
    else
    {
        file.open(fileName);

        for (auto l : tasks)
        {
            file << l.getName() << std::endl << l.getMonth() << " " << l.getDay() << " " << l.getYear() << std::endl << l.getPriority() << std::endl << l.getIsCompleted() << std::endl;
        }

    }

    
}

std::string ToDoList::loadList()
{
	std::string fileName;
	std::ifstream file;
	
	std::cout << "Please enter file name: ";

	std::cin >> fileName;

	file.open(fileName);

	std::string name;
    int month, day, year;
	int priority;
	bool isCompleted;

    //clear list before loading new one in
    tasks.clear();

	while (getline(file, name))
	{
		file >> month >> day >> year;
        if (month < 1 || month > 12)
        {
            std::cout << "Error: invalid or corrupt save file.  Load failed.\n";
            system("pause");
            tasks.clear();
            return "";
        }
        if (day < 1 || day > 31)
        {
            std::cout << "Error: invalid or corrupt save file. Load failed.\n";
            tasks.clear();
            return "";
        }
        if (year < 1 || year > 9999)
        {
            std::cout << "Error: invalid or corrupt save file.  Load failed.\n";
            tasks.clear();
            return "";
        }
		file >> priority;
		file >> isCompleted;
		file.get();

		tasks.push_back(Task(name, month, day, year, priority, isCompleted));
	}

    return fileName;
}
