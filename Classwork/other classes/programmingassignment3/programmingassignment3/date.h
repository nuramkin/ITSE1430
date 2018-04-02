#ifndef _DATE_H_
#define _DATE_H_

#include<string>

//date class
class Date
{
private:
	int month;
	int day;
	int year;

public:
    Date();
	Date(int month, int day, int year);

	//getters
	int getMonth();
	int getDay();
	int getYear();

	//setters
	void setMonth(int month);
	void setDay(int day);
	void setYear(int year);

};





#endif // !_DATE_H_
