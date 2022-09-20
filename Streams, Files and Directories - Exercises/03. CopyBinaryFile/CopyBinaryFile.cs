namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            byte[] buffer;
            using (var fileReader = new FileStream(inputFilePath, FileMode.Open))
            {
                buffer = new byte[fileReader.Length];
                fileReader.Read(buffer, 0, buffer.Length);
            }
            using (var fileWriter = new FileStream(outputFilePath, FileMode.Create))
            {
                fileWriter.Write(buffer);
            }
        }
    }
}
