using System;
using System.IO;
using System.Linq;

namespace _01.EvenLines
{
	class Program
	{
		static void Main(string[] args)
		{
			string textFileName = @"text.txt";
			StreamReader reader = new StreamReader(textFileName);
			int counter = 0;

			using (reader)
			{
				string currentLine = reader.ReadLine();

				while (currentLine != null)
				{
					if (counter % 2 == 0)
					{
						string replacedSymbols = ReplaceSpecialCharacters(currentLine);
						string reversedWords = ReversedWords(replacedSymbols);
						Console.WriteLine(reversedWords);
					}

					counter++;
					currentLine = reader.ReadLine();
				}
			}
		}

		private static string ReversedWords(string replacedSymbols)
		{
			return string.Join(" ", replacedSymbols.Split().Reverse());
		}

		private static string ReplaceSpecialCharacters(string currentLine)
		{
			return currentLine.Replace("-", "@")
				.Replace(",", "@")
				.Replace(".", "@")
				.Replace("!", "@")
				.Replace("?", "@");
		}
	}
}
