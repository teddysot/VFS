// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#include "LampGameGameMode.h"
#include "LampGameHUD.h"
#include "LampGameCharacter.h"
#include "UObject/ConstructorHelpers.h"

ALampGameGameMode::ALampGameGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = ALampGameHUD::StaticClass();
}
