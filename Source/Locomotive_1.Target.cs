

using UnrealBuildTool;
using System.Collections.Generic;

public class Locomotive_1Target : TargetRules
{
	public Locomotive_1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Locomotive_1" } );
	}
}
