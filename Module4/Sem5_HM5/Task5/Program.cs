using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	public class FileLines
	{
		Stream stream;
		List<string> lines;
		string path;

		public FileLines(string path)
		{
			
			Path = path;
			lines = new List<string>();
			using(StreamReader stream = new StreamReader(path))
			{
				String line = stream.ReadToEnd();
				lines = line.Split(new char[]{ ' '},StringSplitOptions.RemoveEmptyEntries).ToList();

			}
		}
		public IEnumerator GetEnumerator()
		{
			return new FileEnumerator(lines);
		}
		public string Path { get => path; set => path = value; }
	}
	class FileEnumerator : IEnumerator
	{
		List<string> lines;
		int Position = -1;
		public FileEnumerator(List<string> lines)
		{
			this.lines = lines;
		}

		public object Current => lines[Position];

		public bool MoveNext() => ++Position < lines.Count;


		public void Reset() => Position = -1;
		
	}
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				string path = "../../test.txt";
				try
				{
					FileLines file = new FileLines(path);
					foreach (var item in file)
					{
						Console.WriteLine(item);
					}
				}
				catch (Exception ex)
				{

					Console.WriteLine(ex.Message);
				}

			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
			
			Console.ReadLine();
		}
	}
}
