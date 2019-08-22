using System;
using System.Linq;

namespace _6.BombTheBasement
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int[] bombParameters = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int targetRow = bombParameters[0];
			int targetCol = bombParameters[1];
			int radius = bombParameters[2];

			int[][] basement = new int[size[0]][];

			for (int i = 0; i < basement.Length; i++)
			{
				basement[i] = new int[size[1]];
			}

			for (int row = 0; row < size[0]; row++)
			{
				for (int col = 0; col < size[1]; col++)
				{
					bool isInRadius = Math.Pow(row - targetRow, 2)
						+ Math.Pow(col - targetCol, 2)
						<= Math.Pow(radius, 2);

					if (isInRadius)
					{
						basement[row][col] = 1;
					}
				}
			}

			for (int col = 0; col < basement[0].Length; col++)
			{
				int counter = 0;

				for (int row = 0; row < basement.Length; row++)
				{
					if (basement[row][col] == 1)
					{
						counter++;
						basement[row][col] = 0;
					}
				}

				for (int row = 0; row < counter; row++)
				{
					basement[row][col] = 1;
				}
			}

			foreach (int[] row in basement)
			{
				Console.WriteLine(string.Join("", row));
			}
		}
	}
}
