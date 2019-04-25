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
		public Money(double penny)
		{
			this.Rubles = (int)Math.Floor(penny / 100);
			this.Penny =(int)( penny - this.Rubles * 100);

		}
		public int FullMoney => this.rubles * 100 + this.penny;//в копейках

		public int Rubles { get => rubles; set => rubles = value; }
		public int Penny { get => penny; set => penny = value; }

		public Money TransferCost(double persent)
		{
			//5% -- 0.05
			return this*(1+persent);
		}

		public static Money operator +(Money money1,Money money2)
		{
			return new Money(money1.rubles + money2.rubles, money1.penny + money2.penny);
		}

		public static Money operator -(Money money1, Money money2)
		{
			return new Money(Math.Abs(money1.rubles - money2.rubles), Math.Abs(money1.penny - money2.penny));
		}

		public static Money operator *(Money money1, Double lymbda)
		{
			
			return new Money(money1.FullMoney* lymbda);
		}

		public static Money operator /(Money money1, Double lymbda)
		{

			return new Money(money1.FullMoney / lymbda);
		}
		public override string ToString()
		{
			return $"{this.rubles}rub. {this.penny}cop. ";
		}

	}
}
