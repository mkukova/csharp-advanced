using System;

namespace _1.Car
{
	class Program
	{
		static void Main(string[] args)
		{
			Car myCar = new Car();
			myCar.Make = "Renault";
			myCar.Model = "Megan";
			myCar.Year = 15;
			Console.WriteLine($"Make: {myCar.Make}\nModel: {myCar.Model}\nYear: {myCar.Year}");
		}
	}
}
