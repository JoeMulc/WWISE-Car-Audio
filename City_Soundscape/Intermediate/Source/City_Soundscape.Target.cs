using UnrealBuildTool;

public class City_SoundscapeTarget : TargetRules
{
	public City_SoundscapeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("City_Soundscape");
	}
}
