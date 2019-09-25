using System;
using System.Linq;

namespace _5.SpecialCars
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "No more tires")
			{
				double[] currentTire = input
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(double.Parse)
					.ToArray();

				int tyreYear = (int)currentTire[0];
				double tyrePressure = currentTire[1];
			}
		}
	}
}
