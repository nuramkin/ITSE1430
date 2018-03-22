#ifndef _TODOLIST_H_
#define _TODOLIST_H_

#include<list>
#include<string>
#include<string>
#include "task.h"

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
	void printTasksByPriority();
	void printTasksByDate();
	void saveList();
	void loadList();

};





#endif // !_TODOLIST_H_

