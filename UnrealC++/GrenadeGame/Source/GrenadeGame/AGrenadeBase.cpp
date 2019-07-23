// Fill out your copyright notice in the Description page of Project Settings.


#include "AGrenadeBase.h"

#include "Components/StaticMeshComponent.h"
#include "Components/SphereComponent.h"
#include "Particles/ParticleSystem.h"

#include "GameFramework/ProjectileMovementComponent.h"
#include "Kismet/GameplayStatics.h"

// Sets default values
AAGrenadeBase::AAGrenadeBase()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

	bReplicates = true;
	bReplicateMovement = true;

	SphereComponent = CreateDefaultSubobject<USphereComponent>(TEXT("SphereComponent"));
	RootComponent = SphereComponent;

	MeshComponent = CreateDefaultSubobject<UStaticMeshComponent>(TEXT("MeshComponent"));
	MeshComponent->AttachTo(RootComponent);

	ParticleSystem = CreateDefaultSubobject<UParticleSystem>(TEXT("ParticleSystem"));

	ProjectileMovementComponent = CreateDefaultSubobject<UProjectileMovementComponent>(TEXT("ProjectileMovementComponent"));
	ProjectileMovementComponent->SetUpdatedComponent(RootComponent);
}

// Called when the game starts or when spawned
void AAGrenadeBase::BeginPlay()
{
	Super::BeginPlay();

	UWorld* World = GetWorld();
	if (World != nullptr)
	{
		// Set Timer after throwing a greande for FuseTime seconds then call Explode function
		World->GetTimerManager().SetTimer(TimerHandle_Fuse, this, &AAGrenadeBase::Explode, FuseTime, false);
	}	
}

// Called every frame
void AAGrenadeBase::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

void AAGrenadeBase::Explode()
{
	// Spawn the particle effect at grenade location
	UGameplayStatics::SpawnEmitterAtLocation(GetWorld(), ParticleSystem, GetActorTransform());

	// Destroy grenade
	Destroy();
}