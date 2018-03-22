#include "task.h"

Task::Task(std::string name, std::string date, int priority, bool isCompleted) 
	: name(name), date(date), priority(priority), isCompleted(isCompleted)
{}

std::string Task::getName()
{
	return name;
}

std::string Task::getDate()
{
	return date;
}

int Task::getPriority()
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

void Task::setDate(std::string date)
{
	this->date = date;
}

void Task::setPriority(int priority)
{
	this->priority = priority;
}

void Task::setIsCompleted(bool isCompleted)
{
	this->isCompleted = isCompleted;
}
