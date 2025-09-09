using UnrealBuildTool;

public class City_SoundscapeClientTarget : TargetRules
{
	public City_SoundscapeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("City_Soundscape");
	}
}
