using System;

public class Test
{
	public static void Main(string[] args)
	{
		int age;
		Console.WriteLine("Please input your age: ");
		age = Convert.ToInt32(Console.ReadLine());

		if (age >= 18)
		{
			Console.WriteLine("You can cast your vote!");
		}
	}
}
