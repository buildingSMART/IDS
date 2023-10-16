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

    public static int Main() => Execute<Build>(x => x.AuditAllIdsFiles);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    private readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [PackageExecutable("ids-tool.CommandLine", "tools/net6.0/ids-tool.dll")] 
    private Tool IdsTool;

	[PackageExecutable("dotnet-xscgen", "tools/net6.0/any/xscgen.dll")]
	private Tool SchemaTool;

	/// <summary>
	/// Audits the validity of development folder in the repository, using ids-tool.
	/// The tool is deployed by the annotated <see cref="IdsTool"/>.
	/// The schema is loaded from the repository to ensure internal coherence.
	/// </summary>
	Target MakeClasses => _ => _
		.AssuredAfterFailure()
		.Executes(() =>
		{
			// development samples
			var schemaFile = RootDirectory / "Development" / "ids.xsd";
			var arguments = $"\"{schemaFile}\"";
			SchemaTool(arguments);
		});


	private string IdsToolPath => Path.GetDirectoryName(ToolPathResolver.GetPackageExecutable("ids-tool.CommandLine", "tools/net6.0/ids-tool.dll"));

	/// <summary>
	/// Audits the validity of development folder in the repository, using ids-tool.
	/// The tool is deployed by the annotated <see cref="IdsTool"/>.
	/// The schema is loaded from the repository to ensure internal coherence.
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

	/// <summary>
	/// Audits the validity of Documentation/testcases folder in the repository, using ids-tool.
    /// The tool is deployed by the annotated <see cref="IdsTool"/>.
    /// The schema is loaded from the repository to ensure internal coherence.
	/// </summary>
	Target AuditDocTestCases => _ => _
        .AssuredAfterFailure()
        .Executes(() =>
        {
            // we are omitting tests on the content of the Documentation/testcases folder, 
            // because they include IDSs that intentionally contain errors
            //
            // todo: once stable, this could be improved to omit contens based on failure patter name
            // todo: once stable, constrained on expected auditing failures on the "fail-" cases should be added
            var schemaFile = RootDirectory / "Development" / "ids.xsd";
            var inputFolder = RootDirectory / "Documentation" / "testcases";
            var arguments = $"audit \"{inputFolder}\" -p \"\\\\fail-\" -x \"{schemaFile}\"";
            IdsTool(arguments, workingDirectory: IdsToolPath);
        });

    /// <summary>
    /// Perform all quality assurance of published IDS files; this is the one invoked by default
    /// </summary>
    Target AuditAllIdsFiles => _ => _
        .AssuredAfterFailure()
        .DependsOn(AuditDocTestCases)
        .DependsOn(AuditDevelopment)
        .Executes(() =>
        {
            Console.WriteLine("This is an utility target that launches all available IDS auditing targets.");
        });


}
