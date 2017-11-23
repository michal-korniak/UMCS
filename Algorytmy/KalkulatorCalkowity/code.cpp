#include <iostream>
#include <string>
#include <cstdlib>
#include <cctype>
#include <stdexcept>
#include <ctime>
#include <cmath>

using namespace std;

int calc(string RPNinput);

template <typename T>
class MyStack
{
private:
	struct elem
	{
		T value;
		elem *before;
		elem(T value, elem *before)
		{
			this->value = value;
			this->before = before;
		}
	};
	elem* topElem;
public:
	MyStack()
	{
		topElem = NULL;
	}
	~MyStack()
	{
		while (topElem != NULL)
		{
			pop();
			topElem = NULL;
		}
	}
	void push(T val)
	{
		elem *temp = new elem(val, topElem);
		topElem = temp;

	}
	void pop()
	{
		if (topElem != NULL)
		{
			elem *temp = topElem->before;
			delete topElem;
			topElem = temp;
		}
	}
	T top()
	{
		return topElem->value;
	}
	bool empty()
	{
		return topElem == NULL;
	}
};

class ConvertInfixToRPN
{
public:
	string infixToRPN(string input)
	{
		string result;
		MyStack<char> operatorStack;
		unsigned int i = 0;
		int index = 0;
		bool previousTokenIsNumber = false;
		int numbersInResult = 0;
		bool badSyntax = false;

		while (i < input.length() && index != -1)
		{
			index = input.find(" ", i);
			string sub = input.substr(i, index - i);
			if (index != -1)
				i = index + 1;

			if (sub.length() > 1 || isdigit(sub[0]))	//jesli warunek przejdzie to znaczy, ze mamy liczbe
			{
				if (previousTokenIsNumber == true)
				{
					badSyntax = true;
				}
				result += sub;
				previousTokenIsNumber = true;
				continue;
			}
			//jesli poprzedni warunek nie przeszedl to mamy znak albo nawias
			char x = sub[0];
			previousTokenIsNumber = false;

			//<obsluga_nawiasow>
			if (isOpenBracket(x))
			{
				operatorStack.push(x);
				continue;
			}
			else if (isCloseBracket(x))
			{
				if (operatorStack.empty())
				{
					throw runtime_error("bledne nawiasy");
				}
				int numbersInsideBrackets = 0;
				while (operatorStack.top() != getOpenBracket(x))
				{
					numbersInsideBrackets++;
					if (isOpenBracket(operatorStack.top()) || isCloseBracket(operatorStack.top()))
						throw runtime_error("bledne nawiasy");
					if (result[result.length() - 1] == ' ')
						badSyntax = true;
					result += " ";
					result += operatorStack.top();
					operatorStack.pop();
				}
				if (numbersInsideBrackets == 0)
					badSyntax = true;
				operatorStack.pop();
				continue;
			}
			//</obsluga_nawiasow>

			else
			{
				if (operatorStack.empty() || isOpenBracket(operatorStack.top()))
					operatorStack.push(x);
				else
				{
					bool enterLoop = false;
					while (!operatorStack.empty() && !isOpenBracket(operatorStack.top()) &&
						isEqualOrGreaterPrecedenceThan(operatorStack.top(), x))
					{
						enterLoop = true;
						result += " ";
						result += operatorStack.top();
						operatorStack.pop();

					}
					operatorStack.push(x);
				}
			}
			result += " ";

		}
		while (!operatorStack.empty())
		{
			if (isOpenBracket(operatorStack.top()) || isCloseBracket(operatorStack.top()))
				throw runtime_error("bledne nawiasy");
			result += " ";
			result += operatorStack.top();

			operatorStack.pop();
		}
		if (badSyntax == true)
			throw runtime_error("bledna skladnia");
		return result;


	}
	ConvertInfixToRPN()
	{
		precedenceArr[0] = OperPrec('+', 1);
		precedenceArr[1] = OperPrec('~', 1);
		precedenceArr[2] = OperPrec('*', 2);
		precedenceArr[3] = OperPrec('d', 2);
		precedenceArr[4] = OperPrec('m', 2);
		precedenceArr[5] = OperPrec('^', 3);
	}

private:
	struct OperPrec
	{
		char oper;
		int prec;
		OperPrec(char oper, int prec)
		{
			this->oper = oper;
			this->prec = prec;
		}
		OperPrec()
		{

		}
	};
	OperPrec precedenceArr[6];
	char getOpenBracket(char closeBracket)
	{
		if (closeBracket == ')')
			return '(';
		else if (closeBracket == ']')
			return '[';
		else if (closeBracket == '}')
			return '{';
		return -1;
	}
	bool isOpenBracket(char x)
	{
		if (x == '(' || x == '[' || x == '{')
			return true;
		return false;
	}
	bool isCloseBracket(char x)
	{
		if ((x == ')' || x == ']' || x == '}'))
			return true;
		return false;
	}
	bool isEqualOrGreaterPrecedenceThan(char x, char y)
	{
		int xPrec = -1;
		int yPrec = -1;
		for (int i = 0; i < 6; i++)
		{
			if (precedenceArr[i].oper == x)
				xPrec = precedenceArr[i].prec;
			if (precedenceArr[i].oper == y)
				yPrec = precedenceArr[i].prec;
		}
		if (xPrec == -1 || yPrec == -1)
			throw runtime_error("bledna skladnia");
		return !(yPrec > xPrec);
	}
};

int calc(string RPNinput)
{
	MyStack<int> numbers;
	unsigned int i = 0;
	int index = 0;
	while (i < RPNinput.length() && index != -1)
	{
		index = RPNinput.find(" ", i);
		string sub = RPNinput.substr(i, index - i);
		if (index != -1)
			i = index + 1;
		if (sub == "+")
		{
			int x = numbers.top();
			numbers.pop();
			int y = numbers.top();
			numbers.pop();
			numbers.push(y + x);
		}
		else if (sub == "~")
		{
			int x = numbers.top();
			numbers.pop();
			int y = numbers.top();
			numbers.pop();
			numbers.push(y - x);
		}
		else if (sub == "*")
		{
			int x = numbers.top();
			numbers.pop();
			int y = numbers.top();
			numbers.pop();
			numbers.push(y*x);
		}
		else if (sub == "d")
		{
			int x = numbers.top();
			if (x <= 0)
				throw runtime_error("bledne dzialanie");
			numbers.pop();
			int y = numbers.top();
			numbers.pop();
			numbers.push(y / x);
		}
		else if (sub == "m")
		{
			int x = numbers.top();
			if (x <= 0)
				throw runtime_error("bledne dzialanie");
			numbers.pop();
			int y = numbers.top();
			numbers.pop();
			numbers.push(y % x);
		}
		else if (sub == "^")
		{
			int x = numbers.top();
			numbers.pop();
			int y = numbers.top();
			numbers.pop();
			if (((x == 0 && y == 0)) || x < 0)
				throw runtime_error("bledne dzialanie");
			numbers.push((int)pow(y, x));
		}
		else
		{
			if (sub.length() > 1 || isdigit(sub[0]))		//jeœli mamy liczbe
			{
				int x = atoi(sub.c_str());
				numbers.push(x);
			}
			else
				throw runtime_error("bledna skladnia");
			
		}
	}
	if (numbers.empty())
		throw runtime_error("bledna skladnia");
	return numbers.top();
}

void debug();
void tichy();

int main()
{
	tichy();
	return 0;
}
void debug()
{
	string input;
	int i = 0;
	while (1)
	{
		getline(cin, input);
		try
		{
			string RPN = ConvertInfixToRPN().infixToRPN(input);
			cout << "RPN: " << RPN << endl;
			cout << calc(RPN) << endl;
		}
		catch (runtime_error ex)
		{
			cout << ex.what() << endl;
		}
	}
}
void tichy()
{
	string input;
	int i = 0;
	int temp;
	cin >> temp;
	cin.get();
	getline(cin, input);
	try
	{
		string RPN = ConvertInfixToRPN().infixToRPN(input);
		cout << calc(RPN) << endl;
	}
	catch (runtime_error ex)
	{
		cout << ex.what() << endl;
	}
}