using System.IO;
using UnrealBuildTool;

public class RustLib : ModuleRules
{
	public RustLib(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;
		PublicSystemIncludePaths.Add("$(ModuleDir)/Public");
		var buildConfiguration = Target.Configuration == UnrealTargetConfiguration.Shipping ? "release" : "debug";
		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "target", buildConfiguration, "rust_lib.lib"));
			PublicAdditionalLibraries.Add("ntdll.lib");
			PublicAdditionalLibraries.Add("userenv.lib");
		}		
	}
}
