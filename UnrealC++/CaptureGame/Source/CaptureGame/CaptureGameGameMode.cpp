// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#include "CaptureGameGameMode.h"
#include "CaptureGameHUD.h"
#include "CaptureGameCharacter.h"
#include "UObject/ConstructorHelpers.h"

ACaptureGameGameMode::ACaptureGameGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = ACaptureGameHUD::StaticClass();
}
