// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
#ifdef LAMPGAME_Lamp_generated_h
#error "Lamp.generated.h already included, missing '#pragma once' in Lamp.h"
#endif
#define LAMPGAME_Lamp_generated_h

#define LampGame_Source_LampGame_Lamp_h_16_RPC_WRAPPERS
#define LampGame_Source_LampGame_Lamp_h_16_RPC_WRAPPERS_NO_PURE_DECLS
#define LampGame_Source_LampGame_Lamp_h_16_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesALamp(); \
	friend struct Z_Construct_UClass_ALamp_Statics; \
public: \
	DECLARE_CLASS(ALamp, AActor, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/LampGame"), NO_API) \
	DECLARE_SERIALIZER(ALamp)


#define LampGame_Source_LampGame_Lamp_h_16_INCLASS \
private: \
	static void StaticRegisterNativesALamp(); \
	friend struct Z_Construct_UClass_ALamp_Statics; \
public: \
	DECLARE_CLASS(ALamp, AActor, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/LampGame"), NO_API) \
	DECLARE_SERIALIZER(ALamp)


#define LampGame_Source_LampGame_Lamp_h_16_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API ALamp(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(ALamp) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, ALamp); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(ALamp); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API ALamp(ALamp&&); \
	NO_API ALamp(const ALamp&); \
public:


#define LampGame_Source_LampGame_Lamp_h_16_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API ALamp(ALamp&&); \
	NO_API ALamp(const ALamp&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, ALamp); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(ALamp); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(ALamp)


#define LampGame_Source_LampGame_Lamp_h_16_PRIVATE_PROPERTY_OFFSET \
	FORCEINLINE static uint32 __PPO__DefaultDisplayComponent() { return STRUCT_OFFSET(ALamp, DefaultDisplayComponent); } \
	FORCEINLINE static uint32 __PPO__LightComponent() { return STRUCT_OFFSET(ALamp, LightComponent); } \
	FORCEINLINE static uint32 __PPO__TextComponent() { return STRUCT_OFFSET(ALamp, TextComponent); }


#define LampGame_Source_LampGame_Lamp_h_13_PROLOG
#define LampGame_Source_LampGame_Lamp_h_16_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	LampGame_Source_LampGame_Lamp_h_16_PRIVATE_PROPERTY_OFFSET \
	LampGame_Source_LampGame_Lamp_h_16_RPC_WRAPPERS \
	LampGame_Source_LampGame_Lamp_h_16_INCLASS \
	LampGame_Source_LampGame_Lamp_h_16_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define LampGame_Source_LampGame_Lamp_h_16_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	LampGame_Source_LampGame_Lamp_h_16_PRIVATE_PROPERTY_OFFSET \
	LampGame_Source_LampGame_Lamp_h_16_RPC_WRAPPERS_NO_PURE_DECLS \
	LampGame_Source_LampGame_Lamp_h_16_INCLASS_NO_PURE_DECLS \
	LampGame_Source_LampGame_Lamp_h_16_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID LampGame_Source_LampGame_Lamp_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
