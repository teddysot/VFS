// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#include "DragonGameGameMode.h"
#include "DragonGameHUD.h"
#include "DragonGameCharacter.h"
#include "UObject/ConstructorHelpers.h"

ADragonGameGameMode::ADragonGameGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = ADragonGameHUD::StaticClass();
}
