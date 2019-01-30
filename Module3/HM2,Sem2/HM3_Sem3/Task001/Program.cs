using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConverter;

namespace Task001
{
	class Program
	{
		/// <summary>
		/// Удаляем числа из строки
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string RemoveDigits(string str)
		{


			String[] strings = str.Split("0123456789".ToCharArray());
			str = string.Join("", strings);

			return str;
		}
		/// <summary>
		/// Удаляем пробелы из строк
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string RemoveSpaces(string str)
		{
			String[] strings = str.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
			string res = string.Join("", strings);

			return res;
		}
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				string[] tests = { "asdf7hj55", "as fg 7 sd88", "00  0", "4_8a", "a8o" };
				Array.ForEach(tests, e => Console.Write($"\t{e}\t"));
				Console.WriteLine();
				ConvertRule rev = RemoveDigits;
				ConvertRule rev2 = RemoveSpaces;
				Console.WriteLine("Убираем цифры");
				string[] test_1del = Array.ConvertAll(tests, e => rev(e));
				Array.ForEach(test_1del, e => Console.Write($"\t{e}\t"));
				Console.WriteLine();
				Console.WriteLine("Убираем пробелы");
				string[] test_2del = Array.ConvertAll(tests, e => rev2(e));
				Array.ForEach(test_2del, e => Console.Write($"\t{e}\t"));
				Console.WriteLine();
				Console.WriteLine("Для много адресного делегата:");
				ConvertRule ToDev = rev2 + rev;
				string[] test_ToDev = Array.ConvertAll(tests, e => ToDev(e));
				Array.ForEach(test_ToDev, e => Console.Write($"\t{e}\t"));
				Console.WriteLine();
				Console.WriteLine("Тестируем делегат как парам");
				Converter con = new Converter();
				string[] test_with_obj = Array.ConvertAll(tests, e => con.Convert(e, rev));
				Array.ForEach(test_with_obj, e => Console.Write($"\t{e}\t"));

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}
