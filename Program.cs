using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Set values: ");
			string userInput = Console.ReadLine();

			showFizzBuzz(userInput);
		}

		private static int[] getValuesArray(string input)
		{
			int[] valuesArray = new int[3];

			string[] inputArray = input.Split(null, 3);
			valuesArray[0] = Int32.Parse(inputArray[0]);
			valuesArray[1] = Int32.Parse(inputArray[1]);
			valuesArray[2] = Int32.Parse(inputArray[2]);

			return valuesArray;
		}

		private static void showFizzBuzz(string input)
		{
			int[] values = getValuesArray(input);

			int x = values[0];
			int z = values[1];
			int n = values[2];

			for (int i = 1; i <= n; i++)
			{
				if (i % x == 0 && i % z == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (i % x == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (i % z == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}