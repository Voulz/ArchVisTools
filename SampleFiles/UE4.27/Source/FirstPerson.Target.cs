// Copyright Voulz 2021. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FirstPersonTarget : TargetRules
{
	public FirstPersonTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "FirstPerson" } );
	}
}
