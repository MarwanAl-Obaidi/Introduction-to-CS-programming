using System;
using System.IO;
using System.Linq;

class Program
    {
        static void Main(string[] args)
        {
            if (args.Any())
            {
                var path = args[0];
                if (File.Exists(path))
                {
                    var content = File.ReadAllText(path);
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine("File does not exist!");
                }
            }
            else
            {
                Console.WriteLine("No filename provided!");
            }
        }
    }