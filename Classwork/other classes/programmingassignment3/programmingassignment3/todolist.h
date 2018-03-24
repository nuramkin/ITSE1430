#ifndef _TODOLIST_H_
#define _TODOLIST_H_

#include<list>
#include<string>
#include "task.h"

class ToDoList
{
private:
	std::list<Task> tasks;// list of Task objects

public:
	void addTaskToList();
	void removeTaskFromList();
	void modifyTaskInList();
	void printTasks(bool filter);
    void sortTasksByPriority();
	void sortTasksByDate();
    bool filterTasks(bool filter);
	std::string saveList(std::string fileName);
	std::string loadList(std::string fileName);
    std::string convertMonth(int month);
    bool testInput();
    

};





#endif // !_TODOLIST_H_

