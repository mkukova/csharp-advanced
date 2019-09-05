using System.IO;

namespace _02.LineNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = "files";
			string inputFile = "Input.txt";
			string outputFile = "Output.txt";
			string inputFilePath = Path.Combine(path, inputFile);
			string outputFilePath = Path.Combine(path, outputFile);

			StreamReader reader = new StreamReader(inputFilePath);

			using (reader)
			{
				int count = 1;
				string line = reader.ReadLine();
				StreamWriter writer = new StreamWriter(outputFilePath);

				using (writer)
				{
					while (line != null)
					{
						line = $"{count++}. {line}";
						writer.WriteLine(line);
						line = reader.ReadLine();
					}
				}
			}
		}
	}
}
