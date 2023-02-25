using Nuke.Common;
using Nuke.Common.Tooling;
using System.IO;

class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main() => Execute<Build>(x => x.CheckTestCases);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [PackageExecutable("ids-tool.CommandLine", "tools/net6.0/ids-tool.dll")] Tool IdsTool;
    private string IdsToolPath => System.IO.Path.GetDirectoryName(ToolPathResolver.GetPackageExecutable("ids-tool.CommandLine", "tools/net6.0/ids-tool.dll"));

    Target CheckTestCases => _ => _
        .Executes(() =>
        {
            // development samples
            var schemaFile = Path.Combine(
                RootDirectory,
                "Development/ids.xsd"
                );
            var inputFolder = Path.Combine(
                RootDirectory,
                "Development"
                );
            var arguments = $"check \"{inputFolder}\" -x \"{schemaFile}\"";
            IdsTool(arguments, workingDirectory: IdsToolPath);

            // test cases
            inputFolder = Path.Combine(
                RootDirectory,
                "Documentation/testcases"
                );
            arguments = $"check \"{inputFolder}\" -x \"{schemaFile}\"";
            IdsTool(arguments, workingDirectory: IdsToolPath);

        });
}
