using System;

namespace _2.CarExtension
{
	class Program
	{
		static void Main(string[] args)
		{
			Car myCar = new Car();
			myCar.Make = "VW";
			myCar.Model = "MK3";
			myCar.Year = 1992;
			myCar.Fuel = 200;
			myCar.FuelConsumption = 200;
			myCar.Drive(2000);
			Console.WriteLine(myCar.WhoAmI());
		}
	}
}
