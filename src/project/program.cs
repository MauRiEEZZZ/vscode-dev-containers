using System.Reflection;
// See https://aka.ms/new-console-template for more information
var version = Assembly.GetEntryAssembly()!.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "empty";
Console.WriteLine($"Hello, World! Version: {version}");
