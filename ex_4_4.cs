using System;

class Program
{
    static void Main()
    {
        byte x = 0;
        byte y = 0;
        byte z = 2;
        String s = "C";


        if (((x >= y) && (y < z)) || ((x > y) && (s == "A")))
        {
            if (s == "C")
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Almost there!");
            }
        }
        else
        {
            Console.WriteLine("Not quite, try once more!");
        }
    }
}