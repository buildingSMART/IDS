using Ids;
using SchemaProject.DocAutomation;
using SchemaProject.Helpers;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

        var destFolder = new DirectoryInfo("C:\\Data\\Dev\\BuildingSmart\\IDS\\Documentation\\testcases\\");
        foreach (var item in destFolder.GetFiles("*.ids", SearchOption.AllDirectories))
        {
            item.Delete();
        }

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
            }
            else if (inScript)
            {
                buffer.AppendLine(line);
            }
        }
        Console.WriteLine("Done");

    }
}