using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Please select:");
        Console.WriteLine("1) Water");
        Console.WriteLine("2) Juice");
        Console.WriteLine("3) Lemonade");
        Console.WriteLine("4) Quit");

        int Selection = int.Parse(Console.ReadLine());

        switch (Selection)
        {

            case 1:
                Console.WriteLine("You selected Water.");
                break;

            case 2:
                Console.WriteLine("You selected Juice.");
                break;

            case 3:
                Console.WriteLine("You selected Lemonade.");
                break;

            case 4:
                Console.WriteLine("Quit!");
                break;
        }
    }
}