namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string output = String.Empty;
            int lineCounter = 1;
            using (var reader = new StreamReader(inputFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    MatchCollection letterMatches = Regex.Matches(line, @"[A-Za-z]");
                    MatchCollection punctuationMatches = Regex.Matches(line, @"[-.!,?']");
                    output = output 
                        + $"Line {lineCounter}: " 
                        + line 
                        + $" ({letterMatches.Count})({punctuationMatches.Count})" 
                        + "\n";
                    lineCounter++;
                }
            }
            using (var writer = new StreamWriter(outputFilePath))
            {
                writer.Write(output);
            }
        }
    }
}
