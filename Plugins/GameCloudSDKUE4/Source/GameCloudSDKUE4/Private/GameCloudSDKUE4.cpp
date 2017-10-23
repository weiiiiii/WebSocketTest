// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

#include "GameCloudSDKUE4.h"
#include "GameCloudSDKUE4/WebSocket/WebSocketBase.h"
#include "GameCloudSDKUE4/WebSocket/WebSocketBlueprintLibrary.h"

#define LOCTEXT_NAMESPACE "FGameCloudSDKUE4Module"

void FGameCloudSDKUE4Module::StartupModule()
{
	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module
	UWebSocketBase* socket	= UWebSocketBlueprintLibrary::Connect( "ws://localhost:9002" );
}

void FGameCloudSDKUE4Module::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FGameCloudSDKUE4Module, GameCloudSDKUE4)