using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
	public abstract class Animal
	{
		string _name;
		int _age;
		
		public string Name { get; set; }
		public int Age
		{
			get { return _age; }
			set
			{
				if (value < 0) throw new ArgumentOutOfRangeException($"НЕ может быть {value} меньше нуля");
				_age = value;
			}
		}
		public abstract string AnimalSound();
		public abstract string  AnimalInfo();


	}
}
