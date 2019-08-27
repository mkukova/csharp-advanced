using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
	class Program
	{
		static void Main(string[] args)
		{
			var parking = new HashSet<string>();
			string input = Console.ReadLine().ToUpper();

			while (input != "END")
			{
				string[] splittedInput = input
					.Split(", ", StringSplitOptions.RemoveEmptyEntries);
				string direction = splittedInput[0];
				string carNumber = splittedInput[1];

				if (direction == "IN")
				{
					parking.Add(carNumber);
				}
				else if (direction == "OUT")
				{
					parking.Remove(carNumber);
				}

				input = Console.ReadLine().ToUpper();
			}

			int parkingCount = parking.Count;

			if (parkingCount == 0)
			{
				Console.WriteLine("Parking Lot is Empty");
			}
			else
			{
				foreach (var carNumber in parking)
				{
					Console.WriteLine(carNumber);
				}
			}
		}
	}
}
