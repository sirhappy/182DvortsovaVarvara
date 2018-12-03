using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
	public class Dog:Animal
	{
		string _poroda;
		bool _isTrained;
		public string Poroda => _poroda;
		public bool isTrained => _isTrained;
		public Dog(string name,int age,string poroda,bool istrained)
		{
			base.Name = name;
			base.Age = age;
			_poroda = poroda;
			_isTrained = istrained;
		}
		public override string AnimalSound()
		{
			return "Гав-гав";
		}
		public override string AnimalInfo()
		{
			return $"\t{Name}\t{Age}\t{Poroda}\t{isTrained}";
		}
	}
}
