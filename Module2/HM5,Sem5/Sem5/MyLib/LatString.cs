using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
	public class LatString:MyString
	{
		
		public LatString(char start,char finish,int n)
		{
			Validate(start, finish, n);
			char[] arr = new char[n];
			for(int i = 0; i < arr.Length; i++)
			{
				arr[i] = (char)rnd.Next(start, finish);
			}
			str = new string(arr);
		}
		public override void Validate(char start, char finish, int n)
		{
			if (n <= 0 || start < 'a' || finish > 'z')
				throw new ArgumentOutOfRangeException();
		}
		public override int CountLetter(char ch)
		{
			if (ch < 'a' || ch > 'z') return 0;
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
