using System;
using System.IO;

class Program
    {
        static void Main()
        {
            Console.Write("Append to file: ");
            string fileName = Console.ReadLine();
            Console.Write("Provide the content for " + fileName + ":\n");
            string content = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine(content);
            }
        }
}