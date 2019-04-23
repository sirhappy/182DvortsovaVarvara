using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Sr1
{
	[Serializable]
	public class Vectors3D
	{
		int a;
		int b;
		int c;

		public Vectors3D()
		{
		}

		public Vectors3D(int a, int b, int c)
		{
			A = a;
			B = b;
			C = c;
		}

		public int A { get => a; set => a = value; }
		public int B { get => b; set => b = value; }
		public int C { get => c; set => c = value; }
	}
	class Program
	{
		/// <summary>
		/// Метод для считывания целого числа 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int EnterInt(string message, int min, int max)
		{
			int res;
			bool isCorrect = false;
			do
			{
				Console.Write(message);
				while (!int.TryParse(Console.ReadLine(), out res) || res < min || res > max)
				{
					Console.Error.WriteLine("Error ,try again ");
					Console.Write(message);
				}
				isCorrect = true;

			} while (!isCorrect);
			return res;
		}
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				int n = EnterInt("Enter n = ", 0, 100);

				Vectors3D[] vectors = new Vectors3D[n];
				for (int i = 0; i < vectors.Length; i++)
				{
					vectors[i] = new Vectors3D();
					vectors[i].A = rnd.Next(0, 10);
					vectors[i].B = rnd.Next(0, 10);
					vectors[i].C = rnd.Next(0, 10);
				}

				//xml

				XmlSerializer ser = new XmlSerializer(typeof(Vectors3D[]));
				using (Stream stream = new FileStream("../../xmlSer.xml", FileMode.OpenOrCreate))
				{
					ser.Serialize(stream, vectors);
					Console.WriteLine("done 1 ");
				}
				// создаем объект SoapFormatter
				SoapFormatter formatter = new SoapFormatter();
				using (Stream stream = new FileStream("../../SoapSer.soap", FileMode.OpenOrCreate))
				{
					formatter.Serialize(stream, vectors);
					Console.WriteLine("done 2 ");
				}
				using (Stream stream = new FileStream("../../SoapSer.soap", FileMode.OpenOrCreate))
				{
					Vectors3D[] vectorsDeser = (Vectors3D[])formatter.Deserialize(stream);
					Console.WriteLine("Deser 2 ");
				}
				



				Console.WriteLine("To exit press ESCAPE ...");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}
