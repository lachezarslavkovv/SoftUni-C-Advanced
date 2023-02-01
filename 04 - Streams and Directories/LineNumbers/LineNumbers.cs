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
            using StreamReader reader = new StreamReader(inputFilePath);
            using StreamWriter writer = new StreamWriter(outputFilePath);
            int number = 1;

            while (!reader.EndOfStream)
            {
                string text = reader.ReadLine();

                writer.WriteLine($"{number}. {text}");
                number++;
            }
        }
    }
}
