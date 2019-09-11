using System;
using System.Linq;

namespace _04.AddVAT
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ReadLine()
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.Select(price => price * 1.2)
				.ToList()
				.ForEach(price =>
				  {
					  Console.WriteLine($"{price:F2}");
				  });
		}
	}
}
