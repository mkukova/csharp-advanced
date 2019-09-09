using System.IO;
using System;
using System.Linq;

namespace _02.LineNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string textPath = @"text.txt";
			string outputPath = @"output.txt";
			string[] textLines = File.ReadAllLines(textPath);
			int lineCounter = 1;

			foreach (string currentLine in textLines)
			{
				int lettersCount = currentLine.Count(char.IsLetter);
				int punctCount = currentLine.Count(char.IsPunctuation);

				File.AppendAllText(outputPath, $"Line {lineCounter}: {currentLine} ({lettersCount})({punctCount}) {Environment.NewLine}");
				lineCounter++;
			}
		}
	}
}
