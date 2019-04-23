using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace пробное_с_файлами_1
{
	class Program
	{
		static void Main(string[] args)
		{
			string dirName = Directory.GetCurrentDirectory();
			string[] dirNames = Directory.GetDirectories(@"..\..\");
			Console.WriteLine("Каталоги выше на два уровня:");
			foreach (string st in dirNames)
				Console.WriteLine("Name: {0}; CreationTime: {1}",
				st, Directory.GetCreationTime(st));
			var file = new DirectoryInfo(dirName);
			Console.WriteLine(dirName);
			if (!Directory.Exists(dirName))
			{
				Directory.CreateDirectory(dirName);
				Console.WriteLine("Создан каталог " + dirName);
			}
			else
				Console.WriteLine("Каталог уже существует!");

			Console.ReadKey();
		}
	}
}
