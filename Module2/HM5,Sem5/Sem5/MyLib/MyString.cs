using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
	public abstract class MyString
	{
		public string str;
		public static Random rnd = new Random();
		
		public bool isPalindrom()
		{
			if (str.Length > 0)
			{
				char[] temp = str.ToCharArray();
				Array.Reverse(temp);
				string palindrome = new string(temp);
				if (str.CompareTo(palindrome) == 0)
				{
					return true;
				}
				
			}
		    return false;
		}
		abstract public int CountLetter(char ch);
		
		public abstract void Validate(char start, char finish, int n);
	}
}
