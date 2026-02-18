// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DreamCatcherProject : ModuleRules
{
	public DreamCatcherProject(ReadOnlyTargetRules Target) : base(Target)
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
			"DreamCatcherProject",
			"DreamCatcherProject/Variant_Platforming",
			"DreamCatcherProject/Variant_Platforming/Animation",
			"DreamCatcherProject/Variant_Combat",
			"DreamCatcherProject/Variant_Combat/AI",
			"DreamCatcherProject/Variant_Combat/Animation",
			"DreamCatcherProject/Variant_Combat/Gameplay",
			"DreamCatcherProject/Variant_Combat/Interfaces",
			"DreamCatcherProject/Variant_Combat/UI",
			"DreamCatcherProject/Variant_SideScrolling",
			"DreamCatcherProject/Variant_SideScrolling/AI",
			"DreamCatcherProject/Variant_SideScrolling/Gameplay",
			"DreamCatcherProject/Variant_SideScrolling/Interfaces",
			"DreamCatcherProject/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
