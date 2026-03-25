using System;
using System.IO;

namespace Task2
{
    class FileLogger
    {
        private string filePath;

        public FileLogger(string path)
        {
            filePath = path;
        }

        public void LogToFile(string message)
        {
            string log = $"[{DateTime.Now}] {message}\n";
            File.AppendAllText(filePath, log);
        }
    }
}