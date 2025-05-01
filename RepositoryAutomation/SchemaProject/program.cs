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
using System.Xml.Linq;
using System.Xml.Serialization;

class Program
{
	static public void Main(params string[] args)
	{
		// this project depends on the execution of one of the repository targets defined in the /Build folder
		// If this project does not compile, start a terminal in the root folder and execute the `./build CompileSchemaProject` command.
		//
		Console.WriteLine("Hello IDS!");
		var rename_single_ifc = args.Any(x => x.Equals("--rename-single-ifc"));	
		var delete_ids_first = args.Any(x => x.Equals("--delete-ids-first"));	
		RegenIDS(rename_single_ifc, delete_ids_first);
		Console.WriteLine("Done");
	}

	private static void RegenIDS(bool rename_single_ifc, bool delete_ids_first)
	{
		bool inScript = false;
		string file = "";
		var buffer = new StringBuilder();
		DirectoryInfo? testCasesFolder = new DirectoryInfo(".");
		Console.WriteLine($"Process started in: {testCasesFolder.FullName}");
		while (testCasesFolder is not null)
		{
			var p = Path.Combine(testCasesFolder.FullName, "Documentation", "ImplementersDocumentation", "TestCases");
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
			Message("Directory of Test Cases not found. Execution cancelled.", ConsoleColor.Red);
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
		if (delete_ids_first)
		{
			foreach (var item in allIDSs)
			{
				File.Delete(item);
			}
		}
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
				file = file.Replace(@"\", "/");
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
		// report identified scripts
		
		Message($"Identified: {newIDSs.Count} IDS scripts.", 
			newIDSs.Count == 0 ? ConsoleColor.Red : ConsoleColor.Green
			);


		// extra ifcs
		List<string> extraIfcFileNames = new List<string>();
		foreach (var item in testCasesFolder.GetFiles("*.ifc", SearchOption.AllDirectories))
		{
			if (!expectedIfcFileNames.Contains(item.FullName))
			{
				Message($"Extra IFC: - {item.FullName}", ConsoleColor.DarkYellow);
				var invalidFileName = item.FullName.Replace("fail-", "invalid-");
				if (missingIfcFileNames.Contains(invalidFileName))
				{
					Message("Suitable matching invalid IFC is found, it has been renamed.", ConsoleColor.Blue);
					File.Move(item.FullName, invalidFileName);
				}
				else
				{
					extraIfcFileNames.Add(item.FullName);
				}
			}
		}

		if (rename_single_ifc)
		{
			if (extraIfcFileNames.Count == 1 && missingIfcFileNames.Count == 1)
			{
				var miss = missingIfcFileNames.First();
				var extra = extraIfcFileNames.First();
				Message($"Single IFC mismatch, {extra} renamed to {miss}.", ConsoleColor.Blue);
				File.Move(extra, miss);
				extraIfcFileNames.Clear();
				missingIfcFileNames.Clear();
			}
		}

		// extra IDSs
		if (!delete_ids_first)
		{
			foreach (var item in allIDSs.Except(newIDSs))
			{
				string t = IdsHelpers.CreateDiffReportHtml(item);
				var reportFileName = Path.ChangeExtension(item, "html");
				File.WriteAllText(reportFileName, t);
				Console.WriteLine($"Extra IDS report generated: {reportFileName}");
			}
		}

		// If all found, make it clear
		if (allIfcFound)
		{
			Message("All testcases IFC files found.", ConsoleColor.Green);
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