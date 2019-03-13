using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
	public struct Person
	{
		public string Name { get; set; }
		public string SureName { get; set; }
		public int Age { get => age; set => age = value; }

		int age;

		public Person(string name, string surName, int age) : this()
		{
			Name = name;
			SureName = surName;
			Age = age;
		}
		public override string ToString()
		{
			return $"Name = {Name}  SureName = {SureName} age = {Age}";
		}
	}
}
