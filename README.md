ASP.NET Core MVC DotNetCorePlugins Sample with Playwright integration test and Coverlet
=======================

This sample contains two projects which demonstrate a simple plugin scenario.

1. 'MvcWebApp' is an ASP.NET Core application that scans for a 'plugins' folder in its base directory and attempts to load any plugins it finds
2. 'MvcAppPlugin' which implements MVC controllers.

Normally, an ASP.NET Core MVC application must have a direct dependency on any assemblies
that provide controllers. However, as this sample demonstrates, an MVC application
can load controllers from a list of assemblies which is not known ahead of time when the
host app is built.

## Running the sample

Open a command line to this folder and run:

```
dotnet clean
dotnet build
dotnet run --project MvcApp/
```

Then open <http://localhost:5000>

### License

This project is licensed under the MIT License.

Code derived from [DotNetCorePlugins](https://github.com/natemcmaster/DotNetCorePlugins) is used in this project under the terms of the [Apache License, Version 2.0](https://www.apache.org/licenses/LICENSE-2.0).