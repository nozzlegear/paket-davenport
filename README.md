This is a reproduction of an error I'm getting when using the Davenport 3.0.x package with Paket. Paket install/restore works fine, but when building the project it throws an error. Using the same package without Paket will install, restore, build and run without errors.

The error thrown by Paket is the following:

```
daventhree [master +9 ~1 -0 ~] -> dotnet build
Microsoft (R) Build Engine version 15.5.180.51428 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Restore completed in 21.09 ms for C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj.
  Restore completed in 36.75 ms for C:\Users\nozzl\source\playgrounds\daventhree\dotnet-project\dotnet-project.fsproj.
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018: The "ResolveAssemblyReference" task failed unexpectedly. [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018: System.IO.FileLoadException: The given assembly name or codebase was invalid. (Exception from HRESULT: 0x80131047) [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018:    at System.Reflection.AssemblyName.nInit(RuntimeAssembly& assembly, Boolean forIntrospection, Boolean raiseResolveEvent) [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018:    at System.Reflection.AssemblyName..ctor(String assemblyName) [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018:    at Microsoft.Build.Tasks.NativeMethods.CompareAssemblyIdentity(String assemblyIdentity1, Boolean fUnified1, String assemblyIdentity2, Boolean fUnified2, Boolean& pfEquivalent, AssemblyComparisonResult& pResult) in E:\A\_work\17\s\src\Tasks\NativeMethods.cs:line 1135 [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018:    at Microsoft.Build.Tasks.ReferenceTable.ResolveAssemblyNameConflict(AssemblyNameReference assemblyReference0, AssemblyNameReference assemblyReference1) in E:\A\_work\17\s\src\Tasks\AssemblyDependency\ReferenceTable.cs:line 2248 [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018:    at Microsoft.Build.Tasks.ReferenceTable.ResolveConflictsBetweenReferences() in E:\A\_work\17\s\src\Tasks\AssemblyDependency\ReferenceTable.cs:line 1817 [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018:    at Microsoft.Build.Tasks.ReferenceTable.ResolveConflicts(DependentAssembly[]& idealRemappings, AssemblyNameReference[]& conflictingReferences) in E:\A\_work\17\s\src\Tasks\AssemblyDependency\ReferenceTable.cs:line 1845 [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018:    at Microsoft.Build.Tasks.ResolveAssemblyReference.Execute(FileExists fileExists, DirectoryExists directoryExists, GetDirectories getDirectories, GetAssemblyName getAssemblyName, GetAssemblyMetadata getAssemblyMetadata, GetLastWriteTime getLastWriteTime, GetAssemblyRuntimeVersion getRuntimeVersion, GetAssemblyPathInGac getAssemblyPathInGac, IsWinMDFile isWinMDFile, ReadMachineTypeFromPEHeader readMachineTypeFromPEHeader) in E:\A\_work\17\s\src\Tasks\AssemblyDependency\ResolveAssemblyReference.cs:line 2192 [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018:    at Microsoft.Build.Tasks.ResolveAssemblyReference.Execute() in E:\A\_work\17\s\src\Tasks\AssemblyDependency\ResolveAssemblyReference.cs:line 2939 [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018:    at Microsoft.Build.BackEnd.TaskExecutionHost.Microsoft.Build.BackEnd.ITaskExecutionHost.Execute() in E:\A\_work\17\s\src\Build\BackEnd\TaskExecutionHost\TaskExecutionHost.cs:line 631 [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
C:\Program Files\dotnet\sdk\2.1.4\Microsoft.Common.CurrentVersion.targets(2041,5): error MSB4018:    at Microsoft.Build.BackEnd.TaskBuilder.<ExecuteInstantiatedTask>d__25.MoveNext() in E:\A\_work\17\s\src\Build\BackEnd\Components\RequestBuilder\TaskBuilder.cs:line 787 [C:\Users\nozzl\source\playgrounds\daventhree\paket-project\paket-project.fsproj]
  dotnet-project -> C:\Users\nozzl\source\playgrounds\daventhree\dotnet-project\bin\Debug\netcoreapp2.0\dotnet-project.dll

Build FAILED.
```
