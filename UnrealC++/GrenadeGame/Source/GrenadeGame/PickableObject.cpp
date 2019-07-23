// Fill out your copyright notice in the Description page of Project Settings.


#include "PickableObject.h"

#include "Components/StaticMeshComponent.h"
#include "Components/SphereComponent.h"

#include "GrenadeGameCharacter.h"

// Sets default values
APickableObject::APickableObject()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

	bReplicates = true;
	bReplicateMovement = true;

	SphereComponent = CreateDefaultSubobject<USphereComponent>(TEXT("SphereComponent"));
	RootComponent = SphereComponent;

	MeshComponent = CreateDefaultSubobject<UStaticMeshComponent>(TEXT("MeshComponent"));
	MeshComponent->AttachTo(RootComponent);

	SphereComponent->OnComponentBeginOverlap.AddDynamic(this, &APickableObject::OnOverlapBegin);
}

#pragma optimize( "", off )

void APickableObject::OnOverlapBegin(UPrimitiveComponent * OverlappedComp, AActor * OtherActor, UPrimitiveComponent * OtherComp, int32 OtherBodyIndex, bool bFromSweep, const FHitResult & SweepResult)
{
	if (OtherActor != nullptr && Cast<AGrenadeGameCharacter>(OtherActor) != nullptr)
	{
		AGrenadeGameCharacter* Character = Cast<AGrenadeGameCharacter>(OtherActor);

		Character->AmountGrenade++;
		Destroy();
	}
}

#pragma optimize( "", on )

// Called when the game starts or when spawned
void APickableObject::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void APickableObject::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

