using System.IO;
using UnrealBuildTool;

public class RustLib2 : ModuleRules
{
	public RustLib2(ReadOnlyTargetRules Target) : base(Target)
	{
		const string LibName = "RustLib2";

		Type = ModuleType.External;
		PublicSystemIncludePaths.Add("$(ModuleDir)/Public");
		var buildConfiguration = Target.Configuration == UnrealTargetConfiguration.Shipping ? "release" : "debug";

		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			RuntimeDependencies.Add(Path.Combine("$(BinaryOutputDir)", $"{LibName}.dll"),
				Path.Combine(ModuleDirectory, "target", buildConfiguration, $"{LibName}.dll"));
			RuntimeDependencies.Add(Path.Combine("$(BinaryOutputDir)", $"{LibName}.pdb"),
				Path.Combine(ModuleDirectory, "target", buildConfiguration, $"{LibName}.pdb"),
				StagedFileType.DebugNonUFS);
			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "target", buildConfiguration,
				$"{LibName}.dll.lib"));
		}
	}
}