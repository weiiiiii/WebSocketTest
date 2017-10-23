// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class GameCloudSDKUE4 : ModuleRules
{
	public GameCloudSDKUE4( ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				"GameCloudSDKUE4/Public"
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				"GameCloudSDKUE4/Private",
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);

		IncludeWebsocket( Target );
	}

	public string ProjectFolderPath
	{ get { return Path.GetFullPath( Path.Combine( ModuleDirectory, "../" ) ); } }

	public string ThirdPartyPath
	{ get { return Path.GetFullPath( Path.Combine( ProjectFolderPath, "ThirdParty" ) ); } }
	
	public void IncludeWebsocket( ReadOnlyTargetRules Target )
	{
		PublicDependencyModuleNames.Add( "Json" );
		PrivateDependencyModuleNames.Add( "JsonUtilities" );

		PublicDependencyModuleNames.Add( "Json" );
		PrivateDependencyModuleNames.Add( "JsonUtilities" );

		PrivateDependencyModuleNames.Add( "zlib" );
		PrivateDependencyModuleNames.Add( "OpenSSL" );

		// websocket path
		string webSocketPath	= Path.Combine( ThirdPartyPath, "WebSocket" );
		// add include path
		string includePath		= Path.Combine( webSocketPath, "include/Win64" );
		PublicIncludePaths.Add( includePath );
		// add library path
		string libraryPath		= Path.Combine( webSocketPath, "lib/Win64" );
		PublicLibraryPaths.Add( libraryPath );
		// add library
		PublicAdditionalLibraries.Add( "websockets_static.lib" );
	}
}
