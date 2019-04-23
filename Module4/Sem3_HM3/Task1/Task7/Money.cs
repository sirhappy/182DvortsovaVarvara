using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
	public class Money
	{
		int rubles;//рубли
		int penny;//копейки

		public Money(Money money)
		{
			Rubles = money.Rubles;
			Penny = money.Penny;
		}

		public Money(int rubles, int penny)
		{
			
			if (penny > 100)
			{
				Rubles =(int)(rubles + (int)Math.Floor((double)penny/100));
				Penny = penny - (int)Math.Round((double)penny / 100)*100;
			}
			else
			{
				Rubles = Math.Abs(rubles);
				Penny = Math.Abs(penny);
			}
			
		}

		public int Rubles { get => rubles; set => rubles = value; }
		public int Penny { get => penny; set => penny = value; }

		//public Money TransferCost(double persent)
		//{

		//	return new Money();
		//}
	}
}
