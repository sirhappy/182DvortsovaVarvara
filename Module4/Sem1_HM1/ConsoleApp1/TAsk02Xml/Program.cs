using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace TAsk02Xml
{
	[Serializable]
	public class Human
	{
		public string Name;

		public Human(string name)
		{
			Name = name;
		}
	}
	[Serializable]
	public class Professor : Human
	{
		public Professor(string name) : base(name)
		{
		}

	}
	[Serializable]
	public class Department
	{
		public List<Human> humen;
		public string NameDepartment;

		public Department(string nameDepartment)
		{
			NameDepartment = nameDepartment;
			humen = new List<Human>();
		}
	}
	[Serializable]
	public class University
	{
		public List<Department> departments;
		public string UniversityName;

		public University(string nameDepartment)
		{
			UniversityName = nameDepartment;
			departments = new List<Department>();
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Professor processor1 = new Professor("Podbel");
			Professor processor2 = new Professor("Gordenko");
			Department dep1 = new Department("PI");
			Department dep2 = new Department("PMI");

			dep1.humen.Add(processor1);
			dep2.humen.Add(processor2);
			University university = new University("HSE");
			university.departments.Add(dep1);

			university.departments.Add(dep2);
			BinaryFormatter binary = new BinaryFormatter();

			using (Stream stream = new FileStream("../../ImproveBin.dat", FileMode.OpenOrCreate))
			{
				binary.Serialize(stream, university);

			}
			using (Stream stream = new FileStream("../../ImproveBin.dat", FileMode.OpenOrCreate))
			{
				University uni2 = (University)binary.Deserialize(stream);
			}

			Console.ReadKey();
		}
	}
}
