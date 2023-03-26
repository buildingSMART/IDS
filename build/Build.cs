using Nuke.Common;
using Nuke.Common.Tooling;
using System;
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
    private readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [PackageExecutable("ids-tool.CommandLine", "tools/net6.0/ids-tool.dll")] 
    private Tool IdsTool;

    private string IdsToolPath => System.IO.Path.GetDirectoryName(ToolPathResolver.GetPackageExecutable("ids-tool.CommandLine", "tools/net6.0/ids-tool.dll"));

    /// <summary>
    /// Checks the validity of development folder in the repository, using ids-tool.
    /// The tool is deployed by the annotated <see cref="IdsTool"/>.
    /// </summary>
    Target AuditDevelopment => _ => _
        .AssuredAfterFailure()
        .Executes(() =>
        {
            // development samples
            var schemaFile = RootDirectory / "Development" / "ids.xsd";
            var inputFolder = RootDirectory / "Development";
            var arguments = $"audit \"{inputFolder}\" -x \"{schemaFile}\"";
            IdsTool(arguments, workingDirectory: IdsToolPath);
        });

    Target AuditDocTestCases => _ => _
        .AssuredAfterFailure()
        .Executes(() =>
        {
            // we are omitting tests on the content of the Documentation/testcases folder, 
            // because they include IDSs that intentionally contain errors
            //
            var schemaFile = RootDirectory / "Development" / "ids.xsd";
            var inputFolder = RootDirectory / "Documentation" / "testcases";
            var arguments = $"audit \"{inputFolder}\" --omitContent -x \"{schemaFile}\"";
            IdsTool(arguments, workingDirectory: IdsToolPath);
        });

    /// <summary>
    /// Perform all tests via DependsOn, this is the one invoked by default
    /// </summary>
    Target CheckTestCases => _ => _
        .AssuredAfterFailure()
        .DependsOn(AuditDocTestCases)
        .DependsOn(AuditDevelopment)
        .Executes(() =>
        {
            Console.WriteLine("Empty target, to launch all available checking targets.");
        });
}
