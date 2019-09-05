using System;
using System.IO;

namespace _01.OddLines
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = "files";
			string inputFilePath = Path.Combine(path, "Input.txt");
			string outputFilePath = Path.Combine(path, "Output.txt");

			using (var reader = new StreamReader(inputFilePath))
			{
				int count = 0;
				string line = reader.ReadLine();

				using (var writer = new StreamWriter(outputFilePath))
				{
					while (line != null)
					{
						if (count % 2 != 0)
						{
							writer.WriteLine(line);
							Console.WriteLine(line);
						}

						count++;
						line = reader.ReadLine();
					}
				}
			}
		}
	}
}
