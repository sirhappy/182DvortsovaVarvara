using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
	class Program
	{
		static void Main(string[] args)
		{
			Money my_money = new Money(105);
			Console.WriteLine("my_money = {0}", my_money);
			Money others_money = new Money(205);
			Console.WriteLine("others_money = {0}", others_money);
			Money sum_money = my_money + others_money;
			Console.WriteLine("omy_money + others_money = {0}", sum_money);
			Money sub_money = my_money - others_money;
			Console.WriteLine("my_money - others_money= {0}", sub_money);
			//my_money.TransferCost(0.09);
			Console.WriteLine("my_money.TransferCost(0.09)= {0}", my_money.TransferCost(0.09));
			Money dev_money = my_money / 5;
			Money mult_money = my_money * 10;
			Console.WriteLine("my_money * 10 = {0}", mult_money);


			Console.ReadLine();
		}
	}
}
