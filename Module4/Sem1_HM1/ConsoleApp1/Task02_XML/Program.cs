using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task02_XML
{
	[Serializable]
	public class Human
	{
		public string Name;

		public Human()
		{
		}

		public Human(string name)
		{
			Name = name;
		}
		public override string ToString()
		{
			return $"{this.Name}";
		}
	}
	[Serializable]
	public class Professor : Human
	{
		public Professor()
		{
		}

		public Professor(string name) : base(name)
		{
		}

	}
	[Serializable]
	public class Department
	{
		public List<Human> humen;
		public string NameDepartment;

		public Department()
		{
		}

		public Department(string nameDepartment)
		{
			NameDepartment = nameDepartment;
			humen = new List<Human>();
		}
		public override string ToString()
		{
			string res = string.Empty;
			for (int i = 0; i < humen.Capacity; i++)
			{
				res += $"{humen[i].ToString()}{Environment.NewLine}";
			}
			return res;
		}
	}
	[Serializable]
	public class University
	{
		public List<Department> departments;
		public string UniversityName;

		public University()
		{
		}

		public University(string nameDepartment)
		{
			UniversityName = nameDepartment;
			departments = new List<Department>();
		}
		public override string ToString()
		{
			string res = string.Empty;
			for (int i = 0; i < departments.Capacity; i++)
			{
				res += $"***{departments[i].ToString()}{Environment.NewLine}***";
			}
			return res;
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

			XmlSerializer ser = new XmlSerializer(typeof(University));
			using(Stream stream = new FileStream("../../ImproveXml.xml", FileMode.OpenOrCreate))
			{
				ser.Serialize(stream, university);
			}

			using (Stream stream = new FileStream("../../ImproveXml.xml", FileMode.OpenOrCreate))
			{

				University uni2 = (University)ser.Deserialize(stream);
				Console.WriteLine(uni2.ToString());
			}
			
			Console.ReadLine();
		}
	}
}
