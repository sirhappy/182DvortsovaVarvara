using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
	public class Cow:Animal
	{
		double _countMilkInDay;
		public double countMilkInDay {

			get {return _countMilkInDay;}
				
			set { if (value < 0) throw new ArgumentOutOfRangeException($"Литров молока не должно быть отрицательным числом!");
				_countMilkInDay = value;
			}
		}
		public Cow(string name, int age,double countmilkInDay)
		{
			base.Name = name;
			base.Age = age;
			countMilkInDay = countmilkInDay;
		}
		public override string AnimalSound()
		{
			return "Муууу";
		}
		public override string AnimalInfo()
		{
			return $"\t{Name}\t{Age}\tcountMilk = {countMilkInDay}";
		}
	}
}
