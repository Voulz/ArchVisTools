// Copyright Voulz 2021. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FirstPersonEditorTarget : TargetRules
{
	public FirstPersonEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "FirstPerson" } );
	}
}
