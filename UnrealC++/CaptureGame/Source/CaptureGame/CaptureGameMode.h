// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "CaptureGameMode.generated.h"

class ACapturePointBase;

/**
 * 
 */
UCLASS()
class CAPTUREGAME_API ACaptureGameMode : public AGameModeBase
{
	GENERATED_BODY()

	ACaptureGameMode();

	virtual void BeginPlay() override;
	
	virtual void Tick(float DeltaSeconds) override;

private:

	UPROPERTY()
	TArray<ACapturePointBase*> CapturePoints;

};
