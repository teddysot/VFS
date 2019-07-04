// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "CapturePointBase.generated.h"

class UStaticMeshComponent;
class UShapeComponent;
class UTextRenderComponent;

class UMaterial;

enum class ECaptureState : uint8
{
	NotCaptured = 0,
	Capturing,
	Captured
};

UCLASS()
class CAPTUREGAME_API ACapturePointBase : public AActor
{
	GENERATED_BODY()

public:

	//
	// COMPONENTS START
	//

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	UStaticMeshComponent* MeshComponent;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	UShapeComponent* CollisionComponent;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	UTextRenderComponent* TextComponent;

	//
	// COMPONENTS END
	//

	//
	// PROPERTIES START
	//

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	UMaterial* CapturedMaterial;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	float CaptureTime;

	//
	// PROPERTIES END
	//
	
public:	
	// Sets default values for this actor's properties
	ACapturePointBase();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

	UFUNCTION()
	void OnOverlapBegin(AActor* OverlappedActor, AActor* OtherActor);

	UFUNCTION()
	void OnOverlapEnd(AActor* OverlappedActor, AActor* OtherActor);

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

	bool IsCaptured() const { return (CaptureState == ECaptureState::Captured); }

private:

	ECaptureState CaptureState;
	float CaptureTimeCurrent;

};
