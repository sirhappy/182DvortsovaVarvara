using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
	class Program
	{
		public static Random rnd = new Random();
		static void Main(string[] args)
		{
			do {
				Console.Clear();
				int n;

				do { Console.Write("Enter n  = "); } while (!int.TryParse(Console.ReadLine(), out n) || n == 0 || n < 0);
			
				LinearEquation[] arr = new LinearEquation[n];
				for(int i = 0; i < arr.Length; i++)//Создание массива
				{
					try//если А = 0
					{
						arr[i] = new LinearEquation(rnd.Next(-10, 10), rnd.Next(-10, 10), rnd.Next(-10, 10));
					}
					catch (ArgumentException)
					{
						arr[i] = new LinearEquation();
					}
					
				}
				Console.WriteLine("Your array :");
				for(int i = 0; i < arr.Length; i++)//Вывод массива
				{
					Console.WriteLine($"a[{i}] = {arr[i]}");
				}
				for(int i = 0; i < arr.Length-1; i++)//Сортировка по корням
				{
					for(int j =i+1;j< arr.Length; j++)
					{
						if(arr[i].Root > arr[j].Root)
						{
							LinearEquation temp = arr[i];
							arr[i] = arr[j];
							arr[j] = temp;
						}
					}
				}
				Console.WriteLine("Your Sort_array :");
				for (int i = 0; i < arr.Length; i++)//Ввывод отсортированного
				{
					Console.WriteLine($"a[{i}] = {arr[i]}");
				}
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}
