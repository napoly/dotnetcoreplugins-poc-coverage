ASP.NET Core MVC DotNetCorePlugins Sample with Playwright integration test and Coverlet
=======================

This sample contains two projects which demonstrate a simple plugin coverage scenario.

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
App runs on <http://localhost:5000>

To test coverage, open a new terminal and run:

```
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
```

The test result should be shown as:

Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: 1 s - IntegrationTest.dll (net8.0)
[coverlet]
Calculating coverage result...
Generating report 'dotnetcoreplugins-poc-coverage/IntegrationTest/coverage.cobertura.xml'
```
+--------------+------+--------+--------+
| Module       | Line | Branch | Method |
+--------------+------+--------+--------+
| MvcAppPlugin | 0%   | 100%   | 0%     |
+--------------+------+--------+--------+
| MvcApp       | 0%   | 0%     | 0%     |
+--------------+------+--------+--------+

+---------+------+--------+--------+
|         | Line | Branch | Method |
+---------+------+--------+--------+
| Total   | 0%   | 0%     | 0%     |
+---------+------+--------+--------+
| Average | 0%   | 50%    | 0%     |
+---------+------+--------+--------+
```

### License

This project is licensed under the MIT License.

Code derived from [DotNetCorePlugins](https://github.com/natemcmaster/DotNetCorePlugins) is used in this project under the terms of the [Apache License, Version 2.0](https://www.apache.org/licenses/LICENSE-2.0).