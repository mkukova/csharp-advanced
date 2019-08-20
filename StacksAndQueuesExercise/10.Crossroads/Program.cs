﻿using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
	class Program
	{
		static void Main(string[] args)
		{
			var queueOfCars = new Queue<string>();
			int greenLightDuration = int.Parse(Console.ReadLine());
			int freeWindowDuration = int.Parse(Console.ReadLine());
			string input = Console.ReadLine();
			bool isHitted = false;
			string hitCarName = string.Empty;
			char hittedSymbol = '\0';
			int totalCars = 0;

			while (input != "END")
			{
				if (input != "green")
				{
					queueOfCars.Enqueue(input);
					input = Console.ReadLine();
					continue;
				}

				int currentGreenLightDuration = greenLightDuration;

				while (currentGreenLightDuration > 0 && queueOfCars.Count > 0)
				{
					string carName = queueOfCars.Dequeue();
					int carLenght = carName.Length;

					if (currentGreenLightDuration - carLenght >= 0)
					{
						currentGreenLightDuration -= carLenght;
						totalCars++;
					}
					else
					{
						currentGreenLightDuration += freeWindowDuration;

						if (currentGreenLightDuration - carLenght >= 0)
						{
							totalCars++;
							break;
						}
						else
						{
							isHitted = true;
							hitCarName = carName;
							hittedSymbol = carName[currentGreenLightDuration];
							break;
						}
					}
				}

				if (isHitted)
				{
					break;
				}

				input = Console.ReadLine();
			}

			if (isHitted)
			{
				Console.WriteLine("A crash happened!");
				Console.WriteLine($"{hitCarName} was hit at {hittedSymbol}.");
			}
			else
			{
				Console.WriteLine("Everyone is safe.");
				Console.WriteLine($"{totalCars} total cars passed the crossroads.");
			}
		}
	}
}
