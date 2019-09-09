using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _03.WordCount
{
	class Program
	{
		static void Main(string[] args)
		{
			string textPath = @"text.txt";
			string wordsPath = @"words.txt";
			string[] textLines = File.ReadAllLines(textPath);
			string[] words = File.ReadAllLines(wordsPath);
			var wordsInfo = new Dictionary<string, int>();

			foreach (string word in words)
			{
				string currentWordLowerCase = word.ToLower();

				if (!wordsInfo.ContainsKey(word))
				{
					wordsInfo[word] = 0;
				}
			}

			foreach (string currentLine in textLines)
			{
				string[] currentLineWords = currentLine
					.ToLower()
					.Split(new char[] { '.', ',', ';', '!', '?', '-', ' ', '\'', ':' });

				foreach (string currentWord in currentLineWords)
				{
					if (wordsInfo.ContainsKey(currentWord))
					{
						wordsInfo[currentWord]++;
					}
				}
			}

			string actualResultPath = @"actualResult.txt";
			string expectedResultPath = @"expectedResult.txt";

			foreach ((string key, int value) in wordsInfo)
			{
				File.AppendAllText(actualResultPath, $"{key} - {value} {Environment.NewLine}");
			}

			foreach ((string key, int value) in wordsInfo.OrderByDescending(x => x.Value))
			{
				File.AppendAllText(expectedResultPath, $"{key} - {value} {Environment.NewLine}");
			}
		}
	}
}
