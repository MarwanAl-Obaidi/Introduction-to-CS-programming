using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = ".";
        string[] dirList = Directory.GetFiles(path, ".");

        if (dirList.Length > 0)
        {
            foreach (string fileName in dirList)
            {
                Console.WriteLine(fileName);
            }
        }
    }
}