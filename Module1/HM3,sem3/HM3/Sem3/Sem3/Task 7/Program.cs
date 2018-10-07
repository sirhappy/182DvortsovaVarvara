using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Дворцова Варвара
 БПИ182-2
 Задача:Написать метод для решения квадратного уравнения.
Параметры – коэффициенты уравнения А, В, С, и два параметра, для
получения значений вещественных корней.
При отсутствии вещественных корней (если А=В=С=0 или А=В=0 и С!=0)
метод должен возвращать в точку вызова значение false, иначе - true.
В основной программе вводить коэффициенты квадратного уравнения,
выводить значения вещественных корней или сообщение об их отсутствии.*/
namespace Task_7
{
	class Program
	{
		static bool F(double a,double b ,double c,out double root1, out double root2)
		{
			if (((a == 0)& (b == 0) & (c == 0) )| ((a == 0) && (b == 0)) & (c != 0))
			{
				Console.WriteLine("Нет вещественных корней");
				root1 = root2 = -1;
				
				return false;
			}
			root1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2;
			root2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2;
			return true;
		}
		static void Main(string[] args)
		{
			double a, b, c;
			Console.WriteLine("Введите A B C");
			do {
				
				Console.Write("Введите а = ");
				while(!double.TryParse(Console.ReadLine(),out a)&& a!=0)
				{
					Console.WriteLine("error");
					Console.Write("Введите а = ");
				}
				Console.Write("Введите b = ");
				while (!double.TryParse(Console.ReadLine(), out b))
				{
					Console.WriteLine("error");
					Console.Write("Введите b = ");
				}
				Console.Write("Введите c = ");
				while (!double.TryParse(Console.ReadLine(), out c))
				{
					Console.WriteLine("error");
					Console.Write("Введите c = ");
				}

				double root1, root2;

				bool res = F(a, b, c,  out root1 , out root2);
				if (res) Console.WriteLine($"root1 = {root1:F3} ,root2 ={root2:F3}");
				else if (Math.Abs(root1 - root2) < 1e-9)Console.WriteLine("Один корень" + root1.ToString("F3"));
				else Console.WriteLine("нет корней"); 
			} while (Console.ReadKey().Key!= ConsoleKey.Escape);
		}
	}
}
