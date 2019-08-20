using System;
using System.Collections.Generic;

namespace _7.TrafficJam
{
	class Program
	{
		static void Main(string[] args)
		{
			string carsToPassAsString = Console.ReadLine();
			int carsToPass = int.Parse(carsToPassAsString);
			int passedCars = 0;
			var cars = new Queue<string>();
			string input = Console.ReadLine();

			while (input != "end")
			{
				if (input == "green")
				{
					int carsCount = cars.Count;
					int count = Math.Min(carsToPass, carsCount);

					for (int i = 0; i < count; i++)
					{
						string currentCar = cars.Dequeue();
						Console.WriteLine($"{currentCar} passed!");
						passedCars++;
					}
				}
				else
				{
					cars.Enqueue(input);
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"{passedCars} cars passed the crossroads.");
		}
	}
}
