#include <Windows.h>
#include <iostream>
#include "Car.h"


void OpenManual()
{
	// Clear screen first
	system("cls");
	std::cout << "Welcome to Teddy Car Simulator ^_^" << std::endl;
	std::cout << "Press M for open a manual" << std::endl;

	std::cout << "------------------------------------" << std::endl;
	std::cout << "--- Car Manual ---" << std::endl;

	std::cout << "1.Start Engine : [P]" << std::endl;
	std::cout << "2.Stop Engine : [O]" << std::endl;
	std::cout << "3.Shift Gear Up : [Z]" << std::endl;
	std::cout << "4.Shift Gear Down : [C]" << std::endl;
	std::cout << "5.Accelerator Peddle Down : [W]" << std::endl;
	std::cout << "6.Accelerator Peddle Up : [S]" << std::endl;
	std::cout << "6.Horn Press : [H]" << std::endl;
	std::cout << "7.Horn Release : [J]" << std::endl;

	std::cout << "------------------------------------" << std::endl;
}

int main()
{
	// Start up with a manual
	OpenManual();

	// Initialize a Car
	Car c;

	// For checking key Pressed/Released
	int flag = 0;

	// Running application loop
	while (1)
	{
		// Press ESC for exiting application
		if (GetAsyncKeyState(VK_ESCAPE))
		{
			PostQuitMessage(0);
			return 0;
		}

		// Open a manual
		if ((GetKeyState('M') & 0x8000) && (flag == 0))
		{
			OpenManual();
			flag = 1;
		}

		// Start Engine
		if ((GetKeyState('P') & 0x8000) && (flag == 0))
		{
			c.TurnKeyToStart();
			flag = 1;
		}

		// Stop Engine
		if ((GetKeyState('O') & 0x8000) && (flag == 0))
		{
			c.TurnKeyToStop();
			flag = 1;
		}

		// Shift Gear Up
		if ((GetKeyState('Z') & 0x8000) && (flag == 0))
		{
			c.ShiftGearUp();
			flag = 1;
		}

		// Shift Gear Down
		if ((GetKeyState('C') & 0x8000) && (flag == 0))
		{
			c.ShiftGearDown();
			flag = 1;
		}

		// Press Horn
		if ((GetKeyState('H') & 0x8000) && (flag == 0))
		{
			c.HornPressed();
			flag = 1;
		}

		// Released Horn
		if ((GetKeyState('J') & 0x8000) && (flag == 0))
		{
			c.HornReleased();
			flag = 1;
		}

		// Peddle Down
		if ((GetKeyState('W') & 0x8000))
		{
			c.AcceleratorPeddleDown(1.1f);
		}

		// Peddle Released
		if ((GetKeyState('S') & 0x8000))
		{
			c.AcceleratorPeddleReleased(0.1f);
		}

		else
		{
			flag = 0; // Reset the flag
			Sleep(100); // Give time for releasing key
		}
	};

	return 0;
}