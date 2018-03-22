
#ifndef _TASK_H_
#define _TASK_H_

#include<string>

class Task
{
private:
	std::string name;
	std::string date;
	int priority;
	bool isCompleted;

public:
	Task(std::string name, std::string date, int priority, bool isCompleted);
	
	//getters
	std::string getName();
	std::string getDate();
	int getPriority();
	bool getIsCompleted();

	//setters
	void setName(std::string name);
	void setDate(std::string date);
	void setPriority(int priority);
	void setIsCompleted(bool isCompleted);

};





#endif // !_TASK_H_