using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Получить от пользователя число К - размер массива и определить массив
символов из К элементов.
Присвоить элементам массива случайные значения от 'A' до 'Z'.
Вывести полученный массив, затем создать копию массива,
отсортировать элементы копии в алфавитном порядке и вывести.
Затем реверсировать (заменить порядок следования элементов на
обратный) отсортированный массив и вывести на экран.*/
namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			int k;
			do { Console.Write("Введите кол-во элементов массива = "); }
			while (!int.TryParse(Console.ReadLine(), out k)||k<=0);
			char[] c = new char[k];
			Random rnd = new Random();
			Console.WriteLine();
			for(int i=0; i < k; i++)
			{
				c[i] = (char)rnd.Next((int)'A', (int)'Z'+1);
				Console.Write("{0,2}", c[i]);
			}
			Console.WriteLine();
			Console.WriteLine();
			char[] c1 = (char[])c.Clone();
			Array.Sort(c1);
			for(int i = 0; i < k; i++)
			{
				Console.Write("{0,2}", c1[i]);
			}
			Console.WriteLine();
			Console.WriteLine();
			Array.Reverse(c1);
			for (int i = 0; i < k; i++)
			{
				Console.Write("{0,2}", c1[i]);
			}
			Console.ReadLine();
		}
	}
}
