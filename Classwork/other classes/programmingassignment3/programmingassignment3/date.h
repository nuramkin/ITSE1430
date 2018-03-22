#ifndef _DATE_H_
#define _DATE_H_

#include<string>

//date class
class Date
{
private:
	std::string month;
	std::string day;
	std::string year;

public:
    Date();
	Date(std::string month, std::string day, std::string year);

	//getters
	std::string getMonth();
	std::string getDay();
	std::string getYear();

	//setters
	void setMonth(std::string month);
	void setDay(std::string day);
	void setYear(std::string year);

};





#endif // !_DATE_H_
