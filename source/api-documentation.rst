API documentation
=================

Arguments
---------

Gets an argument.

.. code-block:: csharp

   T Argument<T>(string name)

Gets an argument.

.. code-block:: csharp

   T Argument<T>(string name, T defaultValue)

Determines whether or not the specified argument exist.

.. code-block:: csharp

   bool HasArgument(string name)

Assembly Info
-------------

Creates an assembly information file.

.. code-block:: csharp

   void CreateAssemblyInfo(FilePath outputPath, AssemblyInfoSettings settings)

Compression
-----------

Zips the specified directory.

.. code-block:: csharp

   void Zip(DirectoryPath rootPath, FilePath outputPath)

Zips the files matching the specified pattern.

.. code-block:: csharp

   void Zip(DirectoryPath rootPath, FilePath outputPath, string pattern)

Zips the specified files.

.. code-block:: csharp

   void Zip(DirectoryPath rootPath, FilePath outputPath, IEnumerable<FilePath> filePaths)

Directory Operations
--------------------

Clean
^^^^^

Cleans the directories matching the specified pattern.
Cleaning the directory will remove all it's content but not the directory iteself.

.. code-block:: csharp

   void CleanDirectories(string pattern)

Cleans the specified directories.
Cleaning a directory will remove all it's content but not the directory iteself.

.. code-block:: csharp

   void CleanDirectories(IEnumerable<DirectoryPath> directories)

Cleans the specified directory.

.. code-block:: csharp

   void CleanDirectory(DirectoryPath path)

Create
^^^^^^

Creates the specified directory.

.. code-block:: csharp

   void CreateDirectory(DirectoryPath path)

Delete
^^^^^^

Deletes the specified directories.

.. code-block:: csharp

   void DeleteDirectories(IEnumerable<DirectoryPath> directories, bool recursive)

Deletes the specified directory.

.. code-block:: csharp

   void DeleteDirectory(DirectoryPath path, bool recursive)

File Operations
---------------

Copy
^^^^

Copies the specified file.

.. code-block:: csharp

   void CopyFile(FilePath filePath, FilePath targetFilePath)

Copies the files matching the specified pattern.

.. code-block:: csharp

   void CopyFiles(string pattern, DirectoryPath targetDirectoryPath)

Copies the specified files.

.. code-block:: csharp

   void CopyFiles(IEnumerable<FilePath> filePaths, DirectoryPath targetDirectoryPath)

Copies the specified file.

.. code-block:: csharp

   void CopyFileToDirectory(FilePath filePath, DirectoryPath targetDirectoryPath)

Delete
^^^^^^

Deletes the specified file.

.. code-block:: csharp

   void DeleteFile(FilePath filePath)

Deletes the specified files.

.. code-block:: csharp

   void DeleteFiles(string pattern)

Deletes the specified files.

.. code-block:: csharp

   void DeleteFiles(IEnumerable<FilePath> filePaths)

Move
^^^^

Moves the specified file to the specified directory.

.. code-block:: csharp

   void MoveFile(FilePath filePath, FilePath targetFilePath)

Moves the files matching the specified pattern to the specified directory.

.. code-block:: csharp

   void MoveFiles(string pattern, DirectoryPath targetDirectoryPath)

Moves the specified files to the specified directory.

.. code-block:: csharp

   void MoveFiles(IEnumerable<FilePath> filePaths, DirectoryPath targetDirectoryPath)

Moves the specified file to the specified directory.

.. code-block:: csharp

   void MoveFileToDirectory(FilePath filePath, DirectoryPath targetDirectoryPath)

Globbing
--------

Directories
^^^^^^^^^^^

Gets all directory matching the specified pattern.

.. code-block:: csharp

   DirectoryPathCollection GetDirectories(string pattern)

Globbing
^^^^^^^^

Gets all files matching the specified pattern.

.. code-block:: csharp

   FilePathCollection GetFiles(string pattern)

ILMerge
-------

Merges the specified assemblies.

.. code-block:: csharp

   void ILMerge(FilePath outputFile, FilePath primaryAssembly, IEnumerable<FilePath> assemblyPaths)

Merges the specified assemblies.

.. code-block:: csharp

   void ILMerge(FilePath outputFile, FilePath primaryAssembly, IEnumerable<FilePath> assemblyPaths, ILMergeSettings settings)

Logging
-------

Writes a debug message to the log using the specified format information.

.. code-block:: csharp

   void Debug(string format, params Object[] args)

Writes an error message to the log using the specified format information.

.. code-block:: csharp

   void Error(string format, params Object[] args)

Writes an informational message to the log using the specified format information.

.. code-block:: csharp

   void Information(string format, params Object[] args)

Writes a warning message to the log using the specified format information.

.. code-block:: csharp

   void Warning(string format, params Object[] args)

Writes a verbose message to the log using the specified format information.

.. code-block:: csharp

   void Verbose(string format, params Object[] args)

MSBuild
-------

Builds the specified solution using MSBuild.

.. code-block:: csharp

   void MSBuild(FilePath solution)

Builds the specified solution using MSBuild.

.. code-block:: csharp

   void MSBuild(FilePath solution, Action<MSBuildSettings> configurator)

MSTest
------

Runs all MSTest unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   void MSTest(string pattern)

Runs all MSTest unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   void MSTest(string pattern, MSTestSettings settings)

Runs all MSTest unit tests in the specified assemblies.

.. code-block:: csharp

   void MSTest(IEnumerable<FilePath> assemblyPaths)

Runs all MSTest unit tests in the specified assemblies.

.. code-block:: csharp

   void MSTest(IEnumerable<FilePath> assemblyPaths, MSTestSettings settings)

NuGet
-----

Pack
^^^^

Creates a NuGet package using the specified Nuspec file.

.. code-block:: csharp

   void NuGetPack(FilePath nuspecFilePath, NuGetPackSettings settings)

Push
^^^^

Pushes a NuGet package to a NuGet server and publishes it.

.. code-block:: csharp

   void NuGetPush(FilePath packageFilePath, NuGetPushSettings settings)

Restore
^^^^^^^

Restores NuGet packages for the specified target.

.. code-block:: csharp

   void NuGetRestore(FilePath targetFilePath)

Restores NuGet packages using the specified settings.

.. code-block:: csharp

   void NuGetRestore(FilePath targetFilePath, NuGetRestoreSettings settings)

NUnit
-----

Runs all NUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   void NUnit(string pattern)

Runs all NUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   void NUnit(string pattern, NUnitSettings settings)

Runs all NUnit unit tests in the specified assemblies.

.. code-block:: csharp

   void NUnit(IEnumerable<FilePath> assemblies)

Runs all NUnit unit tests in the specified assemblies.

.. code-block:: csharp

   void NUnit(IEnumerable<FilePath> assemblies, NUnitSettings settings)

Release Notes
-------------

Parses all release notes.

.. code-block:: csharp

   IReadOnlyList<ReleaseNotes> ParseAllReleaseNotes(FilePath filePath)

Parses the latest release notes.

.. code-block:: csharp

   ReleaseNotes ParseReleaseNotes(FilePath filePath)

WiX
---

Candle
^^^^^^

Compiles all .wxs sources matching the ``pattern``.

.. code-block:: csharp

   void WiXCandle(string pattern, CandleSettings settings)

Compiles all .wxs sources in ``sourceFiles``.

.. code-block:: csharp

   void WiXCandle(IEnumerable<FilePath> sourceFiles, CandleSettings settings)

Light
^^^^^

Links all .wixobj files matching the ``pattern``.

.. code-block:: csharp

   void WiXLight(string pattern, LightSettings settings)

Links all .wixobj files in ``objectFiles``.

.. code-block:: csharp

   void WiXLight(IEnumerable<FilePath> objectFiles, LightSettings settings)

xUnit
-----

Runs all xUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   void XUnit(string pattern)

Runs all xUnit unit tests in the assemblies matching the specified pattern.

.. code-block:: csharp

   void XUnit(string pattern, XUnitSettings settings)

Runs all xUnit unit tests in the specified assemblies.

.. code-block:: csharp

   void XUnit(IEnumerable<FilePath> assemblies)

Runs all xUnit unit tests in the specified assemblies.

.. code-block:: csharp

   void XUnit(IEnumerable<FilePath> assemblies, XUnitSettings settings)
