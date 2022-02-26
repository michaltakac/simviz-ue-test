// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class SimlVizTarget : TargetRules
{
	public SimlVizTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "SimlViz" } );
        // allow root user access in ue4 linux containers
        GlobalDefinitions.Add("UE4_DO_ROOT_PRIVILEGE_CHECK=0");
	}
}
