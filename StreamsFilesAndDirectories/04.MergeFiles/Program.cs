using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace _04.MergeFiles
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = "files";
			string firstFileName = "FileOne.txt";
			string secondFileName = "FileTwo.txt";
			string firstPath = Path.Combine(path, firstFileName);
			string secondPath = Path.Combine(path, secondFileName);

			string[] firstInfo = File.ReadAllLines(firstPath);
			string[] secondInfo = File.ReadAllLines(secondPath);

			List<string> result = new List<string>();
			result.AddRange(firstInfo);
			result.AddRange(secondInfo);
			string[] output = result
				.OrderBy(x => x)
				.ToArray();

			string outputFileName = "Output.txt";
			string outputPath = Path.Combine(path, outputFileName);
			File.WriteAllLines(outputPath, output);
		}
	}
}
