// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "Lamp.generated.h"

// Forward Declaration
class UStaticMeshComponent;
class USpotLightComponent;
class UTextRenderComponent;

UCLASS()
class LAMPGAME_API ALamp : public AActor
{
	GENERATED_BODY()

	// Components Begin
	
	// Initialize Components
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
	
	// Initialize the properties and Set Categories
	UPROPERTY(EditAnywhere, Category=Brick)
	bool bMyProperty;

	UPROPERTY(EditAnywhere, Category=Brick)
	int32 Intensity;

	UPROPERTY(EditAnywhere, Category = Brick)
	TArray<int32> Locations;
};
