// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
class UPrimitiveComponent;
class AActor;
struct FVector;
struct FHitResult;
#ifdef LAMPGAME_LampGameProjectile_generated_h
#error "LampGameProjectile.generated.h already included, missing '#pragma once' in LampGameProjectile.h"
#endif
#define LAMPGAME_LampGameProjectile_generated_h

#define LampGame_Source_LampGame_LampGameProjectile_h_12_RPC_WRAPPERS \
 \
	DECLARE_FUNCTION(execOnHit) \
	{ \
		P_GET_OBJECT(UPrimitiveComponent,Z_Param_HitComp); \
		P_GET_OBJECT(AActor,Z_Param_OtherActor); \
		P_GET_OBJECT(UPrimitiveComponent,Z_Param_OtherComp); \
		P_GET_STRUCT(FVector,Z_Param_NormalImpulse); \
		P_GET_STRUCT_REF(FHitResult,Z_Param_Out_Hit); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->OnHit(Z_Param_HitComp,Z_Param_OtherActor,Z_Param_OtherComp,Z_Param_NormalImpulse,Z_Param_Out_Hit); \
		P_NATIVE_END; \
	}


#define LampGame_Source_LampGame_LampGameProjectile_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
 \
	DECLARE_FUNCTION(execOnHit) \
	{ \
		P_GET_OBJECT(UPrimitiveComponent,Z_Param_HitComp); \
		P_GET_OBJECT(AActor,Z_Param_OtherActor); \
		P_GET_OBJECT(UPrimitiveComponent,Z_Param_OtherComp); \
		P_GET_STRUCT(FVector,Z_Param_NormalImpulse); \
		P_GET_STRUCT_REF(FHitResult,Z_Param_Out_Hit); \
		P_FINISH; \
		P_NATIVE_BEGIN; \
		P_THIS->OnHit(Z_Param_HitComp,Z_Param_OtherActor,Z_Param_OtherComp,Z_Param_NormalImpulse,Z_Param_Out_Hit); \
		P_NATIVE_END; \
	}


#define LampGame_Source_LampGame_LampGameProjectile_h_12_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesALampGameProjectile(); \
	friend struct Z_Construct_UClass_ALampGameProjectile_Statics; \
public: \
	DECLARE_CLASS(ALampGameProjectile, AActor, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/LampGame"), NO_API) \
	DECLARE_SERIALIZER(ALampGameProjectile) \
	static const TCHAR* StaticConfigName() {return TEXT("Game");} \



#define LampGame_Source_LampGame_LampGameProjectile_h_12_INCLASS \
private: \
	static void StaticRegisterNativesALampGameProjectile(); \
	friend struct Z_Construct_UClass_ALampGameProjectile_Statics; \
public: \
	DECLARE_CLASS(ALampGameProjectile, AActor, COMPILED_IN_FLAGS(0), CASTCLASS_None, TEXT("/Script/LampGame"), NO_API) \
	DECLARE_SERIALIZER(ALampGameProjectile) \
	static const TCHAR* StaticConfigName() {return TEXT("Game");} \



#define LampGame_Source_LampGame_LampGameProjectile_h_12_STANDARD_CONSTRUCTORS \
	/** Standard constructor, called after all reflected properties have been initialized */ \
	NO_API ALampGameProjectile(const FObjectInitializer& ObjectInitializer); \
	DEFINE_DEFAULT_OBJECT_INITIALIZER_CONSTRUCTOR_CALL(ALampGameProjectile) \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, ALampGameProjectile); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(ALampGameProjectile); \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API ALampGameProjectile(ALampGameProjectile&&); \
	NO_API ALampGameProjectile(const ALampGameProjectile&); \
public:


#define LampGame_Source_LampGame_LampGameProjectile_h_12_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	NO_API ALampGameProjectile(ALampGameProjectile&&); \
	NO_API ALampGameProjectile(const ALampGameProjectile&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, ALampGameProjectile); \
DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(ALampGameProjectile); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(ALampGameProjectile)


#define LampGame_Source_LampGame_LampGameProjectile_h_12_PRIVATE_PROPERTY_OFFSET \
	FORCEINLINE static uint32 __PPO__CollisionComp() { return STRUCT_OFFSET(ALampGameProjectile, CollisionComp); } \
	FORCEINLINE static uint32 __PPO__ProjectileMovement() { return STRUCT_OFFSET(ALampGameProjectile, ProjectileMovement); }


#define LampGame_Source_LampGame_LampGameProjectile_h_9_PROLOG
#define LampGame_Source_LampGame_LampGameProjectile_h_12_GENERATED_BODY_LEGACY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	LampGame_Source_LampGame_LampGameProjectile_h_12_PRIVATE_PROPERTY_OFFSET \
	LampGame_Source_LampGame_LampGameProjectile_h_12_RPC_WRAPPERS \
	LampGame_Source_LampGame_LampGameProjectile_h_12_INCLASS \
	LampGame_Source_LampGame_LampGameProjectile_h_12_STANDARD_CONSTRUCTORS \
public: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#define LampGame_Source_LampGame_LampGameProjectile_h_12_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	LampGame_Source_LampGame_LampGameProjectile_h_12_PRIVATE_PROPERTY_OFFSET \
	LampGame_Source_LampGame_LampGameProjectile_h_12_RPC_WRAPPERS_NO_PURE_DECLS \
	LampGame_Source_LampGame_LampGameProjectile_h_12_INCLASS_NO_PURE_DECLS \
	LampGame_Source_LampGame_LampGameProjectile_h_12_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID LampGame_Source_LampGame_LampGameProjectile_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS