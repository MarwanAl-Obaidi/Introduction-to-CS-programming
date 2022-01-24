using System;

class Program
{
    static void Main()
    {
        int x;
        int y;

        Console.WriteLine("Find the quadrant for a point in x-y axis:");
        Console.Write("X coordinate: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Y coordinate: ");
        y = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(x + y);

        if (x > 0 && y > 0)
        {
            Console.WriteLine("The coordinate point (" + x + "," + y + ") is in the First quandrant.");
        }
        if (x < 0 && y > 0)
        {
            Console.WriteLine("The coordinate point (" + x + "," + y + ") is in the Second quandrant.");
        }
        if (x < 0 && y < 0)
        {
            Console.WriteLine("The coordinate point (" + x + "," + y + ") is in the Third quandrant.");
        }
        if (x > 0 && y < 0)
        {
            Console.WriteLine("The coordinate point (" + x + "," + y + ") is in the Fourth quandrant.");
        }
        if (x == 0 && y == 0)
        {
            Console.WriteLine("The coordinate point (" + x + "," + y + ") is at the origin.");
        }
    }
}