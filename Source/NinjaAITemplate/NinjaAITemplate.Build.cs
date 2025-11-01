// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class NinjaAITemplate : ModuleRules
{
	public NinjaAITemplate(ReadOnlyTargetRules target) : base(target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
