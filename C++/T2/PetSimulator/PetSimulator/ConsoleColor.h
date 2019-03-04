/*
	ConsoleColor.h
	Created by: Teddy Nasahachart
*/
#include <Windows.h>

class ConsoleColor
{
public:
	void DarkBlue() { SetConsoleTextAttribute(hConsole, 1); }
	void DarkGreen() { SetConsoleTextAttribute(hConsole, 2); }
	void DarkCyan() { SetConsoleTextAttribute(hConsole, 3); }
	void DarkRed() { SetConsoleTextAttribute(hConsole, 4); }
	void DarkMagenta() { SetConsoleTextAttribute(hConsole, 5); }
	void DarkYellow() { SetConsoleTextAttribute(hConsole, 6); }
	void Grey() { SetConsoleTextAttribute(hConsole, 7); }
	void DarkGrey() { SetConsoleTextAttribute(hConsole, 8); }

	void Blue() { SetConsoleTextAttribute(hConsole, 9); }
	void Green() { SetConsoleTextAttribute(hConsole, 10); }
	void Cyan() { SetConsoleTextAttribute(hConsole, 11); }
	void Red() { SetConsoleTextAttribute(hConsole, 12); }
	void Magenta() { SetConsoleTextAttribute(hConsole, 13); }
	void Yellow() { SetConsoleTextAttribute(hConsole, 14); }
	void White() { SetConsoleTextAttribute(hConsole, 15); }

private:
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
};

