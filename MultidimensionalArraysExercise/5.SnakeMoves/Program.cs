using System;
using System.Linq;

namespace _5.SnakeMoves
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			string snake = Console.ReadLine();
			char[,] matrix = new char[size[0], size[1]];
			int snakeLenght = snake.Length;
			int counter = 0;

			for (int row = 0; row < size[0]; row++)
			{
				for (int col = 0; col < size[1]; col++)
				{
					matrix[row, col] = snake[counter];
					counter++;

					if (counter >= snakeLenght)
					{
						counter = 0;
					}
				}
			}

			for (int i = 0; i < size[0]; i++)
			{
				for (int j = 0; j < size[1]; j++)
				{
					Console.Write(matrix[i, j]);
				}

				Console.WriteLine();
			}
		}
	}
}
