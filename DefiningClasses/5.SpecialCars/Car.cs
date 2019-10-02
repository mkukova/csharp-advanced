using System;
using System.Text;

namespace _5.SpecialCars
{
	class Car
	{
		public string Model { get; set; }
		public string Make { get; set; }
		public int Year { get; set; }
		public double FuelConsumption { get; set; }
		public double Fuel { get; set; }
		public Engine Engine { get; set; }
		public Tire Tires { get; set; }

		public Car()
		{
			this.Make = "VW";
			this.Model = "Golf";
			this.Year = 2025;
			this.Fuel = 200;
			this.FuelConsumption = 10;
		}

		public Car(string make, string model, int year) : this()
		{
			this.Make = make;
			this.Model = model;
			this.Year = year;
		}
		public Car(
			string make,
			string model,
			int year,
			double fuel,
			double fuelConsumption)
			: this(make, model, year)
		{
			this.Fuel = fuel;
			this.FuelConsumption = fuelConsumption;
		}

		public Car(
			string make,
			string model,
			int year,
			double fuel,
			double fuelConsumption,
			Engine engine,
			Tire tires)
			: this(make, model, year, fuel, fuelConsumption)
		{
			this.Engine = engine;
			this.Tires = tires;
		}

		public void Drive(double distance)
		{
			double consumedFuel = FuelConsumption/ 100 * distance;

			if (consumedFuel > this.Fuel)
			{
				throw new ArgumentException("You do not have enough fuel to perform this trip!");
			}

			this.Fuel -= consumedFuel;
		}

		public string WhoAmI()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Make: {this.Make}");
			sb.AppendLine($"Model: {this.Model}");
			sb.AppendLine($"Year: {this.Year}");
			sb.AppendLine($"HorsePower: {this.Engine.HorsePower}");
			sb.AppendLine($"FuelQuantity: {this.Fuel}");
			return sb.ToString();
		}
	}
}
