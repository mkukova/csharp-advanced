using System;
using System.IO;

namespace _05.SliceAFile
{
	class Program
	{
		static void Main(string[] args)
		{
			FileStream inputFile = new FileStream(@"files\sliceMe.txt", FileMode.Open);

			using (inputFile)
			{
				long size = inputFile.Length;
				int partSize = (int)Math.Ceiling((double)size / 4);
				var buffer = new byte[partSize];

				for (int i = 1; i <= 4; i++)
				{
					FileStream outputFile = new FileStream($"files\\Part-{i}.txt", FileMode.Create);

					using (outputFile)
					{
						int readedBytes = inputFile.Read(buffer, 0, partSize);
						outputFile.Write(buffer, 0, readedBytes);
					}
				}
			}
		}
	}
}
