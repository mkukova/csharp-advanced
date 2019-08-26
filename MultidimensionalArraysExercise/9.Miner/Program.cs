using System;
using System.Linq;

namespace _9.Miner
{
	class Program
	{
		static void Main(string[] args)
		{
			string fieldSizeAsString = Console.ReadLine();
			int fieldSize = int.Parse(fieldSizeAsString);
			string[] commands = Console.ReadLine()
				.ToLower()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			var field = new char[fieldSize, fieldSize];
			int startingRowIndex = 0;
			int startingColIndex = 0;

			for (int row = 0; row < fieldSize; row++)
			{
				char[] currentRow = Console.ReadLine()
					.ToLower()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(char.Parse)
					.ToArray();

				for (int col = 0; col < fieldSize; col++)
				{
					field[row, col] = currentRow[col];

					if (field[row, col] == 's')
					{
						startingRowIndex = row;
						startingColIndex = col;
					}
				}
			}

			int collectedCoalsCount = 0;
			int i = 0;

			for (i = 0; i < commands.Length; i++)
			{
				string currentCommand = commands[i];
				char currentSymbol = ' ';

				if (currentCommand == "up")
				{
					if (!IsInside(field, startingRowIndex - 1, startingColIndex))
					{
						continue;
					}

					startingRowIndex -= 1;
					currentSymbol = field[startingRowIndex, startingColIndex];

					if (currentSymbol == '*')
					{
						continue;
					}
					else if (currentSymbol == 'e')
					{
						Console.WriteLine($"Game over! ({startingRowIndex}, {startingColIndex})");
						break;
					}
					else if (currentSymbol == 'c')
					{
						collectedCoalsCount++;
						field[startingRowIndex, startingColIndex] = '*';
					}

				}
				else if (currentCommand == "down")
				{
					if (!IsInside(field, startingRowIndex + 1, startingColIndex))
					{
						continue;
					}

					startingRowIndex += 1;
					currentSymbol = field[startingRowIndex, startingColIndex];

					if (currentSymbol == '*')
					{
						continue;
					}
					else if (currentSymbol == 'e')
					{
						Console.WriteLine($"Game over! ({startingRowIndex}, {startingColIndex})");
						break;
					}
					else if (currentSymbol == 'c')
					{
						collectedCoalsCount++;
						field[startingRowIndex, startingColIndex] = '*';
					}
				}
				else if (currentCommand == "right")
				{
					if (!IsInside(field, startingRowIndex, startingColIndex + 1))
					{
						continue;
					}

					startingColIndex += 1;
					currentSymbol = field[startingRowIndex, startingColIndex];

					if (currentSymbol == '*')
					{
						continue;
					}
					else if (currentSymbol == 'e')
					{
						Console.WriteLine($"Game over! ({startingRowIndex}, {startingColIndex})");
						break;
					}
					else if (currentSymbol == 'c')
					{
						collectedCoalsCount++;
						field[startingRowIndex, startingColIndex] = '*';
					}
				}
				else if (currentCommand == "left")
				{
					if (!IsInside(field, startingRowIndex, startingColIndex - 1))
					{
						continue;
					}

					startingColIndex -= 1;
					currentSymbol = field[startingRowIndex, startingColIndex];

					if (currentSymbol == '*')
					{
						continue;
					}
					else if (currentSymbol == 'e')
					{
						Console.WriteLine($"Game over! ({startingRowIndex}, {startingColIndex})");
						break;
					}
					else if (currentSymbol == 'c')
					{
						collectedCoalsCount++;
						field[startingRowIndex, startingColIndex] = '*';
					}
				}

				bool areAnyCoals = false;

				foreach (char symbol in field)
				{
					if (symbol == 'c')
					{
						areAnyCoals = true;
						break;
					}
				}

				if (!areAnyCoals)
				{
					Console.WriteLine($"You collected all coals! ({startingRowIndex}, {startingColIndex})");
					break;
				}
			}

			int remainingCoalsCounter = 0;

			foreach (char symbol in field)
			{
				if (symbol == 'c')
				{
					remainingCoalsCounter++;
				}
			}

			if (i == commands.Length)
			{
				Console.WriteLine($"{remainingCoalsCounter} coals left. ({startingRowIndex}, {startingColIndex})");
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

	}
}
