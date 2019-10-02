using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.SpecialCars
{
	class Program
	{
		static void Main()
		{
			List<Tire> tiresInfo = new List<Tire>();
			string input = Console.ReadLine();

			while (input != "No more tires")
			{
				double[] currentTire = input
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(double.Parse)
					.ToArray();

				int tireYear = (int)currentTire[0];
				double tirePressure = currentTire[1];
				Tire tire = new Tire(tireYear, tirePressure);
				tiresInfo.Add(tire);
				input = Console.ReadLine();
			}

			List<Engine> enginesInfo = new List<Engine>();
			input = Console.ReadLine();

			while(input != "Engines done")
			{
				double[] currentEngine = input
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(double.Parse)
					.ToArray();

				int horsePower = (int)currentEngine[0];
				double cubicCapacity = currentEngine[1];
				Engine engine = new Engine(horsePower, cubicCapacity);
				enginesInfo.Add(engine);
				input = Console.ReadLine();
			}

			List<Car> specialCars = new List<Car>();
			input = Console.ReadLine();

			while(input != "Show special")
			{
				string[] currentCar = input
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);

				string make = currentCar[0];
				string model = currentCar[1];
				int year = int.Parse(currentCar[2]);
				double fuel = double.Parse(currentCar[3]);
				double fuelConsumption = double.Parse(currentCar[4]);
				int engineIndex = int.Parse(currentCar[5]);
				int tireIndex = int.Parse(currentCar[6]);
				Tire currentTire = tiresInfo[tireIndex];
				Engine currentEngine = enginesInfo[engineIndex];
				Car car = new Car(make, model, year, fuel, fuelConsumption, currentEngine, currentTire);
				car.Drive(20);
				int horsePower = currentEngine.HorsePower;
				double tiresPressure = currentTire.Pressure * 4;

				if (year >= 2017 &&  horsePower> 330 && tiresPressure>=9 && tiresPressure <= 10)
				{
					specialCars.Add(car);
				}

				input = Console.ReadLine();
			}

			foreach (Car car in specialCars)
			{
				car.WhoAmI();
			}
		}
	}
}
