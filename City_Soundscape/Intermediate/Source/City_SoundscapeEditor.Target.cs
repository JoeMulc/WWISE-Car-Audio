using UnrealBuildTool;

public class City_SoundscapeEditorTarget : TargetRules
{
	public City_SoundscapeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("City_Soundscape");
	}
}
