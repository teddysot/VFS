// Fill out your copyright notice in the Description page of Project Settings.

#include "CaptureGameMode.h"

#include "CaptureGameVictoryText.h"
#include "CaptureGameMode.h"
#include "CaptureGameHUD.h"
#include "CaptureGameCharacter.h"
#include "UObject/ConstructorHelpers.h"

#include "CaptureGame/CapturePointBase.h"

#include "EngineUtils.h"

ACaptureGameMode::ACaptureGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = ACaptureGameHUD::StaticClass();

	PrimaryActorTick.bStartWithTickEnabled = true;
	PrimaryActorTick.bCanEverTick = true;
}

void ACaptureGameMode::BeginPlay()
{
	Super::BeginPlay();

	UWorld* World = GetWorld();

	if (World != nullptr)
	{
		for (TActorIterator<ACapturePointBase> ActorIter(World); ActorIter; ++ActorIter)
		{
			ACapturePointBase* CapturePoint = *ActorIter;

			CapturePoints.Add(CapturePoint);
		}

		bCapturePointsDestroyed = false;


	}
}

void ACaptureGameMode::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);

	bool bCaptured = true;

	for (ACapturePointBase* CapturePoint : CapturePoints)
	{
		if (CapturePoint != nullptr && !CapturePoint->IsCaptured())
		{
			bCaptured = false;
			break;
		}
	}

	if (bCaptured && bCapturePointsDestroyed == false)
	{
		for (ACapturePointBase* CapturePoint : CapturePoints)
		{
			CapturePoint->Destroy();
			bCapturePointsDestroyed = true;
		}

		// Spawn an ACaptureGameVictoryText after captured all the capturepoints
		if (bCapturePointsDestroyed)
		{
			FVector Location(0.0f, 0.0f, 250.0f);
			FRotator Rotation(0.0f, 0.0f, 0.0f);
			FActorSpawnParameters SpawnInfo;
			GetWorld()->SpawnActor<ACaptureGameVictoryText>(VictoryToUse, Location, Rotation, SpawnInfo);
			bCapturePointsDestroyed = false;
		}
	}
}