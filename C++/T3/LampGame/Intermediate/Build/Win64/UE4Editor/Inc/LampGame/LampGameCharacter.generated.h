// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
#ifdef LAMPGAME_LampGameCharacter_generated_h
#error "LampGameCharacter.generated.h already included, missing '#pragma once' in LampGameCharacter.h"
#endif
#define LAMPGAME_LampGameCharacter_generated_h

#define LampGame_Source_LampGame_LampGameCharacter_h_14_RPC_WRAPPERS
#define LampGame_Source_LampGame_LampGameCharacter_h_14_RPC_WRAPPERS_NO_PURE_DECLS
#define LampGame_Source_LampGame_LampGameCharacter_h_14_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesALampGameCharacter(); \
	friend struct Z_Construct_UClass_ALampGameCharacter_Statics; \
public: \
	DECLARE_CLASS(ALampGameCharacter, ACharacter, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/LampGame"), NO_API) \
	DECLARE_SERIALIZER(ALampGameCharacter)


#define LampGame_Source_LampGame_LampGameCharacter_h_14_INCLASS \
private: \
	static void StaticRegisterNativesALampGameCharacter(); \
	friend struct Z_Construct_UClass_ALampGameCharacter_Statics; \
public: \
	DECLARE_CLASS(ALampGameCharacter, ACharacter, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/LampGame"), NO_API) \
	DECLARE_SERIALIZER(ALampGameCharacter)


#define LampGame_Source_LampGame_LampGameCharacter_h_14_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API ALampGameCharacter(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(ALampGameCharacter) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, ALampGameCharacter); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(ALampGameCharacter); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API ALampGameCharacter(ALampGameCharacter&&); \
	NO_API ALampGameCharacter(const ALampGameCharacter&); \
public:


#define LampGame_Source_LampGame_LampGameCharacter_h_14_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API ALampGameCharacter(ALampGameCharacter&&); \
	NO_API ALampGameCharacter(const ALampGameCharacter&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, ALampGameCharacter); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(ALampGameCharacter); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(ALampGameCharacter)


#define LampGame_Source_LampGame_LampGameCharacter_h_14_PRIVATE_PROPERTY_OFFSET \
	FORCEINLINE static uint32 __PPO__Mesh1P() { return STRUCT_OFFSET(ALampGameCharacter, Mesh1P); } \
	FORCEINLINE static uint32 __PPO__FP_Gun() { return STRUCT_OFFSET(ALampGameCharacter, FP_Gun); } \
	FORCEINLINE static uint32 __PPO__FP_MuzzleLocation() { return STRUCT_OFFSET(ALampGameCharacter, FP_MuzzleLocation); } \
	FORCEINLINE static uint32 __PPO__VR_Gun() { return STRUCT_OFFSET(ALampGameCharacter, VR_Gun); } \
	FORCEINLINE static uint32 __PPO__VR_MuzzleLocation() { return STRUCT_OFFSET(ALampGameCharacter, VR_MuzzleLocation); } \
	FORCEINLINE static uint32 __PPO__FirstPersonCameraComponent() { return STRUCT_OFFSET(ALampGameCharacter, FirstPersonCameraComponent); } \
	FORCEINLINE static uint32 __PPO__R_MotionController() { return STRUCT_OFFSET(ALampGameCharacter, R_MotionController); } \
	FORCEINLINE static uint32 __PPO__L_MotionController() { return STRUCT_OFFSET(ALampGameCharacter, L_MotionController); }


#define LampGame_Source_LampGame_LampGameCharacter_h_11_PROLOG
#define LampGame_Source_LampGame_LampGameCharacter_h_14_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	LampGame_Source_LampGame_LampGameCharacter_h_14_PRIVATE_PROPERTY_OFFSET \
	LampGame_Source_LampGame_LampGameCharacter_h_14_RPC_WRAPPERS \
	LampGame_Source_LampGame_LampGameCharacter_h_14_INCLASS \
	LampGame_Source_LampGame_LampGameCharacter_h_14_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define LampGame_Source_LampGame_LampGameCharacter_h_14_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	LampGame_Source_LampGame_LampGameCharacter_h_14_PRIVATE_PROPERTY_OFFSET \
	LampGame_Source_LampGame_LampGameCharacter_h_14_RPC_WRAPPERS_NO_PURE_DECLS \
	LampGame_Source_LampGame_LampGameCharacter_h_14_INCLASS_NO_PURE_DECLS \
	LampGame_Source_LampGame_LampGameCharacter_h_14_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID LampGame_Source_LampGame_LampGameCharacter_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
