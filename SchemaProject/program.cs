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
        bool inScript = false;
        string file = "";
        var buffer = new StringBuilder();
        var allLines = File.ReadAllLines("C:\\Data\\Dev\\BuildingSmart\\IDS\\Documentation\\testcases\\scripts.md");

        // clean all IDS away
        var destFolder = new DirectoryInfo("C:\\Data\\Dev\\BuildingSmart\\IDS\\Documentation\\testcases\\");
        foreach (var item in destFolder.GetFiles("*.ids", SearchOption.AllDirectories))
        {
            item.Delete();
        }

        // Regenerate IDSs
        // 
        var allIfcFound = true;
        var expectedIfcFileNames = new List<string>();
        foreach (var line in allLines)
        {
            if (line.StartsWith("``` ids "))
            {
                file = line.Substring(8);
                inScript = true;
                buffer = new StringBuilder();
            }
            else if (line.StartsWith("```") && inScript)
            {
                inScript = false;
                var fName = Path.Combine(destFolder.FullName, file);
                FileInfo fInfo = new FileInfo(fName);

                var scr = new IdsScript(buffer.ToString());
                var t2 = scr.GetIds();
                IdsHelpers.WriteIds(fInfo.FullName, t2);

                var ifcName = Path.ChangeExtension(fInfo.FullName, "ifc");
                expectedIfcFileNames.Add(ifcName);
                if (!File.Exists(ifcName))
                {
                    
                    Console.WriteLine($"Missing ifc: - {ifcName}");
                    allIfcFound = false;
                }
            }
            else if (inScript)
            {
                buffer.AppendLine(line);
            }
        }

        
        // extra ifcs
        foreach (var item in destFolder.GetFiles("*.ifc", SearchOption.AllDirectories))
        {
            if (!expectedIfcFileNames.Contains(item.FullName))
            {
                Console.WriteLine($"Extra IFC: - {item.FullName}");
                if (allIfcFound)
                {
                    // item.Delete();
                }
            }
        }
        
        Console.WriteLine("");
        Console.WriteLine("Done");
    }
}