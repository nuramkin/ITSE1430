#ifndef _TODOLIST_H_
#define _TODOLIST_H_

#include<list>
#include<string>
#include<string>
#include "task.h"
#include "date.h"

class ToDoList
{
private:
	std::list<Task> tasks;

public:
	ToDoList();
	ToDoList(std::string fileName);

	void addTaskToList();
	void removeTaskFromList();
	void modifyTaskInList();
	void printTasks(bool filter);
	void printTasksByDate();
    bool filterTasks(bool filter);
	void saveList(std::string fileName);
	std::string loadList();

};





#endif // !_TODOLIST_H_

