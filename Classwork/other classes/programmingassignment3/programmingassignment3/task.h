
#ifndef _TASK_H_
#define _TASK_H_

#include<string>

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
    //constructor
	Task(std::string name, int month, int day, int year, int priority, bool isCompleted);
	
	//getters
	std::string getName() const;
	int getMonth() const;
    int getDay() const;
    int getYear() const;
	int getPriority() const;
	bool getIsCompleted();

	//setters
	void setName(std::string name);
	void setMonth(int month);
    void setDay(int day);
    void setYear(int year);
	void setPriority(int priority);
	void setIsCompleted(bool isCompleted);

};





#endif // !_TASK_H_