using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure2;
namespace Task4
{

	//Сорт по ключам , чтобы сортировать по ключам структуры Point 
	//реализуем IComparable в Point ,сравниваем расстояние до точки (0,0)
	class Program
	{
		static void Main(string[] args)
		{
			CircleS[] circArr = new CircleS[] { new CircleS(1,1,3), new CircleS(2,3,4),
								new CircleS(-1,-2,3), new CircleS(4,3,1) };

			Console.WriteLine("Ключи и круги до сортировки:");
			// Массив ключей для сортировки по уменьшению удаленности 
			// кругов от начала координат:
			PointS[] keys = new PointS[circArr.Length];
			PointS p0 = new PointS(0, 0);
			for (int i = 0; i < circArr.Length; i++)
			{
				keys[i] = circArr[i].Center;
				Console.Write("distance[{0}]={1:g3}\t", i, keys[i].distance(p0));
				Console.WriteLine(circArr[i].ToString());
			}
			Array.Sort(keys, circArr);
			Console.WriteLine("Массив кругов после сортировки: ");
			foreach (CircleS cs in circArr)
				Console.WriteLine(cs.ToString());
			Console.WriteLine("Для выхода из программы нажмите ENTER.");
			Console.ReadLine();
		}
	}
}
