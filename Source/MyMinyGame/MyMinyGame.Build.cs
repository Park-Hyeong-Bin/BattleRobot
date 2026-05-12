// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MyMinyGame : ModuleRules
{
	public MyMinyGame(ReadOnlyTargetRules Target) : base(Target)
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
			"MyMinyGame",
			"MyMinyGame/Variant_Platforming",
			"MyMinyGame/Variant_Platforming/Animation",
			"MyMinyGame/Variant_Combat",
			"MyMinyGame/Variant_Combat/AI",
			"MyMinyGame/Variant_Combat/Animation",
			"MyMinyGame/Variant_Combat/Gameplay",
			"MyMinyGame/Variant_Combat/Interfaces",
			"MyMinyGame/Variant_Combat/UI",
			"MyMinyGame/Variant_SideScrolling",
			"MyMinyGame/Variant_SideScrolling/AI",
			"MyMinyGame/Variant_SideScrolling/Gameplay",
			"MyMinyGame/Variant_SideScrolling/Interfaces",
			"MyMinyGame/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
