set RELPATH=..\..\BreakOnStartup\bin\Debug\netstandard1.5\BreakOnStartup.dll
set FULLPATH=%~f0
for %%I in ("%RELPATH%") do set ABSOLUTE=%%~fI
set DOTNET_STARTUP_HOOKS=%ABSOLUTE%
set DOTNET_STARTUP_HOOKS_TARGET_ASSEMBLY_NAME=ConsoleAppNet9
dotnet run