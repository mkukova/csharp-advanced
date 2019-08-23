using System;
using System.Linq;

namespace _7.KnightGame
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			char[,] board = new char[size, size];

			for (int row = 0; row < size; row++)
			{
				string currentRow = Console.ReadLine();

				for (int col = 0; col < size; col++)
				{
					board[row, col] = currentRow[col];
				}
			}

			int counter = 0;

			while (true)
			{
				int maxCount = 0;
				int knightRow = 0;
				int knightCol = 0;

				for (int row = 0; row < board.GetLength(0); row++)
				{
					for (int col = 0; col < board.GetLength(1); col++)
					{
						int currentCount = 0;

						if (board[row, col] == 'K')
						{
							if (IsInside(board, row - 2, col + 1)
								&& board[row - 2, col + 1] == 'K')
							{
								currentCount++;
							}

							if (IsInside(board, row - 2, col - 1)
								&& board[row - 2, col - 1] == 'K')
							{
								currentCount++;
							}

							if (IsInside(board, row + 2, col + 1)
								&& board[row + 2, col + 1] == 'K')
							{
								currentCount++;
							}

							if (IsInside(board, row + 2, col - 1)
								&& board[row + 2, col - 1] == 'K')
							{
								currentCount++;
							}

							if (IsInside(board, row - 1, col - 2)
								&& board[row - 1, col - 2] == 'K')
							{
								currentCount++;
							}

							if (IsInside(board, row + 1, col - 2)
								&& board[row + 1, col - 2] == 'K')
							{
								currentCount++;
							}

							if (IsInside(board, row - 1, col + 2)
								&& board[row - 1, col + 2] == 'K')
							{
								currentCount++;
							}

							if (IsInside(board, row + 1, col + 2)
								&& board[row + 1, col + 2] == 'K')
							{
								currentCount++;
							}
						}

						if (currentCount > maxCount)
						{
							maxCount = currentCount;
							knightRow = row;
							knightCol = col;
						}
					}
				}

				if (maxCount == 0)
				{
					break;
				}

				board[knightRow, knightCol] = '0';
				counter++;
			}

			Console.WriteLine(counter);
		}

		static bool IsInside(char[,] board, int desiredRow, int desiredCol)
		{
			if (desiredRow < board.GetLength(0) && desiredRow >= 0
				&& desiredCol < board.GetLength(1) && desiredCol >= 0)
			{
				return true;
			}

			return false;
		}
	}
}
