using System;

{
    class Pattern
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(args[0]);
            for (int i = 1; i <= n; i++)
            {
                int arg;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n\r");
            }
        }
    }
}