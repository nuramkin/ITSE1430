#include "task.h"

Task::Task(std::string name, int month, int day, int year, int priority, bool isCompleted) 
	: name(name), month(month), day(day), year(year), priority(priority), isCompleted(isCompleted)
{}

std::string Task::getName() const
{
	return name;
}

int Task::getMonth() const
{
    return month;
}

int Task::getDay() const
{
    return day;
}

int Task::getYear() const
{
    return year;
}

int Task::getPriority() const
{
	return priority;
}

bool Task::getIsCompleted()
{
	return isCompleted;
}

void Task::setName(std::string name)
{
    this->name = name;
}

void Task::setMonth(int month)
{
    this->month = month;
}

void Task::setDay(int day)
{
    this->day = day;
}

void Task::setYear(int year)
{
    this->year = year;
}

void Task::setPriority(int priority)
{
    this->priority = priority;
}

void Task::setIsCompleted(bool isCompleted)
{
    this->isCompleted = isCompleted;
}
