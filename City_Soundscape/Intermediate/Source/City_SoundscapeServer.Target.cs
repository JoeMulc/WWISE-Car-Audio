using UnrealBuildTool;

public class City_SoundscapeServerTarget : TargetRules
{
	public City_SoundscapeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("City_Soundscape");
	}
}
