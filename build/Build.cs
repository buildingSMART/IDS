using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Octokit;
using System;
using System.IO;
using System.Reflection.Metadata;

class Build : NukeBuild
{
    public static int Main() => Execute<Build>(x => x.AuditAllIdsFiles);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    private readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [PackageExecutable("ids-tool.CommandLine", "tools/net6.0/ids-tool.dll")]
    private Tool IdsTool;

    [PackageExecutable("dotnet-xscgen", "tools/net6.0/any/xscgen.dll")]
    private Tool SchemaTool;

    static Nuke.Common.IO.AbsolutePath SchemaProjectFolder { get; } = RootDirectory / "SchemaProject";
    static Nuke.Common.IO.AbsolutePath SchemaProjectFileName { get; } = SchemaProjectFolder / "SchemaProject.csproj";

    /// <summary>
    /// Produces c# IDS schema files starting from the XSD format.
    /// The tool is deployed by the annotated <see cref="SchemaTool"/>.
    /// The schema is loaded from the repository to ensure internal coherence.
    /// </summary>
    Target CleanSchemaProject => _ => _
        .AssuredAfterFailure()
        .Executes(() =>
        {
            // ======= Preparing IDS Schema

            // development samples
            var schemaFile = RootDirectory / "Development" / "ids.xsd";
            var schemaContent = File.ReadAllText(schemaFile);

            // min/max cardinality hack
            // we replace the xs version with our own added at the bottom of the schema
            //
            schemaContent = schemaContent.Replace("</xs:schema>", $"{cardinalityHack}\r\n</xs:schema>"); // add our own implementation
            schemaContent = schemaContent.Replace( // point to our implementation instead of xs
                """<xs:attributeGroup ref="xs:occurs"/>""",
                """<xs:attributeGroup ref="ids:minmaxAttributesGroup"/>"""
                );

            // replace xs:restriction type with xs:int type to allow XSD processing
            //
            // Later in the code we fix the generated csharp to use restriction instead of the int.
            //
            schemaContent = schemaContent.Replace(
                "xs:element ref=\"xs:restriction\"",
                "xs:element name=\"restriction\" type=\"xs:int\""
                );

            // remove schema imports that are not required
            //
            foreach (var schemaString in RemoveSchemas)
                schemaContent = schemaContent.Replace(schemaString, "");

            // we save the modified version of the schema to a temp file
            //
            var hackedSchemaFileName = Path.ChangeExtension(schemaFile, ".ren.xsd");
            using (var fixedSchemaFile = File.CreateText(hackedSchemaFileName))
            {
                fixedSchemaFile.Write(schemaContent);
            }

            // run dotnet-xscgen against the hacked schema file 
            //
            var arguments = $"\"{hackedSchemaFileName}\" --verbose --netCore --order --nullable --nullableReferenceAttributes --output=\"{SchemaProjectFolder}\"";
            SchemaTool(arguments);

            // the hacked file can be deleted (it was temporary)
            //
            File.Delete(hackedSchemaFileName);

            // fix the generated csharp to use restriction instead of the int (see above)
            //
            var csSchemaFile = SchemaProjectFolder / "ids.cs";
            var csSource = "#nullable enable" + Environment.NewLine + File.ReadAllText(csSchemaFile);
            csSource = csSource.Replace("public int RestrictionValue {", "public Restriction? RestrictionValue {");
            csSource = csSource.Replace(
                "XmlElementAttribute(\"restriction\", Order=1",
                "XmlElementAttribute(\"restriction\", Order=1, Namespace = \"http://www.w3.org/2001/XMLSchema\""
                );
            csSource = csSource.Replace(
                "System.Nullable<int> Restriction",
                "Restriction? Restriction"
                );
            csSource = csSource.Replace(
                "this.RestrictionValue = value.GetValueOrDefault();",
                "this.RestrictionValue = value;"
                );
            csSource = csSource.Replace(
                "this.RestrictionValueSpecified = value.HasValue;",
                "this.RestrictionValueSpecified = value is not null;"
                );
            File.WriteAllText(csSchemaFile, csSource);
        });

    string[] RemoveSchemas = new[]
    {
        """<xs:import namespace="http://www.w3.org/2001/XMLSchema" schemaLocation="http://www.w3.org/2001/XMLSchema.xsd"/>""",
        """<xs:import namespace="http://www.w3.org/2001/XMLSchema-instance" schemaLocation="http://www.w3.org/2001/XMLSchema-instance"/>""",
    };


    const string cardinalityHack = """
			<!--  cardinalityHack to remove xs elements -->
			<xs:simpleType name="allNNI">
				<xs:annotation>
					<xs:documentation>for maxOccurs</xs:documentation>
				</xs:annotation>
				<xs:union memberTypes="xs:nonNegativeInteger">
					<xs:simpleType>
						<xs:restriction base="xs:NMTOKEN">
							<xs:enumeration value="unbounded"/>
						</xs:restriction>
					</xs:simpleType>
				</xs:union>
			</xs:simpleType>

			<xs:attributeGroup name="minmaxAttributesGroup">
				<xs:attribute name="minOccurs" type="xs:nonNegativeInteger" default="1"/>
				<xs:attribute name="maxOccurs" type="ids:allNNI" default="1"/>
			</xs:attributeGroup>
		""";

    Target CompileSchemaProject => _ => _
        .DependsOn(CleanSchemaProject)
        .Executes(() =>
        {
            DotNetTasks.DotNetBuild(s => s
                .SetProjectFile(SchemaProjectFileName).SetConfiguration("Release")
            );
        });

    Target CreateTestCases => _ => _
        .DependsOn(CleanSchemaProject)
        .Executes(() =>
        {
            DotNetTasks.DotNetRun(s => s
                .SetProjectFile(SchemaProjectFileName).SetConfiguration("Release")
            );
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
            // todo: once stable, this could be improved to omit contents based on failure patter name
            // todo: once stable, constrained on expected auditing failures on the "fail-" cases should be added
            var schemaFile = RootDirectory / "Development" / "ids.xsd";
            var inputFolder = RootDirectory / "Documentation" / "testcases";
            var arguments = $"audit \"{inputFolder}\" --omitContentAuditPattern \"[\\\\|/]invalid-\" -x \"{schemaFile}\"";
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
