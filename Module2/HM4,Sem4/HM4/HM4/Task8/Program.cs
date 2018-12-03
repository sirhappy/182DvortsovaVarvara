using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFigures;
namespace Task8
{
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do
			{
				Ellipse e = new Ellipse(3, 8);
				Triangle t = new Triangle(5, 4);
				Dimensions[] arr = new Dimensions[4];
				arr[0] = e;
				arr[1] = t;
				arr[2] = new Ellipse(4, 6);
				arr[3] = new Triangle(2, 8);

				//Запись в файловый поток
				StreamWriter outFile = null;
				if (outFile == null)
					// Создаем поток и связываем его с файлом.
					// Файл создается всегда заново:        
					outFile = new StreamWriter("Фигуры");


				foreach (Dimensions d in arr)
					outFile.WriteLine(d.Record);  // Запись в поток
				outFile.Flush();     // Пересылка в файл (очистка буфера потока)
				outFile.Close();    // Закрываем поток (освобождаем файл)    
				StreamReader inputFile = new StreamReader("Фигуры");
				List<string> input = new List<string>();

				while (true)
				{
					string line = inputFile.ReadLine();
					if (line == null) break;
					input.Add(line);
				}
				Dimensions[] result = new Dimensions[input.Count];
				int count = 0;
				foreach (string s in input)
				{
					string[] lineArr = s.Split(' ');
					double x = double.Parse(lineArr[1]);
					double y = double.Parse(lineArr[2]);
					if (lineArr[0] == "Эллипс") result[count++] = new Ellipse(x, y);
					if (lineArr[0] == "Треугольник") result[count++] =
									 new Triangle(x, y);
				}




				Console.WriteLine("Записи, прочитанные из файла:");

				foreach (Dimensions d in result)
				{
					d.GhengeGabarits(10);
					Console.WriteLine(d.description());

				}

			} while (Console.ReadKey().Key != ConsoleKey.Escape);

		}
	}
}
