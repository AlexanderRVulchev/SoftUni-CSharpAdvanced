namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            string output = string.Empty;
            using (var reader = new StreamReader(inputFilePath))
            {
                List<char> charsToReplace = new List<char> { '-', ',', '.', '!', '?' };
                string line;
                int counter = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (counter % 2 != 0)
                    {
                        counter++;
                        continue;
                    }

                    StringBuilder sb = new StringBuilder(line);
                    for (int i = 0; i < sb.Length; i++)
                    {
                        if (charsToReplace.Contains(sb[i]))
                        {
                            sb[i] = '@';
                        }
                    }
                    List<string> words = new List<string>(sb.ToString().Split());
                    words.Reverse();
                    output = output + string.Join(" ", words) + "\r\n";
                    counter++;
                }
            }
            return output;
        }
    }
}
