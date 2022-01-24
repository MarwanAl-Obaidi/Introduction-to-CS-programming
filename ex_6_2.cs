using System;

class Program
    {
        static void Main()
        {
            int i = 0;
            int sum = 0;
            
            while (true)
            {
                Console.Write("Sum is now " + sum + ". Input: " );
                i = Convert.ToInt32(Console.ReadLine());
                sum = sum + i;
                if (sum >= 200)
                {
                    Console.WriteLine("Reached 200." + " The total was " + sum + ".");
                    break;
                }
            }
        }
}