// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class EchoTownMusic : ModuleRules
{
	public EchoTownMusic(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"EchoTownMusic",
			"EchoTownMusic/Variant_Platforming",
			"EchoTownMusic/Variant_Platforming/Animation",
			"EchoTownMusic/Variant_Combat",
			"EchoTownMusic/Variant_Combat/AI",
			"EchoTownMusic/Variant_Combat/Animation",
			"EchoTownMusic/Variant_Combat/Gameplay",
			"EchoTownMusic/Variant_Combat/Interfaces",
			"EchoTownMusic/Variant_Combat/UI",
			"EchoTownMusic/Variant_SideScrolling",
			"EchoTownMusic/Variant_SideScrolling/AI",
			"EchoTownMusic/Variant_SideScrolling/Gameplay",
			"EchoTownMusic/Variant_SideScrolling/Interfaces",
			"EchoTownMusic/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
