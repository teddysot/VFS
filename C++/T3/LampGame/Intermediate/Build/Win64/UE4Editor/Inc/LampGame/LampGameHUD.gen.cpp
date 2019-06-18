// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "LampGame/LampGameHUD.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeLampGameHUD() {}
// Cross Module References
	LAMPGAME_API UClass* Z_Construct_UClass_ALampGameHUD_NoRegister();
	LAMPGAME_API UClass* Z_Construct_UClass_ALampGameHUD();
	ENGINE_API UClass* Z_Construct_UClass_AHUD();
	UPackage* Z_Construct_UPackage__Script_LampGame();
// End Cross Module References
	void ALampGameHUD::StaticRegisterNativesALampGameHUD()
	{
	}
	UClass* Z_Construct_UClass_ALampGameHUD_NoRegister()
	{
		return ALampGameHUD::StaticClass();
	}
	struct Z_Construct_UClass_ALampGameHUD_Statics
	{
		static UObject* (*const DependentSingletons[])();
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_ALampGameHUD_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_AHUD,
		(UObject* (*)())Z_Construct_UPackage__Script_LampGame,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_ALampGameHUD_Statics::Class_MetaDataParams[] = {
		{ "HideCategories", "Rendering Actor Input Replication" },
		{ "IncludePath", "LampGameHUD.h" },
		{ "ModuleRelativePath", "LampGameHUD.h" },
		{ "ShowCategories", "Input|MouseInput Input|TouchInput" },
	};
#endif
	const FCppClassTypeInfoStatic Z_Construct_UClass_ALampGameHUD_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<ALampGameHUD>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_ALampGameHUD_Statics::ClassParams = {
		&ALampGameHUD::StaticClass,
		DependentSingletons, ARRAY_COUNT(DependentSingletons),
		0x008002ACu,
		nullptr, 0,
		nullptr, 0,
		"Game",
		&StaticCppClassTypeInfo,
		nullptr, 0,
		METADATA_PARAMS(Z_Construct_UClass_ALampGameHUD_Statics::Class_MetaDataParams, ARRAY_COUNT(Z_Construct_UClass_ALampGameHUD_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_ALampGameHUD()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_ALampGameHUD_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(ALampGameHUD, 3989056993);
	static FCompiledInDefer Z_CompiledInDefer_UClass_ALampGameHUD(Z_Construct_UClass_ALampGameHUD, &ALampGameHUD::StaticClass, TEXT("/Script/LampGame"), TEXT("ALampGameHUD"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(ALampGameHUD);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
