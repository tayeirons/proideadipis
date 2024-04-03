using System;
using System.IO;

class FileChecker
{
    static void Main()
    {
        // Define the files to check
        string[] filesToCheck = { "file1.txt", "file2.txt", "file3.txt" };
        bool allFilesFound = true;

        // Check if each file exists
        foreach (var file in filesToCheck)
        {
            if (!File.Exists(file))
            {
                Console.WriteLine($"{file} not found.");
                allFilesFound = false;
            }
        }

        // If all files are found
        if (allFilesFound)
        {
            Console.WriteLine("All files are present.");
        }
    }
}
