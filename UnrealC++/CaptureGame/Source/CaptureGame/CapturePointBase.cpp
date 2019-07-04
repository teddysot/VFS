// Fill out your copyright notice in the Description page of Project Settings.

#include "CapturePointBase.h"

#include "Components/BoxComponent.h"
#include "Components/StaticMeshComponent.h"
#include "Components/TextRenderComponent.h"

#pragma optimize( "", off )

// Sets default values
ACapturePointBase::ACapturePointBase()
	: CaptureState(ECaptureState::NotCaptured)
{
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
void ACapturePointBase::BeginPlay()
{
	Super::BeginPlay();
	
	FTransform NewTransform = GetActorTransform();
	NewTransform.SetScale3D(FVector(8.0f, 8.0f, 8.0f));

	SetActorTransform(NewTransform);

	OnActorBeginOverlap.AddDynamic(this, &ACapturePointBase::OnOverlapBegin);
	OnActorEndOverlap.AddDynamic(this, &ACapturePointBase::OnOverlapEnd);
}

// Called every frame
void ACapturePointBase::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

	if (CaptureState == ECaptureState::Capturing)
	{
		CaptureTimeCurrent -= DeltaTime;

		if (CaptureTimeCurrent <= 0.0f)
		{
			MeshComponent->SetMaterial(0, CapturedMaterial);
			CaptureState = ECaptureState::Captured;
		}

		if (CaptureTime > 0.0f)
		{
			float Value = (1.0f - (CaptureTimeCurrent / CaptureTime)) * 100.0f;

			FString NewCaptureTime;
			NewCaptureTime = FString::Printf(TEXT("%.02f%"), Value);

			TextComponent->SetText(FText::FromString(NewCaptureTime));
		}
	}
}

void ACapturePointBase::OnOverlapBegin(AActor* OverlappedActor, AActor* OtherActor)
{
	if (CaptureState == ECaptureState::NotCaptured)
	{
		CaptureState = ECaptureState::Capturing;
		CaptureTimeCurrent = CaptureTime;
	}
}

void ACapturePointBase::OnOverlapEnd(AActor* OverlappedActor, AActor* OtherActor)
{
	if (CaptureState == ECaptureState::Capturing)
	{
		CaptureTimeCurrent = 0.0f;
		CaptureState = ECaptureState::NotCaptured;
	}
}

#pragma optimize( "", on )