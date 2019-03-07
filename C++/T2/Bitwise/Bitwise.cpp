//
// Bitwise.cpp
// version 1.3
//

#include "stdafx.h"

#include "SDL.h"

// sorry Mac users, please use Windows
#include <windows.h>

//=============================================================
//=============================================================

const int kViewportWidth = 800;
const int kViewportHeight = 600;

//=============================================================
//=============================================================

// 
// SDL is a common library used for input detection
// these are some scancodes from this list: https://wiki.libsdl.org/SDL_Keycode
//

//=============================================================
//=============================================================

class InputState
{
public:

	// the "friend" keyword allows you to bypass encapsulation
	// in this case, it allows InputManager to reach into my private variables
	friend class InputManager;

	InputState();
	~InputState();

	bool IsAttack() const;
	bool IsJump() const;
	bool IsDuck() const;
	bool IsForward() const;
	bool IsBack() const;
	bool IsUse() const;
	bool IsCancel() const;

private:

	const unsigned int mAttack = 0;
	const unsigned int mJump = 1;
	const unsigned int mDuck = 2;
	const unsigned int mForward = 3;
	const unsigned int mBack = 4;
	const unsigned int mUse = 5;
	const unsigned int mCancel = 6;
};

//=============================================================
//=============================================================

InputState::InputState()
{
}

InputState::~InputState()
{
}

bool InputState::IsAttack() const
{
	if (mAttack == 0001)
	{
		return true;
	}

	return false;
}

bool InputState::IsJump() const
{
	return mJump;
}

bool InputState::IsDuck() const
{
	return mDuck;
}

bool InputState::IsForward() const
{
	return mForward;
}

bool InputState::IsBack() const
{
	return mBack;
}

bool InputState::IsUse() const
{
	return mUse;
}

bool InputState::IsCancel() const
{
	return mCancel;
}

//=============================================================
//=============================================================

class InputManager
{
public:

	// this gets called each frame to query the system for the button states
	void Update();

	bool IsButtonDown( int nScancode ) const;

	const InputState& GetState() const { mState; }

private:

	InputState mState;

};

//=============================================================

unsigned int bitWisePowerTwo(unsigned int a)
{
	return (1 << a);
}
//=============================================================

void InputManager::Update()
{
	/*mState.mAttack = IsButtonDown( SDL_SCANCODE_LCTRL );
	mState.mJump = IsButtonDown( SDL_SCANCODE_SPACE );
	mState.mDuck = IsButtonDown( SDL_SCANCODE_LSHIFT );
	mState.mForward = IsButtonDown( SDL_SCANCODE_UP );
	mState.mBack = IsButtonDown( SDL_SCANCODE_DOWN );
	mState.mUse = IsButtonDown( SDL_SCANCODE_E );
	mState.mCancel = IsButtonDown( SDL_SCANCODE_BACKSPACE );*/

	if (IsButtonDown(SDL_SCANCODE_LCTRL))
	{
		if (bitWisePowerTwo(mState.mAttack) == 0001)
		{
			OutputDebugStringA("Attack!");
		}
	}

	if (IsButtonDown(SDL_SCANCODE_SPACE))
	{
		if (bitWisePowerTwo(mState.mJump) == 0010)
		{
			OutputDebugStringA("Jump!");
		}
	}

	if (IsButtonDown(SDL_SCANCODE_LSHIFT))
	{
		if (bitWisePowerTwo(mState.mDuck) == 0010)
		{
			OutputDebugStringA("Duck!");
		}
	}

	if (IsButtonDown(SDL_SCANCODE_UP))
	{
		if (bitWisePowerTwo(mState.mForward) == 0100)
		{
			OutputDebugStringA("Forward!");
		}
	}

	if (IsButtonDown(SDL_SCANCODE_DOWN))
	{
		if (bitWisePowerTwo(mState.mBack) == 01000)
		{
			OutputDebugStringA("Back!");
		}
	}

	if (IsButtonDown(SDL_SCANCODE_E))
	{
		if (bitWisePowerTwo(mState.mUse) == 010000)
		{
			OutputDebugStringA("Use!");
		}
	}

	if (IsButtonDown(SDL_SCANCODE_BACKSPACE))
	{
		if (bitWisePowerTwo(mState.mCancel) == 0100000)
		{
			OutputDebugStringA("Cancel!");
		}
	}
}

bool InputManager::IsButtonDown( int nScancode ) const
{
	int nKeys = 0;
	const Uint8* pKeys = SDL_GetKeyboardState( &nKeys );

	if ( pKeys == nullptr )
	{
		return false;
	}

	if ( nScancode >= nKeys )
	{
		return false;
	}

	return pKeys[nScancode];
}

//=============================================================
//=============================================================

//
// using Windows subsystem for this project
// use https://msdn.microsoft.com/en-us/library/windows/desktop/aa363362(v=vs.85).aspx
// for printing strings to debugger output
//

int WINAPI WinMain( HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow )
{
	// never allow two instances
	if ( hPrevInstance )
	{
		return 0;
	}

	// initialize SDL
	SDL_Init( SDL_INIT_VIDEO );

	SDL_Window* pWindow = SDL_CreateWindow( "Bitwise", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, kViewportWidth, kViewportHeight, SDL_WINDOW_SHOWN | SDL_WINDOW_INPUT_FOCUS );
	SDL_Renderer* pRenderer = SDL_CreateRenderer( pWindow, -1, 0 );

	SDL_Rect topLeftViewport;
	topLeftViewport.x = 0;
	topLeftViewport.y = 0;
	topLeftViewport.w = kViewportWidth;
	topLeftViewport.h = kViewportHeight;
	SDL_RenderSetViewport( pRenderer, &topLeftViewport );
	SDL_RenderSetScale( pRenderer, 1.0f, 1.0f );

	SDL_SetRenderDrawColor( pRenderer, 0, 0, 0, 255 );
	SDL_RenderClear( pRenderer );

	SDL_RenderPresent( pRenderer );

	// simple game loop
	InputManager inputManager;

	while ( true )
	{
		SDL_PumpEvents();

		SDL_Event event;

		while ( SDL_PollEvent( &event ) )
		{
			if ( event.type == SDL_QUIT )
			{
				exit( 0 );
			}

			inputManager.Update();

			Sleep( 100 ); // don't burn the CPU
		}
	}

    return 0;
}
