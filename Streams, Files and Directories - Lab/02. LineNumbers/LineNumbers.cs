//Write a program that reads a text file (e. g. input.txt)
//and inserts line numbers in front of each of its lines.
//The result should be written to another text file (e. g. output.txt).
//Use StreamReader and StreamWriter.

namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            {                
                using (var writer = new StreamWriter(outputFilePath))
                {
                    int counter = 1;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine($"{counter}. {line}");
                        counter++;
                    }
                }
            }
        }
    }
}
