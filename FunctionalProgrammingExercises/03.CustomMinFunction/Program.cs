using System;
using System.Linq;

namespace _03.CustomMinFunction
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<int[], int> minFunction = numbers =>
				{
					int minValue = int.MaxValue;

					foreach (int number in numbers)
					{
						if (number < minValue)
						{
							minValue = number;
						}
					}

					return minValue;
				};

			int[] inputNumbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			int minNumber = minFunction(inputNumbers);
			Console.WriteLine(minNumber);
		}
	}
}
