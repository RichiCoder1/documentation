Getting started
===============

Assume our build script have four steps where we want to:

1. Clean up old artifacts.
2. Build the code.
3. Run unit tests.
4. Package generated artifacts.

Creating the build script
-------------------------

A build script like that could look something like this.

.. code-block:: csharp

   var target = Argument<string>("target", "Package");
   var config = Argument<string>("config", "Release");

   Task("Clean")
   .Does(() =>
   {
      // Clean directories.
      CleanDirectory("./output");
      CleanDirectory("./output/bin");
      CleanDirectories("./src/**/bin/" + config);
   });

   Task("Build")
   .IsDependentOn("Clean")
   .Does(() =>
   {
      // Build the solution using MSBuild.
      MSBuild("./src/Project.sln", settings => 
         settings.SetConfiguration(config));     
   });

   Task("RunUnitTests")
   .IsDependentOn("Build")
   .Does(() =>
   {
      // Run xUnit tests.
      XUnit("./src/**/bin/" + config + "/*.Tests.dll");
   });

   Task("CopyFiles")
   .IsDependentOn("RunUnitTests")
   .Does(() =>
   {
      var path = "./src/Project/bin/" + configuration;    
      var files = GetFiles(path + "/**/*.dll") 
         + GetFiles(path + "/**/*.exe");

      // Copy all exe and dll files to the output directory.
      CopyFiles(files, "./output/bin");
   });    

   Task("Package")
   .IsDependentOn("RunUnitTests")
   .Does(() =>
   {
      // Zip all files in the bin directory.
      Zip("./output/bin", "./output/build.zip");
   });

   RunTarget(target);

Running the script
------------------

To run our build script we invoke `Cake.exe` with the script file as the first argument, and (optionally) the name of our target task as the second argument. We can also tell Cake how much information we're interested in with the built in `verbosity` parameter, which is very useful when debugging a script.

.. code-block:: bat

   C:> Cake.exe build.cake -target=Package -verbosity=diagnostic

This is just an example. Much more functionality is already implemented such as support for `MSBuild`, `MSTest`, `xUnit`, `NUnit`, `ILMerge`, `NuGet pack/restore` and the most common file system operations such as `file/folder manipulation` and `globbing`.

Try it out
----------

To see an actual build script in action, fork or clone the [GitHub repository](https://github.com/cake-build/cake) and run `build.cmd` which will download Cake from NuGet and run the `build.cake` script.
