// Fill out your copyright notice in the Description page of Project Settings.

#include "Lamp.h"

#include "Components/StaticMeshComponent.h"
#include "Components/SpotLightComponent.h"
#include "Components/TextRenderComponent.h"

// Sets default values
ALamp::ALamp()
{
	DefaultDisplayComponent = CreateDefaultSubobject<UStaticMeshComponent>(TEXT("DefaultDisplayComponent"));
	RootComponent = DefaultDisplayComponent;

	LightComponent = CreateDefaultSubobject<USpotLightComponent>(TEXT("LightComponent"));
	LightComponent->AttachTo(RootComponent);

	TextComponent = CreateDefaultSubobject<UTextRenderComponent>(TEXT("TextComponent"));
	TextComponent->AttachTo(RootComponent);

 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void ALamp::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void ALamp::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

