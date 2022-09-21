namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath);
            var fileExtensionsDict = new SortedDictionary<string, Dictionary<string, double>>();

            foreach (string file in files)
            {
                Match extensionFinder = Regex.Match(file, @".+(?<extension>[.].+)");
                Match fileNameFinder = Regex.Match(file, @".+\\(?<name>[^\\]+)$");
                string extension = extensionFinder.Groups["extension"].Value;
                string fileName = fileNameFinder.Groups["name"].Value;

                double sizeKB = (double)File.ReadAllBytes(fileName).Length / 1024;

                if (!fileExtensionsDict.ContainsKey(extension))
                    fileExtensionsDict.Add(extension, new Dictionary<string, double>());

                fileExtensionsDict[extension].Add(fileName, sizeKB);
            }

            string reportContent = string.Empty;
            foreach (var extension in fileExtensionsDict
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                reportContent = reportContent + extension.Key + "\n";
                foreach (var file in extension.Value.OrderBy(x => x.Value))
                {
                    reportContent = reportContent + $"--{file.Key} - {file.Value}kb\n";
                }
            }
            return reportContent;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string reportPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);            
            using (var writer = new StreamWriter(reportPath + reportFileName)) 
            {
                writer.Write(textContent);
            }
        }
    }
}
