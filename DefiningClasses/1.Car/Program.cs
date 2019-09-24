using System;

namespace _1.Car
{
	class Program
	{
		static void Main(string[] args)
		{
			Car myCar = new Car(13);
			myCar.Make = "Renault";
			myCar.Model = "Megan";

			Console.WriteLine($"Make: {myCar.Make}\nModel: {myCar.Model}\nYear: {myCar.Year}");
			Console.WriteLine($"Age: {myCar.RealAge()}");
			myCar.GetOld(4);
			Console.WriteLine($"Make: {myCar.Make}\nModel: {myCar.Model}\nYear: {myCar.Year}");
			Console.WriteLine($"Age: {myCar.RealAge()}");
		}
	}
}
