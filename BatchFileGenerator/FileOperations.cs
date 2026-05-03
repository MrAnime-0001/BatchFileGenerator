using System;
using System.IO;

namespace BatchFileGenerator
{
    public static class FileOperations
    {
        public static bool IsValidFileName(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return false;

            return fileName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;
        }

        public static string GetFullFileName(string fileName, string extension)
        {
            if (string.IsNullOrWhiteSpace(extension))
                extension = ".bat";
            
            if (!extension.StartsWith("."))
                extension = "." + extension;

            if (!fileName.EndsWith(extension, StringComparison.OrdinalIgnoreCase))
                fileName += extension;

            return fileName;
        }

        public static string SaveBatchFile(string fileName, string content)
        {
            return SaveBatchFileToPath(AppDomain.CurrentDomain.BaseDirectory, fileName, content);
        }

        public static string SaveBatchFileToPath(string directory, string fileName, string content)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string batchFilePath = Path.Combine(directory, fileName);
            File.WriteAllText(batchFilePath, content);
            return batchFilePath;
        }
    }
}
