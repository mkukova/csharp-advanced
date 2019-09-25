using System;
using System.Collections.Generic;
using System.Text;

namespace _3.CarConstructors
{
	class Car
	{
		private string model;
		private string make;
		private int year;
		private double fuel;

		public string Model { get; set; }
		public string Make { get; set; }
		public int Year { get; set; }
		public double FuelConsumption { get; set; }
		public double Fuel
		{
			get
			{
				return Math.Floor(fuel);
			}
			set
			{
				if (value > 1)
				{
					fuel += value;
				}
			}
		}

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
			this.make = make;
			this.model = model;
			this.year = year;
		}
		public Car(
			string make,
			string model,
			int year,
			double fuel,
			double fuelConsumption)
			: this(make, model, year)
		{
			this.fuel = fuel;
			this.FuelConsumption = fuelConsumption;
		}
		public void Drive(double distance)
		{
			double consumedFuel = distance / 100 * FuelConsumption;

			if (consumedFuel > fuel)
			{
				throw new ArgumentException("You do not have enough fuel to perform this trip!");
			}

			fuel -= consumedFuel;
		}

		public string WhoAmI()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Make: {this.Make}");
			sb.AppendLine($"Model: {this.Model}");
			sb.AppendLine($"Year: {this.Year}");
			sb.AppendLine($"Fuel: {this.Fuel:F2}L");
			return sb.ToString();
		}
	}
}
