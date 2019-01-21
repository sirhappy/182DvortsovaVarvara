using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	/*Написать метод ConvertHex2Bin(), выполняющий перевод шестнадцатеричного числа в двоичное.
	 * Заголовок метода следующий:
string ConvertHex2Bin(string HexNumber)
Здесь HexNumber – строка, представляющая шестнадцатеричное число, например 5A1.
Функция должна возвращать строку с двоичным представлением числа. 
Например, для шестнадцатеричного числа, представленного строкой 5A1 функция 
должна вернуть строку 10110100001. Показать работоспособность функции на трех примерах.

*/
	class Program
	{
		public static string ConvertHex2Bin(string HexNumber)
		{
			char[] sh = HexNumber.ToCharArray();
			string res = string.Empty;
			string str = "0123456789ABCDEF";

			for (int i = 0; i < sh.Length; i++)
			{
				
				int ind = 0;
				
					ind = str.IndexOf(sh[i]);
					res += Convert.ToString(ind, 2);
				
			}
			return res;
			
		}
		/// <summary>
		/// Проверка на шеснадцатиричное число
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		static bool IsHexSystem(string str)
		{
			char[] sh = str.ToCharArray();
			string m = "0123456789ABCDEF";
			if(Array.TrueForAll(str.ToCharArray(), c => m.IndexOf(c) > 0))return true;
			return false;

		}
		static void Main(string[] args)
		{
			do {
				Console.Write("Enter number : ");
				string sh= Console.ReadLine();
				if(IsHexSystem(sh)) Console.WriteLine(ConvertHex2Bin(sh));
				else Console.WriteLine("Incorrect input!");

			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}
