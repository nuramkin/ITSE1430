#include "task.h"

Task::Task(std::string name, int month, int day, int year, int priority, bool isCompleted) 
	: name(name), month(month), day(day), year(year), priority(priority), isCompleted(isCompleted)
{}

std::string Task::getName()
{
	return name;
}

int Task::getMonth()
{
    return month;
}

int Task::getDay()
{
    return day;
}

int Task::getYear()
{
    return year;
}

int Task::getPriority()
{
	return priority;
}

bool Task::getIsCompleted()
{
	return isCompleted;
}

//void Task::setName(std::string name)
//{
//	this->name = name;
//}
//
//void Task::setDate(Date date)
//{
//	this->date = date;
//}
//
//void Task::setPriority(int priority)
//{
//	this->priority = priority;
//}
//
//void Task::setIsCompleted(bool isCompleted)
//{
//	this->isCompleted = isCompleted;
//}
