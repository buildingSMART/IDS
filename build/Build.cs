using Nuke.Common;
using Nuke.Common.Tooling;

class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main() => Execute<Build>(x => x.CheckTestCases);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    private readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [PackageExecutable("ids-tool.CommandLine", "tools/net6.0/ids-tool.dll")] 
    private Tool IdsTool;

    private string IdsToolPath => System.IO.Path.GetDirectoryName(ToolPathResolver.GetPackageExecutable("ids-tool.CommandLine", "tools/net6.0/ids-tool.dll"));

    /// <summary>
    /// Checks the validity of IDS files in the repository, using ids-tool.
    /// The tool is deployed by the annotated <see cref="IdsTool"/>.
    /// </summary>
    Target CheckTestCases => _ => _
        .Executes(() =>
        {
            // development samples
            var schemaFile = RootDirectory / "Development" / "ids.xsd";
            var inputFolder = RootDirectory / "Development";
            var arguments = $"check \"{inputFolder}\" -x \"{schemaFile}\"";
            IdsTool(arguments, workingDirectory: IdsToolPath);

            // test cases
            inputFolder = RootDirectory / "Documentation" / "testcases";
            arguments = $"check \"{inputFolder}\" -x \"{schemaFile}\"";
            IdsTool(arguments, workingDirectory: IdsToolPath);
        });
}
