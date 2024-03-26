using DiffMatchPatch;
using Ids;
using SchemaProject.DocAutomation;
using SchemaProject.Helpers;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

class Program
{
	static public void Main()
	{
		// this project depends on the execution of one of the repository targets defined in the /Build folder
		// If this project does not compile, start a terminal in the root folder and execute the `./build CompileSchemaProject` command.
		//
		Console.WriteLine("Hello IDS!");
		RegenIDS();
		Console.WriteLine("Done");
	}

	private static void RegenIDS()
	{
		bool inScript = false;
		string file = "";
		var buffer = new StringBuilder();
		DirectoryInfo? testCasesFolder = new DirectoryInfo(".");
		Console.WriteLine($"Process started in: {testCasesFolder.FullName}");
		while (testCasesFolder is not null)
		{
			var p = Path.Combine(testCasesFolder.FullName, "Documentation", "testcases");
			DirectoryInfo d = new DirectoryInfo(p);
			if (d.Exists)
			{
				testCasesFolder = d;
				break;
			}
			testCasesFolder = testCasesFolder.Parent;
		}
		if (testCasesFolder is null)
		{
			Message("Directory of testcases not found. Execution cancelled.", ConsoleColor.Red);
			return;
		}
		Console.WriteLine($"Testcase generation started in: {testCasesFolder.FullName}");
		FileInfo scriptsFile = new FileInfo(Path.Combine(testCasesFolder.FullName, "scripts.md"));
		if (!scriptsFile.Exists)
		{
			Message("Scripts file not found. Execution cancelled.", ConsoleColor.Red);
			return;
		}

		// reading script
		var allLines = File.ReadAllLines(scriptsFile.FullName);

		// get all IDSs
		var allIDSs = testCasesFolder.GetFiles("*.ids", SearchOption.AllDirectories).Select(f => f.FullName).ToList();
		var newIDSs = new List<string>();

		// Regenerate IDSs
		// 
		var allIfcFound = true;
		var expectedIfcFileNames = new List<string>();
		var missingIfcFileNames = new List<string>();
		var title = "";
		var firstLine = true;
		foreach (var line in allLines)
		{
			if (line.StartsWith("``` ids "))
			{
				file = line.Substring(8);
				inScript = true;
				buffer = new StringBuilder();
				firstLine = true;
			}
			else if (line.StartsWith("```") && inScript) // the script is finished
			{
				inScript = false;
				var fName = Path.Combine(testCasesFolder.FullName, file);
				FileInfo fInfo = new FileInfo(fName);
				newIDSs.Add(fInfo.FullName);

				var scr = new IdsScript(buffer.ToString());
				var t2 = scr.GetIds();
				IdsHelpers.WriteIds(fInfo.FullName, t2);

				var ifcName = Path.ChangeExtension(fInfo.FullName, "ifc");
				expectedIfcFileNames.Add(ifcName);
				if (!File.Exists(ifcName))
				{
					missingIfcFileNames.Add(ifcName);
					Message($"Missing ifc file: - {ifcName}", ConsoleColor.Red);
					allIfcFound = false;
				}
			}
			else if (line.StartsWith("### "))
			{
				title = line.Substring(4);
			}
			else if (inScript)
			{
				if (firstLine) // we check that the title matches the section
				{
					if (line.Trim() != title.Trim())
					{
						Message($"- script title mismatch: `{line}` vs `{title}`", ConsoleColor.Red);
					}
					firstLine = false;
				}
				buffer.AppendLine(line);
			}
		}
		// extra ifcs
		foreach (var item in testCasesFolder.GetFiles("*.ifc", SearchOption.AllDirectories))
		{
			if (!expectedIfcFileNames.Contains(item.FullName))
			{
				Message($"Extra IFC: - {item.FullName}", ConsoleColor.DarkYellow);
				var invalidFileName = item.FullName.Replace("fail-", "invalid-");
				if (missingIfcFileNames.Contains(invalidFileName))
				{
					File.Move(item.FullName, invalidFileName);
					// Console.WriteLine("A matching invalid IFC is required, should you rename this?");
				}
				//else if (allIfcFound)
				//{
				//	// item.Delete();
				//}
			}
		}

		// extra IDSs
		foreach (var item in allIDSs.Except(newIDSs))
		{
			string t = IdsHelpers.CreateDiffReportHtml(item);
			var reportFileName = Path.ChangeExtension(item, "html");
			File.WriteAllText(reportFileName, t);
			Console.WriteLine($"Extra IDS report generated: {reportFileName}");
		}

		
		if (allIfcFound)
		{
			Message("All scripting IFC files found", ConsoleColor.Green);
		}

		Console.WriteLine("");
	}

	internal static void Message(string v, ConsoleColor messageColor)
	{
		var restore = Console.ForegroundColor;
		Console.ForegroundColor = messageColor;
		Console.WriteLine(v);
		Console.ForegroundColor = restore;
	}
}