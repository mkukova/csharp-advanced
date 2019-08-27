using System;
using System.Linq;

namespace _3.PrimaryDiagonal
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			int[,] array = new int[size, size];

			for (int i = 0; i < size; i++)
			{
				int[] numbers = Console.ReadLine()
					.Split(" ")
					.Select(int.Parse)
					.ToArray();

				for (int j = 0; j < size; j++)
				{
					array[i, j] = numbers[j];
				}
			}

			int sum = 0;

			for (int i = 0; i < size; i++)
			{
				sum += array[i, i];
			}

			Console.WriteLine(sum);
		}
	}
}
