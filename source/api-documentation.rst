API documentation
=================

The classes `DirectoryPath` and `FilePath` implement implicit conversion from `System.String`. So where these values are used, a string can be used instead. No need to new up instances of these.

Arguments
---------

.. code-block:: csharp

   bool HasArgument(string key)

.. code-block:: csharp

   T Argument<T>(string key)

.. code-block:: csharp

   T Argument<T>(string key, T defaultValue)
 
Globbing
--------

.. code-block:: csharp

   IEnumerable<FilePath> GetFiles(string pattern)

.. code-block:: csharp

   IEnumerable<DirectoryPath> GetDirectories(string pattern) 

File operations
---------------

The classes `DirectoryPath` and `FilePath` implement implicit conversion from `System.String`. So where these values are used, a string can be used instead. No need to new up instances of these.

.. code-block:: csharp

   void CopyFileToDirectory(FilePath sourceFilePath, DirectoryPath targetDirectoryPath)
  
.. code-block:: csharp

   void CopyFile(FilePath sourceFilePath, FilePath targetFilePath)
  
.. code-block:: csharp

   void CopyFiles(string pattern, DirectoryPath targetDirectoryPath)
  
.. code-block:: csharp

   void CopyFiles(IEnumerable<FilePath> filePaths, DirectoryPath targetDirectoryPath)

.. code-block:: csharp

   void MoveFileToDirectory(FilePath filePath, DirectoryPath targetDirectoryPath)

.. code-block:: csharp

   void MoveFiles(string pattern, DirectoryPath targetDirectoryPath)

.. code-block:: csharp

   void MoveFiles(IEnumerable<FilePath> filePaths, DirectoryPath targetDirectoryPath)

.. code-block:: csharp

   void MoveFile(FilePath filePath, FilePath targetFilePath)

.. code-block:: csharp

   void DeleteFiles(string pattern)

.. code-block:: csharp

   void DeleteFiles(IEnumerable<FilePath> filePaths)

.. code-block:: csharp

   void DeleteFile(FilePath filePath)

Directory operations
--------------------

The classes `DirectoryPath` and `FilePath` implement implicit conversion from `System.String`. So where these values are used, a string can be used instead. No need to new up instances of these.

.. code-block:: csharp

   void CreateDirectory(DirectoryPath path)

.. code-block:: csharp

   void CleanDirectory(DirectoryPath path)

.. code-block:: csharp

   void CleanDirectories(string pattern)

.. code-block:: csharp

   void CleanDirectories(IEnumerable<DirectoryPath> directories)

.. code-block:: csharp

   void DeleteDirectory(DirectoryPath path, bool recursive = false)

.. code-block:: csharp

   void DeleteDirectories(IEnumerable<DirectoryPath> directories, bool recursive = false)

Assembly Info
-------------

.. code-block:: csharp

   void CreateAssemblyInfo(FilePath outputPath, AssemblyInfoSettings settings)

Release notes
-------------

.. code-block:: csharp

   IReadOnlyList<ReleaseNotes> ParseAllReleaseNotes(FilePath filePath)

.. code-block:: csharp

   ReleaseNotes ParseReleaseNotes(this ICakeContext context, FilePath filePath)

Logging
-------

.. code-block:: csharp

   void Error(string format, params object[] args)

.. code-block:: csharp

   void Warning(string format, params object[] args)

.. code-block:: csharp

   void Information(string format, params object[] args)

.. code-block:: csharp

   void Verbose(string format, params object[] args)

.. code-block:: csharp

   void Debug(string format, params object[] args)

Zip
---

.. code-block:: csharp

   void Zip(DirectoryPath rootPath, FilePath outputPath)

.. code-block:: csharp

   void Zip(DirectoryPath rootPath, FilePath outputPath, string pattern)

.. code-block:: csharp

   void Zip(DirectoryPath rootPath, FilePath outputPath, IEnumerable<FilePath> filePaths)

MSBuild
-------

.. code-block:: csharp

   void MSBuild(FilePath solution)

.. code-block:: csharp

   void MSBuild(FilePath solution, Action<MSBuildSettings> settings)

xUnit
-----

.. code-block:: csharp

   void XUnit(string pattern)

.. code-block:: csharp

   void XUnit(string pattern, XUnitSettings settings)

.. code-block:: csharp

   void XUnit(IEnumerable<FilePath> assemblies)

.. code-block:: csharp

   void XUnit(IEnumerable<FilePath> assemblies, XUnitSettings settings)

NUnit
-----

.. code-block:: csharp

   void NUnit(string pattern)

.. code-block:: csharp

   void NUnit(string pattern, NUnitSettings settings)

.. code-block:: csharp

   void NUnit(IEnumerable<FilePath> assemblies)

.. code-block:: csharp

   void NUnit(IEnumerable<FilePath> assemblies, NUnitSettings settings)

MSTest
------

.. code-block:: csharp

   void MSTest(string pattern)

.. code-block:: csharp

   void MSTest(string pattern, MSTestSettings settings)

.. code-block:: csharp

   void MSTest(IEnumerable<FilePath> assemblies)

.. code-block:: csharp

   void MSTest(IEnumerable<FilePath> assemblies, MSTestSettings settings)

NuGet
-----

.. code-block:: csharp

   void NuGetPack(FilePath nuspecFilePath, NuGetPackSettings settings)

.. code-block:: csharp

   void NuGetRestore(FilePath solution)

.. code-block:: csharp

   void NuGetRestore(NuGetRestoreSettings settings)

ILMerge
-------

.. code-block:: csharp

   void ILMerge(FilePath outputFile, FilePath primaryAssembly, 
            IEnumerable<FilePath> assemblyPaths)

.. code-block:: csharp

   void ILMerge(FilePath outputFile, FilePath primaryAssembly,  
            IEnumerable<FilePath> assemblyPaths, ILMergeSettings settings)

WiX
---

.. code-block:: csharp

   void WiXCandle(string pattern, CandleSettings settings = null)

.. code-block:: csharp

   void WiXCandle(IEnumerable<FilePath> sourceFiles, CandleSettings settings = null)

.. code-block:: csharp

   void WiXLight(string pattern, LightSettings settings = null)

.. code-block:: csharp

   void WiXLight(IEnumerable<FilePath> objectFiles, LightSettings settings = null)