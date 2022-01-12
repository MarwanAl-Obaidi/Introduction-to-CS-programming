using System;

namespace ex_3_1
{
    class ex_4_1
    {
        static void Main()
        {
            short var1 = 1;
            byte var2 = 1;
            float var3 = 1;
            char var4 = 'H';
            bool var5 = true;
            ulong var6 = 1;
            decimal var7 = 1;

            Console.WriteLine("Var1 is of type " + var1.GetType());
            Console.WriteLine("Var2 is of type " + var2.GetType());
            Console.WriteLine("Var3 is of type " + var3.GetType());
            Console.WriteLine("Var4 is of type " + var4.GetType());
            Console.WriteLine("Var5 is of type " + var5.GetType());
            Console.WriteLine("Var6 is of type " + var6.GetType());
            Console.WriteLine("Var7 is of type " + var7.GetType());
        }
    }
}
