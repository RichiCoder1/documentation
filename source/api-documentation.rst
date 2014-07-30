API documentation
=================

Arguments
---------

Gets an argument.

.. code-block:: csharp

   Argument(string name)

Gets an argument.

.. code-block:: csharp

   Argument(string name, T defaultValue)

Determines whether or not the specified argument exist.

.. code-block:: csharp

   HasArgument(string name)

Assembly Info
-------------

Creates an assembly information file.

.. code-block:: csharp

   CreateAssemblyInfo(FilePath outputPath, AssemblyInfoSettings settings)

Compression
-----------

Zips the specified directory.

.. code-block:: csharp

   Zip(DirectoryPath rootPath, FilePath outputPath)

Zips the files matching the specified pattern.

.. code-block:: csharp

   Zip(DirectoryPath rootPath, FilePath outputPath, string pattern)

Zips the specified files.

.. code-block:: csharp

   Zip(DirectoryPath rootPath, FilePath outputPath, IEnumerable<FilePath> filePaths)

Directory Operations
--------------------

Clean
^^^^^

Cleans the directories matching the specified pattern.
Cleaning the directory will remove all it's content but not the directory iteself.

.. code-block:: csharp

   CleanDirectories(string pattern)

Cleans the specified directories.
Cleaning a directory will remove all it's content but not the directory iteself.

.. code-block:: csharp

   CleanDirectories(IEnumerable<DirectoryPath> directories)

Cleans the specified directory.

.. code-block:: csharp

   CleanDirectory(DirectoryPath path)

Create
^^^^^^

Creates the specified directory.

.. code-block:: csharp

   CreateDirectory(DirectoryPath path)

Delete
^^^^^^

Deletes the specified directories.

.. code-block:: csharp

   DeleteDirectories(IEnumerable<DirectoryPath> directories, bool recursive)

Deletes the specified directory.

.. code-block:: csharp

   DeleteDirectory(DirectoryPath path, bool recursive)

File Operations
---------------

Copy
^^^^

Copies the specified file.

.. code-block:: csharp

   CopyFile(FilePath filePath, FilePath targetFilePath)

Copies the files matching the specified pattern.

.. code-block:: csharp

   CopyFiles(string pattern, DirectoryPath targetDirectoryPath)

Copies the specified files.

.. code-block:: csharp

   CopyFiles(IEnumerable<FilePath> filePaths, DirectoryPath targetDirectoryPath)

Copies the specified file.

.. code-block:: csharp

   CopyFileToDirectory(FilePath filePath, DirectoryPath targetDirectoryPath)

Delete
^^^^^^

Deletes the specified file.

.. code-block:: csharp

   DeleteFile(FilePath filePath)

Deletes the specified files.

.. code-block:: csharp

   DeleteFiles(string pattern)

Deletes the specified files.

.. code-block:: csharp

   DeleteFiles(IEnumerable<FilePath> filePaths)

Move
^^^^

Moves the specified file to the specified directory.

.. code-block:: csharp

   MoveFile(FilePath filePath, FilePath targetFilePath)

Moves the files matching the specified pattern to the specified directory.

.. code-block:: csharp

   MoveFiles(string pattern, DirectoryPath targetDirectoryPath)

Moves the specified files to the specified directory.

.. code-block:: csharp

   MoveFiles(IEnumerable<FilePath> filePaths, DirectoryPath targetDirectoryPath)

Moves the specified file to the specified directory.

.. code-block:: csharp

   MoveFileToDirectory(FilePath filePath, DirectoryPath targetDirectoryPath)

Globbing
--------

Directories
^^^^^^^^^^^

Gets all directory matching the specified pattern.

.. code-block:: csharp

   GetDirectories(string pattern)

Globbing
^^^^^^^^

Gets all files matching the specified pattern.

.. code-block:: csharp

   GetFiles(string pattern)

ILMerge
-------

Merges the specified assemblies.

.. code-block:: csharp

   ILMerge(FilePath outputFile, FilePath primaryAssembly, IEnumerable<FilePath> assemblyPaths)

Merges the specified assemblies.

.. code-block:: csharp

   ILMerge(FilePath outputFile, FilePath primaryAssembly, IEnumerable<FilePath> assemblyPaths, ILMergeSettings settings)

Logging
-------

Writes a debug message to the log using the specified format information.

.. code-block:: csharp

   Debug(string format, params Object[] args)

Writes an error message to the log using the specified format information.

.. code-block:: csharp

   Error(string format, params Object[] args)

Writes an informational message to the log using the specified format information.

.. code-block:: csharp

   Information(string format, params Object[] args)

Writes a warning message to the log using the specified format information.

.. code-block:: csharp

   Warning(string format, params Object[] args)

Writes a verbose message to the log using the specified format information.

.. code-block:: csharp

   Verbose(string format, params Object[] args)

MSBuild
-------

Builds the specified solution using MSBuild.

.. code-block:: csharp

   MSBuild(FilePath solution)

Builds the specified solution using MSBuild.

.. code-block:: csharp

   MSBuild(FilePath solution, Action<MSBuildSettings> configurator)

MSTest
------

Runs all MSTest unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   MSTest(string pattern)

Runs all MSTest unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   MSTest(string pattern, MSTestSettings settings)

Runs all MSTest unit tests in the specified assemblies.

.. code-block:: csharp

   MSTest(IEnumerable<FilePath> assemblyPaths)

Runs all MSTest unit tests in the specified assemblies.

.. code-block:: csharp

   MSTest(IEnumerable<FilePath> assemblyPaths, MSTestSettings settings)

NuGet
-----

Pack
^^^^

Creates a NuGet package using the specified Nuspec file.

.. code-block:: csharp

   NuGetPack(FilePath nuspecFilePath, NuGetPackSettings settings)

Push
^^^^

Pushes a NuGet package to a NuGet server and publishes it.

.. code-block:: csharp

   NuGetPush(FilePath packageFilePath, NuGetPushSettings settings)

Restore
^^^^^^^

Restores NuGet packages for the specified target.

.. code-block:: csharp

   NuGetRestore(FilePath targetFilePath)

Restores NuGet packages using the specified settings.

.. code-block:: csharp

   NuGetRestore(FilePath targetFilePath, NuGetRestoreSettings settings)

NUnit
-----

Runs all NUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   NUnit(string pattern)

Runs all NUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   NUnit(string pattern, NUnitSettings settings)

Runs all NUnit unit tests in the specified assemblies.

.. code-block:: csharp

   NUnit(IEnumerable<FilePath> assemblies)

Runs all NUnit unit tests in the specified assemblies.

.. code-block:: csharp

   NUnit(IEnumerable<FilePath> assemblies, NUnitSettings settings)

Release Notes
-------------

Parses all release notes.

.. code-block:: csharp

   ParseAllReleaseNotes(FilePath filePath)

Parses the latest release notes.

.. code-block:: csharp

   ParseReleaseNotes(FilePath filePath)

WiX
---

Candle
^^^^^^

Compiles all .wxs sources matching the ``pattern``.

.. code-block:: csharp

   WiXCandle(string pattern, CandleSettings settings)

Compiles all .wxs sources in ``sourceFiles``.

.. code-block:: csharp

   WiXCandle(IEnumerable<FilePath> sourceFiles, CandleSettings settings)

Light
^^^^^

Links all .wixobj files matching the ``pattern``.

.. code-block:: csharp

   WiXLight(string pattern, LightSettings settings)

Links all .wixobj files in ``objectFiles``.

.. code-block:: csharp

   WiXLight(IEnumerable<FilePath> objectFiles, LightSettings settings)

xUnit
-----

Runs all xUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   XUnit(string pattern)

Runs all xUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   XUnit(string pattern, XUnitSettings settings)

Runs all xUnit unit tests in the specified assemblies.

.. code-block:: csharp

   XUnit(IEnumerable<FilePath> assemblies)

Runs all xUnit unit tests in the specified assemblies.

.. code-block:: csharp

   XUnit(IEnumerable<FilePath> assemblies, XUnitSettings settings)
