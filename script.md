## 

# Installation


# Console hello world
`dotnet new`

# ASP.Net hello world api
`yo aspnet`

# Library hello world
`dotnet new`
Remove `buildOptions` from `project.json`

Dependencies
Change `dependencies` to `"NETStandard.Library":"1.5.0-rc2-24027"`

Fasten - use the same family of packages, all works together.
Metapackage - Package which represents a set of NuGet packages
Trimming - remove unused packages, in project.lock.json find NETStandard.Library and copy dependencies

Framework
.NET Standard Library is a curated set of APIs, Defines APIs that can be used for binary code sharing.


# dotnet core solution
create `global.json` and add `{"projects": ["console", "web", "lib", "test"]}`

# Test hello world
`dotnet new`
Remove `buildOptions` from `project.json`
Add `"testRunner": "xunit"`


# Console hello world F#
`dotnet new -l F#`

# Extending the CLI tools

dotnet-mycommand == dotnet mycommand


# NuGet 
Create NuGet.config
`dotnet pack --version-suffix dev --output /localfeed`




