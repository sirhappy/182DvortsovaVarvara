using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*(***) Трехзначным целым числом кодируется номер аудитории в учебном
корпусе. Старшая цифра обозначают номер этажа, а две младшие – номер
аудитории на этаже. Из трех аудиторий определить и вывести на экран ту
аудиторию, которая имеет минимальный номер внутри этажа. Если таких
аудиторий несколько - вывести любую из них. */
namespace Task6
{
	class Program
	{
		/*Find auditory with least number */
		public static uint F( uint k1, uint k2 , uint k3)
		{
			uint res = 0;
			uint temp = Math.Min(k1%100, Math.Min(k3%100, k2%100));
			res = temp == k1 % 100 ? k1 : (temp == k3 % 100 ? k3 : k2);
			return res;
		}

		/*get uint number from input*/
		public static uint GetUint(string str)
		{
			uint number;
			Console.Write($"Enter {str} pls ");
			while(!uint.TryParse(Console.ReadLine(), out number)||number<100||number>999)
			{
				Console.WriteLine("ERROR");
				Console.Write($"Enter {str} pls ");
			}
			return number;
			
		}
		static void Main(string[] args)
		{
			uint k1,//aud 1
				k2,//aud 2
				k3;// aud 3
			do {
				Console.Clear();
				k1 =GetUint("1 auditory");
				k2=GetUint("2 auditory");
				k3=GetUint("3 auditory");
				uint res = F(k1, k2, k3);

				Console.WriteLine($"The auditory with least number is {res}");
				Console.WriteLine("To exit press ESC...\nTo continue press any key...");
				
				
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
		}
	}
}
