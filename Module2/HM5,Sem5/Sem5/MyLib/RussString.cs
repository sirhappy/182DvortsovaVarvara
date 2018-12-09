using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Класс ,представляющий строки символов русского алфавита и методы работы с ними.*/
namespace MyLib
{
	public class RussString:MyString
	{
		
		
		public RussString(char start, char finish, int n)
		{
			//проверка букв и количества букв
			Validate(start, finish, n);
			char[] letters = new char[n];
			for(int i = 0; i < letters.Length; i++)
			{
				letters[i] = (char)rnd.Next(start, finish);
			}
			str = new String(letters);
		}

		public override void Validate(char start, char finish, int n)
		{
			if (n <= 0 || start < 'а' || finish > 'я')
				throw new ArgumentOutOfRangeException();
		}

		public override int CountLetter(char ch)
		{
			if (ch < 'а' || ch > 'я') return 0;
			int start = 0, result = -1, res;
			do
			{
				res = str.IndexOf(ch, start);
				start = res + 1;    // начало следующего поиска 
				result++;           // счетчик вхождений

			} while (res > 0);

			return result;
		}
		public override string ToString()
		{
			return str;
		}
	}
}
