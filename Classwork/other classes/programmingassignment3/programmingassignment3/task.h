
#ifndef _TASK_H_
#define _TASK_H_

#include<string>
#include "date.h"

class Task
{
private:
	std::string name;
    int month;
    int day;
    int year;
	int priority;
	bool isCompleted;

public:
	Task(std::string name, int month, int day, int year, int priority, bool isCompleted);
	
	//getters
	std::string getName();
	int getMonth();
    int getDay();
    int getYear();
	int getPriority();
	bool getIsCompleted();

	//setters
	/*void setName(std::string name);
	void setDate(Date date);
	void setPriority(int priority);
	void setIsCompleted(bool isCompleted);*/

};





#endif // !_TASK_H_