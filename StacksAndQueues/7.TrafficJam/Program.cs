using System;
using System.Collections.Generic;

namespace _7.TrafficJam
{
	class Program
	{
		static void Main(string[] args)
		{
			int carsToPass = int.Parse(Console.ReadLine());
			int passedCars = 0;
			Queue<string> cars = new Queue<string>();
			string input = Console.ReadLine();

			while (input != "end")
			{
				if (input == "green")
				{
					int count = Math.Min(carsToPass, cars.Count);

					for (int i = 0; i < count; i++)
					{
						Console.WriteLine($"{cars.Dequeue()} passed!");
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
