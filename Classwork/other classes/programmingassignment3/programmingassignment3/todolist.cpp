#include "todolist.h"
#include <iostream>
#include <fstream>

//user adds task to list
void ToDoList::addTaskToList()
{
	std::string name;
    int month, day, year; 
    int priority;
	bool isCompleted;
    char yesOrNo;

	std::cin.ignore();
	std::cout << "What is the name of the task? (50 character limit): ";
	getline(std::cin, name);

    while (name.size() > 50)//limit number of characters to 50
    {
        std::cout << "Error: Name of task cannot be more than 50 characters\n";
        std::cout << "Name of task?: ";
        getline(std::cin, name);
    }

	std::cout << "Please enter the due date (xx xx xxxx or x x xxxx): ";
    std::cin >> month >> day >> year;
    testInput();//in case user enters bad character

    //(does not test for months shorter than 31 days or leap years)
    while (month < 1 || month > 12 || day < 1 || day > 31 || year < 1 || year > 9999)
    {
        std::cout << "Error: Month must be a number from 1 to 12.\n" 
                  << "       Day must be a number from 1 to 31.\n" 
                  << "       Year must be Anno Domini(A.D), allowed range is 1 - 9999.\n";
        std::cout << "Due Date? (xx xx xxxx or x x xxxx): ";
        std::cin >> month >> day >> year;
        testInput();
    }
   
	std::cout << "Please set priority (1 = Low, 2 = Moderate, 3 = High, 4 = Urgent): ";
	std::cin >> priority;
    testInput();
    
    while (priority < 1 || priority > 4)
    {
        std::cout << "Error: priority must be a number from 1 to 4.\n"
                  << "Set priority (1 = Low, 2 = Moderate, 3 = High, 4 = Urgent): ";
        std::cin >> priority;
        testInput();
    }

    for(int i = 1; i == 1;)
    {
        std::cout << "Is the task completed?(Y/N): ";
        std::cin >> yesOrNo;
        if (yesOrNo == 'Y' || yesOrNo == 'y')
        {
            isCompleted = true;
            i++;
        }
        else if (yesOrNo == 'N' || yesOrNo == 'n')
        {
            isCompleted = false;
            i++;
        }
        else
            std::cout << "Error: Please enter Y for Yes or N for No.\n";

    }

    //push into back of list
	tasks.push_back(Task(name, month, day, year, priority, isCompleted));
}

//user selects task to delete from list
void ToDoList::removeTaskFromList()
{
    //if list is empty, return to menu
    if (tasks.empty())
    {
        std::cout << "There are no tasks to be removed\n";
        system("pause");
        return;
    }
    
    int choice;
    int tdlSize = tasks.size();// = size of list

    //display tasks unfiltered with numbers for user to reference when removing
    printTasks(false);

    std::cout << "\nPlease enter number of the task you want to delete (enter 0 or negative number to cancel): ";
    std::cin >> choice;
    testInput();
    
    //return to menu if user enters 0 or negative
    if (choice < 1)
        return;

    while (choice > tdlSize)
    {
        std::cout << "Error: That task does not exist\n"
                  << "Enter number of the task you want to delete (enter 0 or negative number to cancel): ";
        std::cin >> choice;
        testInput();
        
        if (choice < 1)
            return;
    }

    //iterate to the task the user selects in the list and erase it
    std::list<Task>::iterator it = tasks.begin();
    std::advance(it, choice - 1);
    tasks.erase(it);
    
}

//user selects task to modify in list
void ToDoList::modifyTaskInList()
{
    //if list is empty, return to menu
    if (tasks.empty())
    {
        std::cout << "There are no tasks to be removed\n";
        system("pause");
        return;
    }

    int choice;
    int tdlSize = tasks.size();// = size of list

    //display tasks unfiltered with numbers for user to reference when removing
    printTasks(false);

    std::cout << "\nPlease enter number of the task you want to modify (enter 0 or negative number to cancel): ";
    std::cin >> choice;
    testInput();

    //return to menu if user enters 0 or negative
    if (choice < 1)
        return;

    while (choice > tdlSize)
    {
        std::cout << "Error: That task does not exist\n"
            << "Enter number of the task you want to modify (enter 0 or negative number to cancel): ";
        std::cin >> choice;
        testInput();

        if (choice < 1)
            return;
    }

    std::string name;
    int month, day, year;
    int priority;
    char yesOrNo;

    //iterate to the task the user selects in the list and modify it
    std::list<Task>::iterator it = tasks.begin();
    std::advance(it, choice - 1);

    std::cin.ignore();

    //show current name and ask for new
    std::cout << "Current task name: " << it->getName() << std::endl << "New task name (Enter only to not change, 50 character limit): ";
    getline(std::cin, name);

    while (name.size() > 50)
    {
        std::cout << "Error: Name of task cannot be more than 50 characters\n";
        std::cout << "Name of task?: ";
        getline(std::cin, name);
    }
    if (name != "")
        it->setName(name);//change name

    //show current due date and ask for new
    std::cout << "Current due date: " << convertMonth(it->getMonth()) << " " << it->getDay() << ", " << it->getYear() << std::endl 
              << "New due date (Enter 0 0 0 to not change, xx xx xxxx or x x xxxx): ";
    std::cin >> month >> day >> year;
    testInput();

    if (month != 0 && day != 0 && year != 0)
    {
        while (month < 1 || month > 12 || day < 1 || day > 31 || year < 1 || year > 9999)
        {
            std::cout << "Error: Month must be a number from 1 to 12.\n"
                << "       Day must be a number from 1 to 31.\n"
                << "       Year must be Anno Domini(A.D), allowed range is 1 - 9999.\n";
            std::cout << "Due Date? (xx xx xxxx or x x xxxx): ";
            std::cin >> month >> day >> year;
            testInput();
            if (month == 0 && day == 0 && year == 0)
                goto SKIP;//couldn't figure out a way to break out of both code blocks without returning to main, so I cheated :(
        }
        //change due date
        it->setMonth(month);
        it->setDay(day);
        it->setYear(year);
    }
    SKIP:
    
    //show current priority and ask for new
    std::cout << "Current Priority: ";
    if (it->getPriority() == 1)
        std::cout << "Low";
    else if (it->getPriority() == 2)
        std::cout << "Moderate";
    else if (it->getPriority() == 3)
        std::cout << "High";
    else
        std::cout << "Urgent";

    std::cout << std::endl << "Set new priority (0 = No change, 1 = Low, 2 = Moderate, 3 = High, 4 = Urgent): ";
    std::cin >> priority;
    testInput();

    while (priority < 0 || priority > 4)
    {
        std::cout << "Error: priority must be a number from 1 to 4.\n"
            << "Set priority (1 = Low, 2 = Moderate, 3 = High, 4 = Urgent): ";
        std::cin >> priority;
        testInput();
    }
    if (priority != 0)
        it->setPriority(priority);//change priority

    std::cout << "Current completion status: ";
    if (it->getIsCompleted())
        std::cout << "Completed\n";
    else
        std::cout << "Not completed\n";

    for (int i = 1; i == 1;)
    {
        std::cout <<"Is the task completed?(Y/N): ";
        std::cin >> yesOrNo;
        if (yesOrNo == 'Y' || yesOrNo == 'y')
        {
            it->setIsCompleted(true);
            i++;
        }
        else if (yesOrNo == 'N' || yesOrNo == 'n')
        {
            it->setIsCompleted(false);
            i++;
        }
        else
            std::cout << "Error: Please enter Y for Yes or N for No.\n";
    }
}

//output task list to screen 
void ToDoList::printTasks(bool filter)
{
    int taskNum = 1;//number of task in list

    //if list is empty, return to menu
    if (tasks.empty())
        return;


    if (!filter)//unfiltered output
    {
        //output each task in the list
        for (auto l : tasks)
        {
            std::cout << taskNum << ":  ";
            taskNum++;

            std::cout << l.getName() << " | " << convertMonth(l.getMonth()) << " " << l.getDay() << ", " << l.getYear() << " | ";

            if (l.getPriority() == 1)
                std::cout << "Low";
            else if (l.getPriority() == 2)
                std::cout << "Moderate";
            else if (l.getPriority() == 3)
                std::cout << "High";
            else
                std::cout << "Urgent";

            std::cout << " | ";

            if (l.getIsCompleted())
                std::cout << "Completed";
            else
                std::cout << "Not completed";

            std::cout << std::endl;
        }
    }
    else//filtered output
    {
        for (auto l : tasks)
        {
            if (!l.getIsCompleted())//only output if not completed
            {
                std::cout << taskNum << ":  ";
                taskNum++;

                std::cout << l.getName() << " | " << convertMonth(l.getMonth()) << " " << l.getDay() << ", " << l.getYear() << " | ";

                if (l.getPriority() == 1)
                    std::cout << "Low";
                else if (l.getPriority() == 2)
                    std::cout << "Moderate";
                else if (l.getPriority() == 3)
                    std::cout << "High";
                else
                    std::cout << "Urgent";

                std::cout << " | ";

                if (l.getIsCompleted())
                    std::cout << "Completed";
                else
                    std::cout << "Not completed";

                std::cout << std::endl;
            }
        }
        std::cout << "\n(Filtering out completed tasks)\n\n";
    }
}

//sort tasks by priority
void ToDoList::sortTasksByPriority()
{
    //(note to self: lambda expression)
    tasks.sort([](const Task &lhs, const Task &rhs)
    {
        return lhs.getPriority() > rhs.getPriority();
    });
}

//sort tasks by due date
void ToDoList::sortTasksByDate()
{
    tasks.sort([](const Task &lhs, const Task &rhs)
    {
        //turns year, month, and day into a comparable integer ( i.e 2001 12 5 becomes 20011205)
        return (lhs.getDay() + (lhs.getMonth() * 100) + (lhs.getYear() * 10000)) 
               < (rhs.getDay() + (rhs.getMonth() * 100) + (rhs.getYear() * 10000));
    });
}

//turns filtering of completed tasks on or off
bool ToDoList::filterTasks(bool filter)
{
    if (filter)
        return false;
    else
        return true;
}

//saves task list to file
std::string ToDoList::saveList(std::string fileName)
{
    std::ofstream file;
    char choice;

    //if fileName is empty string (no file loaded yet), make new file
    if (fileName == "")
    {
        std::cout << "Please enter file name (enter 0 to cancel): ";
        std::cin.ignore();
        getline(std::cin, fileName);//getline in case of space

        file.open(fileName);

        //write each task in list to file
        for (auto l : tasks)
        {
            file << l.getName() << std::endl << l.getMonth() << " " << l.getDay() << " " << l.getYear() << std::endl << l.getPriority() << std::endl << l.getIsCompleted() << std::endl;
        }

        std::cout << fileName << " saved.\n";
        system("pause");
        return fileName;
    }
    else
    {
        while (true)
        {
            std::cout << "Are you sure you want to overwrite " << fileName << "?(Y/N): ";
            std::cin >> choice;
            if (choice == 'N' || choice == 'n')
                return fileName;
            else if (choice == 'Y' || choice == 'y')
            {

                file.open(fileName);

                for (auto l : tasks)
                {
                    file << l.getName() << std::endl << l.getMonth() << " " << l.getDay() << " " << l.getYear() << std::endl << l.getPriority() << std::endl << l.getIsCompleted() << std::endl;
                }
                std::cout << fileName << " saved.\n";
                system("pause");
                return fileName;
            }
            else
                std::cout << "Error: Please enter Y for Yes or N for No.\n";
        }

    }

    
}

//loads task list from file
std::string ToDoList::loadList(std::string fileName)
{
    char choice;

    while (!tasks.empty())
    {
        char choice;

        std::cout << "If you load a new file, unsaved tasks will be lost.  Are you sure you want to continue?(Y/N): ";
        std::cin >> choice;
        if (choice == 'N' || choice == 'n')
            return fileName;
        else if (choice == 'Y' || choice == 'y')
            break;
        else
            std::cout << "Error: Please enter Y for Yes or N for No.\n";
    }

	//std::string fileName;
	std::ifstream file;
	
	std::cout << "Please enter file name (include .txt for text files): ";

    std::cin.ignore();
    getline(std::cin, fileName);

	file.open(fileName);

    //return to menu if file doesn't exist with empty string for fileName
    if (!file.is_open())
    {
        std::cout << "Error: File not found.\n";
        system("pause");
        return "";
    }
    
	std::string name;
    int month, day, year;
	int priority;
	bool isCompleted;

    //clear list before loading new one in
    tasks.clear();

    //if contents of file are bad, list will be cleared and load will be canceled
	while (getline(file, name))
	{
        while (name.size() > 50)
        {
            std::cout << "Error: invalid or corrupt save file.  Load failed.\n";
            system("pause");
            tasks.clear();
            return "";
        }

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
            system("pause");
            tasks.clear();
            return "";
        }
        if (year < 1 || year > 9999)
        {
            std::cout << "Error: invalid or corrupt save file.  Load failed.\n";
            system("pause");
            tasks.clear();
            return "";
        }
		file >> priority;
        if (priority < 1 || priority > 4)
        {
            std::cout << "Error: invalid or corrupt save file.  Load failed.\n";
            system("pause");
            tasks.clear();
            return "";
        }

		file >> isCompleted;
        if (!file)//if bad input(if not a bool)
        {
            std::cout << "Error: invalid or corrupt save file.  Load failed.\n";
            system("pause");
            tasks.clear();
            return "";
        }
		file.get();

		tasks.push_back(Task(name, month, day, year, priority, isCompleted));
	}

    std::cout << fileName << " loaded successfully.\n";
    system("pause");

    return fileName;
}

//passes in int month and returns corresponding string month
std::string ToDoList::convertMonth(int month)
{
    std::string strMonth;
    if (month == 1)
        strMonth = "Janurary";
    else if (month == 2)
        strMonth = "February";
    else if (month == 3)
        strMonth = "March";
    else if (month == 4)
        strMonth = "April";
    else if (month == 5)
        strMonth = "May";
    else if (month == 6)
        strMonth = "June";
    else if (month == 7)
        strMonth = "July";
    else if (month == 8)
        strMonth = "August";
    else if (month == 9)
        strMonth = "September";
    else if (month == 10)
        strMonth = "October";
    else if (month == 11)
        strMonth = "November";
    else if (month == 12)
        strMonth = "December";

    return strMonth;
}

// test state of cin
bool ToDoList::testInput()
{
    if (!std::cin)
    {                   
        std::cin.clear();    // Reset error flag
        std::cin.ignore();   // burn line
        return false;
    }
    return true;

}
