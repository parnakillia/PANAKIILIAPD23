using System;
using System.IO;

namespace Task1
{
    delegate string TextOperation(string input);

    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "textPD23.txt";
            string outputFile = "resultPD23.txt";
            File.WriteAllText(outputFile, "");

            ProcessFile(inputFile, outputFile, ToUpperCase);
            ProcessFile(inputFile, outputFile, CountCharacters);
            ProcessFile(inputFile, outputFile, CountWords);

            Console.WriteLine("Готово!");
        }

        static void ProcessFile(string inputPath, string outputPath, TextOperation operation)
        {
            var lines = File.ReadAllLines(inputPath);

            foreach (var line in lines)
            {
                string result = operation(line);
                File.AppendAllText(outputPath, result + Environment.NewLine);
            }

            File.AppendAllText(outputPath, "---------------------\n");
        }
        static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        static string CountCharacters(string input)
        {
            return $"Characters: {input.Length}";
        }

        static string CountWords(string input)
        {
            int count = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return $"Words: {count}";
        }
    }
}