using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
	class Program
	{
		static void Main(string[] args)
		{
			var stackOfText = new Stack<string>();
			StringBuilder text = new StringBuilder();
			string countAsString = Console.ReadLine();
			int count = int.Parse(countAsString);

			for (int i = 0; i < count; i++)
			{
				string[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries);

				string command = input[0];

				if (command == "1")
				{
					stackOfText.Push(text.ToString());
					string textToAppend = input[1];
					text.Append(textToAppend);
				}
				else if (command == "2")
				{
					int index = int.Parse(input[1]);
					stackOfText.Push(text.ToString());
					int startIndex = text.Length - index;
					text.Remove(startIndex, index);
				}
				else if (command == "3")
				{
					int index = int.Parse(input[1]);
					Console.WriteLine(text[index - 1]);
				}
				else if (command == "4")
				{
					text.Clear();
					string textToAppend = stackOfText.Pop();
					text.Append(textToAppend);
				}
			}
		}
	}
}
