var configuration = "Release";

// Define directories.
var buildDir = "./source/_compiler/bin/" + configuration;
var buildResultDir = "./tools/Compiler";

//////////////////////////////////////////////////////////////////////////

Task("Clean")
	.Description("Cleans the build and output directories.")
	.Does(() =>
{
	CleanDirectories(new DirectoryPath[] {
		buildDir, buildResultDir});
});

Task("Restore-NuGet-Packages")
	.Description("Restores all NuGet packages in solution.")
	.IsDependentOn("Clean")
	.Does(() =>
{
	NuGetRestore("./source/_compiler/Compiler.sln");
});

Task("Build")
	.Description("Builds the compiler source code.")
	.IsDependentOn("Restore-NuGet-Packages")
	.Does(() =>
{
	MSBuild("./source/_compiler/Compiler.sln", settings =>
		settings.SetConfiguration(configuration)
			.UseToolVersion(MSBuildToolVersion.NET45));
});

Task("Copy-Files")
	.Description("Copy files to the output directory.")
	.IsDependentOn("Build")
	.Does(() =>
{
	CopyFileToDirectory(buildDir + "/Compiler.exe", buildResultDir);
	CopyFileToDirectory(buildDir + "/Docudom.dll", buildResultDir);
	CopyFileToDirectory(buildDir + "/Cake.Core.dll", buildResultDir);
	CopyFileToDirectory(buildDir + "/Veil.Handlebars.dll", buildResultDir);
	CopyFileToDirectory(buildDir + "/Veil.dll", buildResultDir);
});

Task("All")
	.Description("Final target.")
	.IsDependentOn("Copy-Files");

//////////////////////////////////////////////////////////////////////////

RunTarget("All");