#include "WordData.h"

WordData::WordData()
{}

WordData::WordData(std::string word) : word(word)
{}

WordData::WordData(const WordData & wd)
{
	//ptr = new int;
	//*ptr = *wd.ptr;
	this->word = wd.word;
	//lineNums = wd.lineNums;
	/*for (int lineNum : wd.lineNums)
	{
		lineNums.push_back(lineNum);
	}*/
}

std::string WordData::getWord()
{
	return word;
}

//void WordData::AddLineNumber(int lineNum)
//{
//	lineNums.push_back(lineNum);
//}

void WordData::setWord(std::string word)
{
	this->word = word;
}

int WordData::toCompare(WordData wd)
{
	return word.compare(wd.word);
}

bool WordData::operator<(WordData & obj)
{
	return word < obj.getWord();
}

bool WordData::operator>(WordData & obj)
{
	return word > obj.getWord();
}

bool WordData::operator==(WordData & obj)
{
    return word == obj.getWord();
}

bool WordData::operator!=(WordData & obj)
{
    return word != obj.getWord();
}

std::ostream & operator<<(std::ostream & os, WordData & obj)
{
	os << obj.getWord();
	return os;
}
