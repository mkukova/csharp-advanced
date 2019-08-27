using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.RadioactiveMutantVampireBunnies
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] liarSize = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int rows = liarSize[0];
			int cols = liarSize[1];
			var liar = new char[rows, cols];
			int playerRow = -1;
			int playerCol = -1;

			for (int row = 0; row < rows; row++)
			{
				string currentRow = Console.ReadLine();

				for (int col = 0; col < cols; col++)
				{
					liar[row, col] = currentRow[col];

					if (liar[row, col] == 'P')
					{
						playerRow = row;
						playerCol = col;
					}
				}
			}

			liar[playerRow, playerCol] = '.';

			string commands = Console.ReadLine().ToLower();
			int commandsLenght = commands.Length;

			for (int i = 0; i < commandsLenght; i++)
			{
				char currentCommand = commands[i];
				BunniesSprerad(liar);

				if (currentCommand == 'u')
				{
					if (IsInside(liar, playerRow - 1, playerCol))
					{
						playerRow -= 1;

						if (liar[playerRow, playerCol] == 'B')
						{
							PrintMatrix(liar);
							Console.WriteLine($"dead: {playerRow} {playerCol}");
							break;
						}
					}
					else
					{
						PrintMatrix(liar);
						Console.WriteLine($"won: {playerRow} {playerCol}");
						break;
					}
				}
				else if (currentCommand == 'd')
				{
					if (IsInside(liar, playerRow + 1, playerCol))
					{
						playerRow += 1;

						if (liar[playerRow, playerCol] == 'B')
						{
							PrintMatrix(liar);
							Console.WriteLine($"dead: {playerRow} {playerCol}");
							break;
						}
					}
					else
					{
						PrintMatrix(liar);
						Console.WriteLine($"won: {playerRow} {playerCol}");
						break;
					}
				}
				else if (currentCommand == 'l')
				{
					if (IsInside(liar, playerRow, playerCol - 1))
					{
						playerCol -= 1;

						if (liar[playerRow, playerCol] == 'B')
						{
							PrintMatrix(liar);
							Console.WriteLine($"dead: {playerRow} {playerCol}");
							break;
						}
					}
					else
					{
						PrintMatrix(liar);
						Console.WriteLine($"won: {playerRow} {playerCol}");
						break;
					}
				}
				else if (currentCommand == 'r')
				{
					if (IsInside(liar, playerRow, playerCol + 1))
					{
						playerCol += 1;

						if (liar[playerRow, playerCol] == 'B')
						{
							PrintMatrix(liar);
							Console.WriteLine($"dead: {playerRow} {playerCol}");
							break;
						}
					}
					else
					{
						PrintMatrix(liar);
						Console.WriteLine($"won: {playerRow} {playerCol}");
						break;
					}
				}
			}
		}

		static bool IsInside(char[,] matrix, int desiredRow, int desiredCol)
		{
			if (desiredRow < matrix.GetLength(0) && desiredRow >= 0
				&& desiredCol < matrix.GetLength(1) && desiredCol >= 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		static void BunniesSprerad(char[,] matrix)
		{
			char bunny = 'B';
			var coordinates = new Queue<int>();

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					if (matrix[row, col] == bunny)
					{
						coordinates.Enqueue(row);
						coordinates.Enqueue(col);
					}
				}
			}

			while (coordinates.Any())
			{
				int row = coordinates.Dequeue();
				int col = coordinates.Dequeue();

				if (IsInside(matrix, row - 1, col))
				{
					matrix[row - 1, col] = bunny;
				}

				if (IsInside(matrix, row + 1, col))
				{
					matrix[row + 1, col] = bunny;
				}

				if (IsInside(matrix, row, col + 1))
				{
					matrix[row, col + 1] = bunny;
				}

				if (IsInside(matrix, row, col - 1))
				{
					matrix[row, col - 1] = bunny;
				}
			}
		}

		static void PrintMatrix(char[,] matrix)
		{
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					Console.Write(matrix[row, col]);
				}

				Console.WriteLine();
			}
		}
	}
}
