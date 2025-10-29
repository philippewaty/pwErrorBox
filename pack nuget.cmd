if not exist NuGet mkdir NuGet

NuGet.exe pack pwErrorBox.nuspec -OutputDirectory NuGet -IncludeReferencedProjects -Properties Configuration=Release;Platform=AnyCPU -Build

rem pause