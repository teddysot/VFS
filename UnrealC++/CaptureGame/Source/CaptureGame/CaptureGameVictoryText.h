// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "CaptureGameVictoryText.generated.h"

class UStaticMeshComponent;
class UShapeComponent;
class UTextRenderComponent;

UCLASS()
class CAPTUREGAME_API ACaptureGameVictoryText : public AActor
{
	GENERATED_BODY()

public:

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
		UStaticMeshComponent* MeshComponent;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
		UShapeComponent* CollisionComponent;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
		UTextRenderComponent* TextComponent;

	
public:	
	// Sets default values for this actor's properties
	ACaptureGameVictoryText();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

};
