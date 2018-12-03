using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;


namespace Task6
{
	class Program
	{
		/// <summary>
		/// Метод трапеции
		/// </summary>
		/// <returns></returns>
		public static double trapeciya(Integrand f,int n)
		{
			double h = (f.Xmax - f.Xmin) / n;
			double sum = 0;
			for(int i = 0; i < n; i++)
			{
				sum +=  h*(f.function(i * h) + f.function((i + 1) * h)) / 2;
			}
			return sum;
		}
		// Ссылка на абстрактный класс в качестве параметра
		// Вычисление интеграла методом прямоугольников:
		public static double rectangle(Integrand f, int n)
		{
			//шаг интегрирования:
			double h = (f.Xmax - f.Xmin) / n;
			double sum = 0;
			for (int i = 0; i < n; i++)
				sum += f.function(f.Xmin + h / 2 + i * h);
			return sum * h;
		}
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			Fun_1 f1 = new Fun_1(-1, 2);
			Console.WriteLine("Интеграл_1 = {0:g6}", rectangle(f1, 20));
			Console.WriteLine("Интеграл_2 = {0:g7}",
									   rectangle(new Fun_2(0, 0.5), 20));
			Fun_3 f3 = new Fun_3(-1,1);
			Integrand[] arr = new Integrand[5];
			for(int i = 0; i < arr.Length; i++)
			{
				if (rnd.Next(0, 3) == 0) arr[i] = new Fun_1(-1,1);
				else if (rnd.Next(0, 3) == 1) arr[i] = new Fun_2(-1,1);
				else  arr[i] = new Fun_3(-1, 1);
			}
			for(int i = 0; i < arr.Length; i++)
			{
				if(arr[i] is Fun_1)Console.WriteLine("Интеграл_1(треугольником) = {0:g6}\t(трапецией) = {1:g6}", rectangle(arr[i], 20),trapeciya(arr[i],20));
				if (arr[i] is Fun_2) Console.WriteLine("Интеграл_2(треугольником) = {0:g6}\t(трапецией) = {1:g6}", rectangle(arr[i], 20), trapeciya(arr[i], 20));
				if (arr[i] is Fun_3) Console.WriteLine("Интеграл_3(треугольником) = {0:g6}\t(трапецией) = {1:g6}", rectangle(arr[i], 20), trapeciya(arr[i], 20));
			}
			Console.ReadKey();
		}
	}
}
