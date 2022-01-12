using System;

class Conversions
{
    static void Main()
    {

        SByte var1 = 1;
        Int64 var2 = 1;
        UInt16 var3 = 1;
        Double var4 = 1;


        if (var1.GetType() == typeof(SByte))
        {
            Console.WriteLine("var1 type ok.");
        }

        if (var2.GetType() == typeof(Int64))
        {
            Console.WriteLine("var2 type ok.");
        }

        if (var3.GetType() == typeof(UInt16))
        {
            Console.WriteLine("var3 type ok.");
        }

        if (var4.GetType() == typeof(Double))
        {
            Console.WriteLine("var4 type ok.");
        }
    }
}
