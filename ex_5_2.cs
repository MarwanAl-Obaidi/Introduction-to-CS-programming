using System;

public class Test
{
	public static void Main(string[] args)
	{
		int first_number;
		int second_number;

		Console.WriteLine("Please input the first number: ");
		first_number = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please input the second number: ");
		second_number = Convert.ToInt32(Console.ReadLine());

		if (first_number == second_number)
		{
			Console.WriteLine("Numbers are equal.");
		}
		if (first_number < second_number)
		{
			Console.WriteLine("Number 2 is greater than number 1.");
		}
		if (first_number > second_number)
		{
			Console.WriteLine("Number 1 is greater than number 2.");
		}

	}
}