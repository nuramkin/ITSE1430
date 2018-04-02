#include "date.h"

Date::Date()
{}

Date::Date(int month, int day, int year) : month(month), day(day), year(year)
{}

int Date::getMonth()
{
	return month;
}

int Date::getDay()
{
	return day;
}

int Date::getYear()
{
	return year;
}

void Date::setMonth(int month)
{
}

void Date::setDay(int day)
{
}

void Date::setYear(int year)
{
}
