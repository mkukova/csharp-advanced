using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.AutoRepairAndService
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(" ")
				.ToArray();
			var vehicles = new Queue<string>(input);
			var servedVehicles = new Stack<string>();
			string command = Console.ReadLine();

			while (command != "End")
			{
				string[] splittedCommand = command.Split("-");

				switch (splittedCommand[0])
				{
					case "Service":
						{
							if (!vehicles.Any())
							{
								break;
							}

							string currentVehicle = vehicles.Dequeue();
							servedVehicles.Push(currentVehicle);
							Console.WriteLine($" Vehicle { currentVehicle} got served.");
							break;
						}

					case "History":
						{
							Console.WriteLine(string.Join(", ", servedVehicles));
							break;
						}

					case "CarInfo":
						{
							string searchedCar = splittedCommand[1];
							if (servedVehicles.Contains(searchedCar))
							{
								Console.WriteLine("Served.");
							}

							if (vehicles.Contains(searchedCar))
							{
								Console.WriteLine("Still waiting for service.");
							}

							break;
						}

					default:
						Console.WriteLine("Incorrect command!");
						break;
				}

				command = Console.ReadLine();
			}

			if (vehicles.Any())
			{
				Console.WriteLine($"Vehicles for service: {string.Join(", ", vehicles)}");
			}

			Console.WriteLine($"Served vehicles: {string.Join(", ", servedVehicles)}");
		}
	}
}
