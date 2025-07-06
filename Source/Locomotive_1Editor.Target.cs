

using UnrealBuildTool;
using System.Collections.Generic;

public class Locomotive_1EditorTarget : TargetRules
{
	public Locomotive_1EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Locomotive_1" } );
	}
}
