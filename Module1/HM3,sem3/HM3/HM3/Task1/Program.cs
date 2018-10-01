using System;

/*
Дворцова Варвара
БПИ 182-2
Задача :1) Написать метод, находящий трехзначное десятичное число s, все
цифры которого одинаковы и которое представляет собой сумму первых
членов натурального ряда, то есть s = 1+2+3+4+…
Вывести полученное число, количество членов ряда и условное
изображение соответствующей суммы, в которой указаны первые три и
последние три члена, а средние члены обозначены многоточием.
Например, если последний член равен 25, то вывести:
1+2+3+…+23+24+25.
	 */
namespace Task1
{
	class Program
	{
		/*Проверяет все ли числа одинаковы?*/
		public static bool Check(int number)
		{
			int digit = number % 10;
			number /= 10;
			while (number > 0)
			{
				if (number % 10 != digit) return false;
				number /= 10;

			}
			return true;
		}
		/*Находит то самое число*/
		public static void Find(out int sum, out int k)
		{

			sum = 0;
			for (k = 0; !(Check(sum) && sum >= 100); sum += ++k) ;

		}
		static void Main(string[] args)
		{
			int number, k;
			Find(out number, out k);
			Console.WriteLine($"Number is {number},Counts is {k}");
			Console.WriteLine($"1 + 2 + 3 +...+{k - 2}+{k - 1}+{k}");

			Console.ReadLine();

		}
	}
}
