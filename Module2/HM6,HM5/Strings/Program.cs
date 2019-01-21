using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
	class Program
	{
		/// <summary>
		/// Checking on english letters or ';'or ' '.
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		static bool Validete(string str)
		{
			return Array.TrueForAll(str.ToCharArray(), c => c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c == ';' || c == ' ');
		}

		/// <summary>
		/// Separate string whith some symbol ch
		/// </summary>
		/// <param name="str"></param>
		/// <param name="ch"></param>
		/// <returns></returns>
		static string[] ValidateSplit(string str, char ch)
		{
			string[] strs = str.Split(new char[] { ch });
			return strs;
		}

		/// <summary>
		/// Удаление из слова букв, размещенных после первой гласной. 
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		static string Shorten(string str)
		{

			char[] ch = { 'a', 'e', 'y', 'u', 'i', 'o', 'j', 'A', 'E', 'Y', 'U', 'I', 'O', 'J' };
			
			int ind = str.IndexOfAny(ch);
			return str.Substring(0, ind + 1);


		}
		/// <summary>
		/// Приведение первой буквы к верхнему регистру ,а все остальные к нижнему
		/// </summary>
		/// <param name="str"></param>
		static void FirstUpcase(ref string str)
		{

			string temp = str;
			if (str != "") { str = str[0].ToString().ToUpper(); }
		    
			if (temp.Length >= 1) { char[] arr = temp.Substring(1).ToCharArray();
				for (int i = 0; i < arr.Length; i++)
				{
					str += arr[i].ToString().ToLower();
				}

			}

		}
		/// <summary>
		/// Создание аббревиатур
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string Abbrevation(string str)
		{
			string output = String.Empty;
			if (str != String.Empty)
			{
				string[] tmp = str.Split(' ');
				foreach (string s in tmp)
				{
					string shortenS = Shorten(s);
					FirstUpcase(ref shortenS);
					output += shortenS;
				}
			}
			return output;
		} // end of Abbrevation(string)

		static void Main(string[] args)
		{
			do
			{
				string str = "Let it be; All you need is love; Dizzy Miss Lizzy";
				String[] strs;
				if (Validete(str))//проверяем на латиницу и пробелы с ;
				{
					//разделяем по ; на подстроки
					strs = ValidateSplit(str, ';');
					//Удаление из слова букв размещенных после первой гласной
					for (int i = 0; i < strs.Length; i++)
					{
						string[] podstrs = ValidateSplit(strs[i], ' ');
						for (int j = 0; j < podstrs.Length; j++)
						{
							//Удаление из слова букв размещенных после первой гласной
							podstrs[j] = Shorten(podstrs[j]);
							//Приведение первой буквы к верхнему регистру ,а все остальные к нижнему
							FirstUpcase(ref podstrs[j]);
						}
						strs[i] = string.Join(" ", podstrs);
					}
					//делаем из элементов массива аббревиатуры
					for (int i = 0; i < strs.Length; i++)
					{
						strs[i] = Abbrevation(strs[i]);
					}
					//Вывод построчно массива аббревиатур
					foreach (var item in strs)
					{
						Console.WriteLine(item);
					}
				}


			} while (Console.ReadKey().Key != ConsoleKey.Escape);
		}
	}
}
