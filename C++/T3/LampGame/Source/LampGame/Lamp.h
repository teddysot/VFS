// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "Lamp.generated.h"

class UStaticMeshComponent;
class USpotLightComponent;
class UTextRenderComponent;

UCLASS()
class LAMPGAME_API ALamp : public AActor
{
	GENERATED_BODY()

	// Components Begin

	UPROPERTY(EditAnywhere)
	UStaticMeshComponent* DefaultDisplayComponent;

	UPROPERTY(EditAnywhere)
	USpotLightComponent* LightComponent;

	UPROPERTY(EditAnywhere)
	UTextRenderComponent* TextComponent;

public:
	// Sets default values for this actor's properties
	ALamp();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:
	// Called every frame
	virtual void Tick(float DeltaTime) override;

	UPROPERTY(EditAnywhere, Category=Brick)
	bool bMyProperty;

	UPROPERTY(EditAnywhere, Category=Brick)
	int32 dIntensity;

	UPROPERTY(EditAnywhere, Category = Brick)
	TArray<int32> dLocations;
};
