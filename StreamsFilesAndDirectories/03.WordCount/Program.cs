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
			string path = "files";
			string wordsPath = Path.Combine(path, "words.txt");
			string[] words = File
				.ReadAllText(wordsPath)
				.ToLower()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries);

			string textPath = Path.Combine(path, "text.txt");
			string[] text = File
				.ReadAllText(textPath)
				.ToLower()
				.Split(new char[] { ',', '.', '-', '!', '?', ':', '\'', ' ' }, StringSplitOptions.RemoveEmptyEntries);

			var wordCount = new Dictionary<string, int>();

			foreach (string word in words)
			{
				wordCount[word] = 0;
			}

			foreach (string word in text)
			{
				if (wordCount.ContainsKey(word))
				{
					wordCount[word]++;
				}
			}

			wordCount = wordCount
				.OrderByDescending(x => x.Value)
				.ToDictionary(y => y.Key, x => x.Value);

			List<string> output = new List<string>();

			foreach (KeyValuePair<string, int> item in wordCount)
			{
				string word = item.Key;
				int count = item.Value;
				string result = $"\n{word} - {count}\n";
				output.Add(result);
			}

			string outputPath = Path.Combine(path, "Output.txt");
			File.WriteAllLines(outputPath, output);
		}
	}
}
