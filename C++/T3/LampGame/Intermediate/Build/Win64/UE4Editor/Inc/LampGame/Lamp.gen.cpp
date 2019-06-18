// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "LampGame/Lamp.h"
#ifdef _MSC_VER
#pragma warning (push)
#pragma warning (disable : 4883)
#endif
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeLamp() {}
// Cross Module References
	LAMPGAME_API UClass* Z_Construct_UClass_ALamp_NoRegister();
	LAMPGAME_API UClass* Z_Construct_UClass_ALamp();
	ENGINE_API UClass* Z_Construct_UClass_AActor();
	UPackage* Z_Construct_UPackage__Script_LampGame();
	ENGINE_API UClass* Z_Construct_UClass_UTextRenderComponent_NoRegister();
	ENGINE_API UClass* Z_Construct_UClass_USpotLightComponent_NoRegister();
	ENGINE_API UClass* Z_Construct_UClass_UStaticMeshComponent_NoRegister();
// End Cross Module References
	void ALamp::StaticRegisterNativesALamp()
	{
	}
	UClass* Z_Construct_UClass_ALamp_NoRegister()
	{
		return ALamp::StaticClass();
	}
	struct Z_Construct_UClass_ALamp_Statics
	{
		static UObject* (*const DependentSingletons[])();
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam Class_MetaDataParams[];
#endif
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_dLocations_MetaData[];
#endif
		static const UE4CodeGen_Private::FArrayPropertyParams NewProp_dLocations;
		static const UE4CodeGen_Private::FIntPropertyParams NewProp_dLocations_Inner;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_dIntensity_MetaData[];
#endif
		static const UE4CodeGen_Private::FIntPropertyParams NewProp_dIntensity;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_bMyProperty_MetaData[];
#endif
		static void NewProp_bMyProperty_SetBit(void* Obj);
		static const UE4CodeGen_Private::FBoolPropertyParams NewProp_bMyProperty;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_TextComponent_MetaData[];
#endif
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_TextComponent;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_LightComponent_MetaData[];
#endif
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_LightComponent;
#if WITH_METADATA
		static const UE4CodeGen_Private::FMetaDataPairParam NewProp_DefaultDisplayComponent_MetaData[];
#endif
		static const UE4CodeGen_Private::FObjectPropertyParams NewProp_DefaultDisplayComponent;
		static const UE4CodeGen_Private::FPropertyParamsBase* const PropPointers[];
		static const FCppClassTypeInfoStatic StaticCppClassTypeInfo;
		static const UE4CodeGen_Private::FClassParams ClassParams;
	};
	UObject* (*const Z_Construct_UClass_ALamp_Statics::DependentSingletons[])() = {
		(UObject* (*)())Z_Construct_UClass_AActor,
		(UObject* (*)())Z_Construct_UPackage__Script_LampGame,
	};
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_ALamp_Statics::Class_MetaDataParams[] = {
		{ "IncludePath", "Lamp.h" },
		{ "ModuleRelativePath", "Lamp.h" },
	};
#endif
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_ALamp_Statics::NewProp_dLocations_MetaData[] = {
		{ "Category", "Brick" },
		{ "ModuleRelativePath", "Lamp.h" },
	};
#endif
	const UE4CodeGen_Private::FArrayPropertyParams Z_Construct_UClass_ALamp_Statics::NewProp_dLocations = { UE4CodeGen_Private::EPropertyClass::Array, "dLocations", RF_Public|RF_Transient|RF_MarkAsNative, (EPropertyFlags)0x0010000000000001, 1, nullptr, STRUCT_OFFSET(ALamp, dLocations), METADATA_PARAMS(Z_Construct_UClass_ALamp_Statics::NewProp_dLocations_MetaData, ARRAY_COUNT(Z_Construct_UClass_ALamp_Statics::NewProp_dLocations_MetaData)) };
	const UE4CodeGen_Private::FIntPropertyParams Z_Construct_UClass_ALamp_Statics::NewProp_dLocations_Inner = { UE4CodeGen_Private::EPropertyClass::Int, "dLocations", RF_Public|RF_Transient|RF_MarkAsNative, (EPropertyFlags)0x0000000000000000, 1, nullptr, 0, METADATA_PARAMS(nullptr, 0) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_ALamp_Statics::NewProp_dIntensity_MetaData[] = {
		{ "Category", "Brick" },
		{ "ModuleRelativePath", "Lamp.h" },
	};
#endif
	const UE4CodeGen_Private::FIntPropertyParams Z_Construct_UClass_ALamp_Statics::NewProp_dIntensity = { UE4CodeGen_Private::EPropertyClass::Int, "dIntensity", RF_Public|RF_Transient|RF_MarkAsNative, (EPropertyFlags)0x0010000000000001, 1, nullptr, STRUCT_OFFSET(ALamp, dIntensity), METADATA_PARAMS(Z_Construct_UClass_ALamp_Statics::NewProp_dIntensity_MetaData, ARRAY_COUNT(Z_Construct_UClass_ALamp_Statics::NewProp_dIntensity_MetaData)) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_ALamp_Statics::NewProp_bMyProperty_MetaData[] = {
		{ "Category", "Brick" },
		{ "ModuleRelativePath", "Lamp.h" },
	};
#endif
	void Z_Construct_UClass_ALamp_Statics::NewProp_bMyProperty_SetBit(void* Obj)
	{
		((ALamp*)Obj)->bMyProperty = 1;
	}
	const UE4CodeGen_Private::FBoolPropertyParams Z_Construct_UClass_ALamp_Statics::NewProp_bMyProperty = { UE4CodeGen_Private::EPropertyClass::Bool, "bMyProperty", RF_Public|RF_Transient|RF_MarkAsNative, (EPropertyFlags)0x0010000000000001, 1, nullptr, sizeof(bool), UE4CodeGen_Private::ENativeBool::Native, sizeof(ALamp), &Z_Construct_UClass_ALamp_Statics::NewProp_bMyProperty_SetBit, METADATA_PARAMS(Z_Construct_UClass_ALamp_Statics::NewProp_bMyProperty_MetaData, ARRAY_COUNT(Z_Construct_UClass_ALamp_Statics::NewProp_bMyProperty_MetaData)) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_ALamp_Statics::NewProp_TextComponent_MetaData[] = {
		{ "Category", "Lamp" },
		{ "EditInline", "true" },
		{ "ModuleRelativePath", "Lamp.h" },
	};
#endif
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UClass_ALamp_Statics::NewProp_TextComponent = { UE4CodeGen_Private::EPropertyClass::Object, "TextComponent", RF_Public|RF_Transient|RF_MarkAsNative, (EPropertyFlags)0x0040000000080009, 1, nullptr, STRUCT_OFFSET(ALamp, TextComponent), Z_Construct_UClass_UTextRenderComponent_NoRegister, METADATA_PARAMS(Z_Construct_UClass_ALamp_Statics::NewProp_TextComponent_MetaData, ARRAY_COUNT(Z_Construct_UClass_ALamp_Statics::NewProp_TextComponent_MetaData)) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_ALamp_Statics::NewProp_LightComponent_MetaData[] = {
		{ "Category", "Lamp" },
		{ "EditInline", "true" },
		{ "ModuleRelativePath", "Lamp.h" },
	};
#endif
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UClass_ALamp_Statics::NewProp_LightComponent = { UE4CodeGen_Private::EPropertyClass::Object, "LightComponent", RF_Public|RF_Transient|RF_MarkAsNative, (EPropertyFlags)0x0040000000080009, 1, nullptr, STRUCT_OFFSET(ALamp, LightComponent), Z_Construct_UClass_USpotLightComponent_NoRegister, METADATA_PARAMS(Z_Construct_UClass_ALamp_Statics::NewProp_LightComponent_MetaData, ARRAY_COUNT(Z_Construct_UClass_ALamp_Statics::NewProp_LightComponent_MetaData)) };
#if WITH_METADATA
	const UE4CodeGen_Private::FMetaDataPairParam Z_Construct_UClass_ALamp_Statics::NewProp_DefaultDisplayComponent_MetaData[] = {
		{ "Category", "Lamp" },
		{ "EditInline", "true" },
		{ "ModuleRelativePath", "Lamp.h" },
		{ "ToolTip", "Components Begin" },
	};
#endif
	const UE4CodeGen_Private::FObjectPropertyParams Z_Construct_UClass_ALamp_Statics::NewProp_DefaultDisplayComponent = { UE4CodeGen_Private::EPropertyClass::Object, "DefaultDisplayComponent", RF_Public|RF_Transient|RF_MarkAsNative, (EPropertyFlags)0x0040000000080009, 1, nullptr, STRUCT_OFFSET(ALamp, DefaultDisplayComponent), Z_Construct_UClass_UStaticMeshComponent_NoRegister, METADATA_PARAMS(Z_Construct_UClass_ALamp_Statics::NewProp_DefaultDisplayComponent_MetaData, ARRAY_COUNT(Z_Construct_UClass_ALamp_Statics::NewProp_DefaultDisplayComponent_MetaData)) };
	const UE4CodeGen_Private::FPropertyParamsBase* const Z_Construct_UClass_ALamp_Statics::PropPointers[] = {
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_ALamp_Statics::NewProp_dLocations,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_ALamp_Statics::NewProp_dLocations_Inner,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_ALamp_Statics::NewProp_dIntensity,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_ALamp_Statics::NewProp_bMyProperty,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_ALamp_Statics::NewProp_TextComponent,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_ALamp_Statics::NewProp_LightComponent,
		(const UE4CodeGen_Private::FPropertyParamsBase*)&Z_Construct_UClass_ALamp_Statics::NewProp_DefaultDisplayComponent,
	};
	const FCppClassTypeInfoStatic Z_Construct_UClass_ALamp_Statics::StaticCppClassTypeInfo = {
		TCppClassTypeTraits<ALamp>::IsAbstract,
	};
	const UE4CodeGen_Private::FClassParams Z_Construct_UClass_ALamp_Statics::ClassParams = {
		&ALamp::StaticClass,
		DependentSingletons, ARRAY_COUNT(DependentSingletons),
		0x009000A0u,
		nullptr, 0,
		Z_Construct_UClass_ALamp_Statics::PropPointers, ARRAY_COUNT(Z_Construct_UClass_ALamp_Statics::PropPointers),
		nullptr,
		&StaticCppClassTypeInfo,
		nullptr, 0,
		METADATA_PARAMS(Z_Construct_UClass_ALamp_Statics::Class_MetaDataParams, ARRAY_COUNT(Z_Construct_UClass_ALamp_Statics::Class_MetaDataParams))
	};
	UClass* Z_Construct_UClass_ALamp()
	{
		static UClass* OuterClass = nullptr;
		if (!OuterClass)
		{
			UE4CodeGen_Private::ConstructUClass(OuterClass, Z_Construct_UClass_ALamp_Statics::ClassParams);
		}
		return OuterClass;
	}
	IMPLEMENT_CLASS(ALamp, 318078225);
	static FCompiledInDefer Z_CompiledInDefer_UClass_ALamp(Z_Construct_UClass_ALamp, &ALamp::StaticClass, TEXT("/Script/LampGame"), TEXT("ALamp"), false, nullptr, nullptr, nullptr);
	DEFINE_VTABLE_PTR_HELPER_CTOR(ALamp);
PRAGMA_ENABLE_DEPRECATION_WARNINGS
#ifdef _MSC_VER
#pragma warning (pop)
#endif
