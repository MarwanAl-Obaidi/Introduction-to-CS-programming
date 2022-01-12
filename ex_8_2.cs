using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Filename to create: ");
        string file = Console.ReadLine();
        Console.WriteLine("Provide the content for " + file + ":");
        string textLines = Console.ReadLine();

        File.WriteAllText(file, textLines);

        Console.ReadKey();
    }
}