using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplEnumerator
{
	class Program
	{
		static void Main()
		{
			List<int> arr = new List<int>();
			Random ran = new Random();

			for (int i = 0; i < 10; i++)
				arr.Add(ran.Next(1, 20));

			// Используем перечислитель
			IEnumerator<int> etr = arr.GetEnumerator();
			while (etr.MoveNext())
				Console.Write(etr.Current + "\t");

			Console.WriteLine("\nПовторный вызов перечислителя: \n");
			// Сбросим значение и вновь используем перечислитель
			// для доступа к коллекции
			etr.Reset();
			while (etr.MoveNext())
				Console.Write(etr.Current + "\t");

			Console.ReadLine();
		}
	}
}
