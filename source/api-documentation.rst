API documentation
=================

Arguments
---------

.. code-block:: csharp

   Cake.Common.ArgumentExtensions.Argument(String name)

Gets an argument.

.. code-block:: csharp

   Cake.Common.ArgumentExtensions.Argument(String name, T defaultValue)

Gets an argument.

.. code-block:: csharp

   Cake.Common.ArgumentExtensions.HasArgument(String name)

Determines whether or not the specified argument exist.

Assembly Info
-------------

.. code-block:: csharp

   Cake.Common.AssemblyInfoExtensions.CreateAssemblyInfo(FilePath outputPath, AssemblyInfoSettings settings)

Creates an assembly information file.

Release Notes
-------------

.. code-block:: csharp

   Cake.Common.ReleaseNotesExtensions.ParseAllReleaseNotes(FilePath filePath)

Parses all release notes.

.. code-block:: csharp

   Cake.Common.ReleaseNotesExtensions.ParseReleaseNotes(FilePath filePath)

Parses the latest release notes.

Logging
-------

.. code-block:: csharp

   Cake.Common.Diagnostics.LoggingExtensions.Debug(String format, params Object[] args)

Writes a debug message to the log using the specified format information.

.. code-block:: csharp

   Cake.Common.Diagnostics.LoggingExtensions.Error(String format, params Object[] args)

Writes an error message to the log using the specified format information.

.. code-block:: csharp

   Cake.Common.Diagnostics.LoggingExtensions.Information(String format, params Object[] args)

Writes an informational message to the log using the specified format information.

.. code-block:: csharp

   Cake.Common.Diagnostics.LoggingExtensions.Warning(String format, params Object[] args)

Writes a warning message to the log using the specified format information.

.. code-block:: csharp

   Cake.Common.Diagnostics.LoggingExtensions.Verbose(String format, params Object[] args)

Writes a verbose message to the log using the specified format information.

Directory Operations
--------------------

Clean
^^^^^

.. code-block:: csharp

   Cake.Common.IO.DirectoryExtensions.CleanDirectories(String pattern)

Cleans the directories matching the specified pattern.
Cleaning the directory will remove all it's content but not the directory iteself.

.. code-block:: csharp

   Cake.Common.IO.DirectoryExtensions.CleanDirectories(IEnumerable<DirectoryPath> directories)

Cleans the specified directories.
Cleaning a directory will remove all it's content but not the directory iteself.

.. code-block:: csharp

   Cake.Common.IO.DirectoryExtensions.CleanDirectory(DirectoryPath path)

Cleans the specified directory.

Create
^^^^^^

.. code-block:: csharp

   Cake.Common.IO.DirectoryExtensions.CreateDirectory(DirectoryPath path)

Creates the specified directory.

Delete
^^^^^^

.. code-block:: csharp

   Cake.Common.IO.DirectoryExtensions.DeleteDirectories(IEnumerable<DirectoryPath> directories, Boolean recursive)

Deletes the specified directories.

.. code-block:: csharp

   Cake.Common.IO.DirectoryExtensions.DeleteDirectory(DirectoryPath path, Boolean recursive)

Deletes the specified directory.

File Operations
---------------

Copy
^^^^

.. code-block:: csharp

   Cake.Common.IO.FileExtensions.CopyFile(FilePath filePath, FilePath targetFilePath)

Copies the specified file.

.. code-block:: csharp

   Cake.Common.IO.FileExtensions.CopyFiles(String pattern, DirectoryPath targetDirectoryPath)

Copies the files matching the specified pattern.

.. code-block:: csharp

   Cake.Common.IO.FileExtensions.CopyFiles(IEnumerable<FilePath> filePaths, DirectoryPath targetDirectoryPath)

Copies the specified files.

.. code-block:: csharp

   Cake.Common.IO.FileExtensions.CopyFileToDirectory(FilePath filePath, DirectoryPath targetDirectoryPath)

Copies the specified file.

Delete
^^^^^^

.. code-block:: csharp

   Cake.Common.IO.FileExtensions.DeleteFile(FilePath filePath)

Deletes the specified file.

.. code-block:: csharp

   Cake.Common.IO.FileExtensions.DeleteFiles(String pattern)

Deletes the specified files.

.. code-block:: csharp

   Cake.Common.IO.FileExtensions.DeleteFiles(IEnumerable<FilePath> filePaths)

Deletes the specified files.

Move
^^^^

.. code-block:: csharp

   Cake.Common.IO.FileExtensions.MoveFile(FilePath filePath, FilePath targetFilePath)

Moves the specified file to the specified directory.

.. code-block:: csharp

   Cake.Common.IO.FileExtensions.MoveFiles(String pattern, DirectoryPath targetDirectoryPath)

Moves the files matching the specified pattern to the specified directory.

.. code-block:: csharp

   Cake.Common.IO.FileExtensions.MoveFiles(IEnumerable<FilePath> filePaths, DirectoryPath targetDirectoryPath)

Moves the specified files to the specified directory.

.. code-block:: csharp

   Cake.Common.IO.FileExtensions.MoveFileToDirectory(FilePath filePath, DirectoryPath targetDirectoryPath)

Moves the specified file to the specified directory.

Globbing
--------

Directories
^^^^^^^^^^^

.. code-block:: csharp

   Cake.Common.IO.GlobbingExtensions.GetDirectories(String pattern)

Gets all directory matching the specified pattern.

Globbing
^^^^^^^^

.. code-block:: csharp

   Cake.Common.IO.GlobbingExtensions.GetFiles(String pattern)

Gets all files matching the specified pattern.

Compression
-----------

.. code-block:: csharp

   Cake.Common.IO.ZipExtensions.Zip(DirectoryPath rootPath, FilePath outputPath)

Zips the specified directory.

.. code-block:: csharp

   Cake.Common.IO.ZipExtensions.Zip(DirectoryPath rootPath, FilePath outputPath, String pattern)

Zips the files matching the specified pattern.

.. code-block:: csharp

   Cake.Common.IO.ZipExtensions.Zip(DirectoryPath rootPath, FilePath outputPath, IEnumerable<FilePath> filePaths)

Zips the specified files.

ILMerge
-------

.. code-block:: csharp

   Cake.Common.Tools.ILMerge.ILMergeExtensions.ILMerge(FilePath outputFile, FilePath primaryAssembly, IEnumerable<FilePath> assemblyPaths)

Merges the specified assemblies.

.. code-block:: csharp

   Cake.Common.Tools.ILMerge.ILMergeExtensions.ILMerge(FilePath outputFile, FilePath primaryAssembly, IEnumerable<FilePath> assemblyPaths, ILMergeSettings settings)

Merges the specified assemblies.

MSBuild
-------

.. code-block:: csharp

   Cake.Common.Tools.MSBuild.MSBuildExtensions.MSBuild(FilePath solution)

Builds the specified solution using MSBuild.

.. code-block:: csharp

   Cake.Common.Tools.MSBuild.MSBuildExtensions.MSBuild(FilePath solution, Action<MSBuildSettings> configurator)

Builds the specified solution using MSBuild.

MSTest
------

.. code-block:: csharp

   Cake.Common.Tools.MSTest.MSTestExtensions.MSTest(String pattern)

Runs all MSTest unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   Cake.Common.Tools.MSTest.MSTestExtensions.MSTest(String pattern, MSTestSettings settings)

Runs all MSTest unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   Cake.Common.Tools.MSTest.MSTestExtensions.MSTest(IEnumerable<FilePath> assemblyPaths)

Runs all MSTest unit tests in the specified assemblies.

.. code-block:: csharp

   Cake.Common.Tools.MSTest.MSTestExtensions.MSTest(IEnumerable<FilePath> assemblyPaths, MSTestSettings settings)

Runs all MSTest unit tests in the specified assemblies.

NuGet
-----

Pack
^^^^

.. code-block:: csharp

   Cake.Common.Tools.NuGet.NuGetExtensions.NuGetPack(FilePath nuspecFilePath, NuGetPackSettings settings)

Creates a NuGet package using the specified Nuspec file.

Push
^^^^

.. code-block:: csharp

   Cake.Common.Tools.NuGet.NuGetExtensions.NuGetPush(FilePath packageFilePath, NuGetPushSettings settings)

Pushes a NuGet package to a NuGet server and publishes it.

Restore
^^^^^^^

.. code-block:: csharp

   Cake.Common.Tools.NuGet.NuGetExtensions.NuGetRestore(FilePath targetFilePath)

Restores NuGet packages for the specified target.

.. code-block:: csharp

   Cake.Common.Tools.NuGet.NuGetExtensions.NuGetRestore(FilePath targetFilePath, NuGetRestoreSettings settings)

Restores NuGet packages using the specified settings.

NUnit
-----

.. code-block:: csharp

   Cake.Common.Tools.NUnit.NUnitExtensions.NUnit(String pattern)

Runs all NUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   Cake.Common.Tools.NUnit.NUnitExtensions.NUnit(String pattern, NUnitSettings settings)

Runs all NUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   Cake.Common.Tools.NUnit.NUnitExtensions.NUnit(IEnumerable<FilePath> assemblies)

Runs all NUnit unit tests in the specified assemblies.

.. code-block:: csharp

   Cake.Common.Tools.NUnit.NUnitExtensions.NUnit(IEnumerable<FilePath> assemblies, NUnitSettings settings)

Runs all NUnit unit tests in the specified assemblies.

WiX
---

Candle
^^^^^^

.. code-block:: csharp

   Cake.Common.Tools.WiX.WiXExtensions.WiXCandle(String pattern, CandleSettings settings)

Compiles all .wxs sources matching the **pattern**.

.. code-block:: csharp

   Cake.Common.Tools.WiX.WiXExtensions.WiXCandle(IEnumerable<FilePath> sourceFiles, CandleSettings settings)

Compiles all .wxs sources in **sourceFiles**.

Light
^^^^^

.. code-block:: csharp

   Cake.Common.Tools.WiX.WiXExtensions.WiXLight(String pattern, LightSettings settings)

Links all .wixobj files matching the **pattern**.

.. code-block:: csharp

   Cake.Common.Tools.WiX.WiXExtensions.WiXLight(IEnumerable<FilePath> objectFiles, LightSettings settings)

Links all .wixobj files in **objectFiles**.

xUnit
-----

.. code-block:: csharp

   Cake.Common.Tools.XUnit.XUnitExtensions.XUnit(String pattern)

Runs all xUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   Cake.Common.Tools.XUnit.XUnitExtensions.XUnit(String pattern, XUnitSettings settings)

Runs all xUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   Cake.Common.Tools.XUnit.XUnitExtensions.XUnit(IEnumerable<FilePath> assemblies)

Runs all xUnit unit tests in the specified assemblies.

.. code-block:: csharp

   Cake.Common.Tools.XUnit.XUnitExtensions.XUnit(IEnumerable<FilePath> assemblies, XUnitSettings settings)

Runs all xUnit unit tests in the specified assemblies.
t;FilePath&gt; assemblies, XUnitSettings settings)

Runs all xUnit unit tests in the specified assemblies.
