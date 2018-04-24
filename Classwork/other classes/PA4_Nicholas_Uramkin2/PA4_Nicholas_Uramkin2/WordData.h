

#ifndef _WORDDATA_H_
#define _WORDDATA_H_

#include<string>
#include<list>

class WordData
{
private:
	std::string word;
	//int *ptr;
	
	//LinkedList line;

	//std::list<int> lineNums;

public:
	//default constructor
	WordData();

	//constructor
	WordData(std::string word);

	//copy constructor
	WordData(const WordData &wd);

	//getters
	std::string getWord();

	//void AddLineNumber(int line);

	void setWord(std::string word);

	int toCompare(WordData wd);

	bool operator<(WordData& obj);
	bool operator>(WordData& obj);
	friend std::ostream& operator<<(std::ostream& os, WordData& obj);
	bool operator==(WordData& obj);
	bool operator!=(WordData& obj);



};


#endif // !_WORDDATA_H_
