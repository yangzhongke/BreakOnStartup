using System;
using System.Diagnostics;
using System.Reflection;

public static class StartupHook
{
    public static void Initialize()
    {
        string targetAssemblyName = Environment.GetEnvironmentVariable("DOTNET_STARTUP_HOOKS_TARGET_ASSEMBLY_NAME");
        string entryAssemblyName = Assembly.GetEntryAssembly()?.GetName().Name;
        if (targetAssemblyName != null && targetAssemblyName == entryAssemblyName)
        {
            Debugger.Launch();
        }
    }
}