// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"

#include "Particles/ParticleSystem.h"

#include "AGrenadeBase.generated.h"


class UStaticMeshComponent;
class USphereComponent;
class UProjectileMovementComponent;
class ParticleSystem;

UCLASS()
class GRENADEGAME_API AAGrenadeBase : public AActor
{
	GENERATED_BODY()

public:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
		UStaticMeshComponent* MeshComponent;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
		USphereComponent* SphereComponent;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
		UProjectileMovementComponent* ProjectileMovementComponent;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	UParticleSystem* ParticleSystem;

	void Explode();


public:	
	// Sets default values for this actor's properties
	AAGrenadeBase();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

protected:

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	float FuseTime;

	UPROPERTY(Transient)
	FTimerHandle TimerHandle_Fuse;

};
