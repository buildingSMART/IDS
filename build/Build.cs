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

    [PackageExecutable("ids-tool.CommandLine", "tools/net5.0/ids-tool.dll")] Tool BcfTool;
    private string BcfToolPath => System.IO.Path.GetDirectoryName(ToolPathResolver.GetPackageExecutable("ids-tool.CommandLine", "tools/net5.0/ids-tool.dll"));

    Target CheckTestCases => _ => _
        .Executes(() =>
        {
            var schemaFile = Path.Combine(
                RootDirectory,
                "Development/0.5/ids_05.xsd"
                );
            var inputFolder = Path.Combine(
                RootDirectory,
                "Development/0.5"
                );
            var arguments = $"check \"{inputFolder}\" -x \"{schemaFile}\"";
            BcfTool(arguments, workingDirectory: BcfToolPath);
        });
}
