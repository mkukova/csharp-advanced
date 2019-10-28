using System;

namespace _03.GenericScale
{
	class Program
	{
		static void Main(string[] args)
		{
			var scale = new EqualityScale<int>(5, 6);
			Console.WriteLine(scale.AreEqual());
		}
	}
}
