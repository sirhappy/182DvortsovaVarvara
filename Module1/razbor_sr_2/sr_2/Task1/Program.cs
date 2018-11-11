using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Студент : Дворцова Варя
 Группа : 182-2
 Вариант: 4
 */
namespace Task1
{
	internal class Program
	{
		/// <summary>
		/// Количество выводов
		/// </summary>
		private const int OutputCount = 20;
		/// <summary>
		/// Ограничение сверху ,чтобы долго не работал
		/// </summary>
		private const int MaxValue = 1000;

		/// <summary>
		/// Метод вычисляющий член ариф-ой прогрессии и ее сумму из n элементов
		/// </summary>
		/// <param name="a">нулевой член арф прогрессии</param>
		/// <param name="d">разность</param>
		/// <param name="k">номер члена</param>
		/// <param name="an">n-й член</param>
		/// <param name="Sn">сумма n - элементов</param>
		public static void CalculateSum_and_An(int a, int d, int k, out int an, out int Sn)
		{

			an = a + (k - 1) * d;
			Sn = (a + an) * OutputCount / 2;

		}
		/// <summary>
		/// Метод считыват целые числа
		/// </summary>
		/// <param name="message">Сообщение пользователю</param>
		/// <param name="errromessage">Сообщение ошибки</param>
		/// <param name="MinValue">Максимальное значение</param>
		/// <param name="maxValue">Минимальное значение</param>
		/// <returns></returns>
		public static int Print(string message,string errromessage = "Ошибка",int  MinValue = -MaxValue, int maxValue = MaxValue)
		{
			bool isCorrect = false;
			int res;
			do
			{
				Console.Write(message);
				while(!(isCorrect = int.TryParse(Console.ReadLine(),out res) && res >= MinValue && res <= maxValue))
				{
					Console.Error.WriteLine(errromessage);
					Console.Write(message);
				}
				
			} while (!isCorrect);
			return res;
		}
		static void Main(string[] args)
		{

			int a, d;
			do
			{
				Console.Clear();
				a = Print("Введите а = ");
				d = Print("Введите d = ");
				int an, Sn;

				for (int i = 1; i <= OutputCount; i++)
				{
					CalculateSum_and_An(a, d, i, out an, out Sn);
					double chastnoe;
					if (Sn == 0) chastnoe = 0;
					else chastnoe = (double)an / Sn;
					Console.WriteLine($"an = {an} d = {d} n = {i} Sn = {Sn} chastnoe = {chastnoe:f3}");

				}

				Console.WriteLine("Press any keys to continue or Escape to exit");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);

		}
	}
}
