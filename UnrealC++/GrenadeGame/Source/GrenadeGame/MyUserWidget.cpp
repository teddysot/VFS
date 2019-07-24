// Fill out your copyright notice in the Description page of Project Settings.


#include "MyUserWidget.h"
#include "TextBlock.h"
#include "GrenadeGameCharacter.h"
#include "EngineUtils.h"

bool UMyUserWidget::Initialize()
{
	bool bResult = Super::Initialize();

	if (!bResult)
	{
		return false;
	}

	Widget = Cast<UTextBlock>(GetWidgetFromName("TextBlock_Red"));

	if (Widget != nullptr)
	{
		Widget->SetText(FText::FromString("HELLO"));
	}

	return true;
}

void UMyUserWidget::NativeTick(const FGeometry& MyGeometry, float InDeltaTime)
{
	// here you can update your text block to show the grenade count

	AGrenadeGameCharacter* Character;
	// Get the first actor of type AMyBox.
	for (TActorIterator<AGrenadeGameCharacter> ActorIt(GetWorld()); ActorIt; ++ActorIt)
	{
		Character = *ActorIt;

		FString grenade = FString::FromInt(Character->GrenadeCount);
		Widget->SetText(FText::FromString(grenade));
		break;
	}
}