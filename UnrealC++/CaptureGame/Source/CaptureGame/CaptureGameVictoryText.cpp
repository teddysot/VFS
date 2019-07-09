// Fill out your copyright notice in the Description page of Project Settings.


#include "CaptureGameVictoryText.h"

#include "Components/BoxComponent.h"
#include "Components/StaticMeshComponent.h"
#include "Components/TextRenderComponent.h"

#pragma optimize( "", off )

// Sets default values
ACaptureGameVictoryText::ACaptureGameVictoryText()
{
	// Create component and attach to the root component
	CollisionComponent = CreateDefaultSubobject<UBoxComponent>(TEXT("CollisionComponent"));
	RootComponent = CollisionComponent;

	MeshComponent = CreateDefaultSubobject<UStaticMeshComponent>(TEXT("MeshComponent"));
	MeshComponent->AttachTo(RootComponent);

	TextComponent = CreateDefaultSubobject<UTextRenderComponent>(TEXT("TextComponent"));
	TextComponent->AttachTo(RootComponent);

	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
}

// Called when the game starts or when spawned
void ACaptureGameVictoryText::BeginPlay()
{
	Super::BeginPlay();

	FTransform NewTransform = GetActorTransform();
	NewTransform.SetScale3D(FVector(8.0f, 8.0f, 8.0f));

	SetActorTransform(NewTransform);

	TextComponent->SetText(FText::FromString("Victory")); // Set text
}

// Called every frame
void ACaptureGameVictoryText::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

#pragma optimize( "", on )