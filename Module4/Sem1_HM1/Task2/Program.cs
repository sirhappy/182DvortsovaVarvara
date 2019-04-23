using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task2
{
	class Program
	{
		[Serializable]
		public class Human
		{
			public string Name;

		}
		[Serializable]
		public class Professor:Human
		{
			
		}
		[Serializable]
		public class Department {
			public string Name;
			public List<Human> humen =new List<Human>();
		}
		[Serializable]
		public class University
		{
			public List<Department> departments = new List<Department>();
			public string Name;
		}

		static void Main(string[] args)
		{
			University university = new University { Name = "HSE" };
			Human h1 = new Human { Name = "Karya" };
			Human h2 = new Human { Name = "Tenya" };
			Department dep = new Department { Name = "FCS" };

			dep.humen.Add(h1);
			dep.humen.Add(h2);
			university.departments.Add(dep);


			FileStream bas = new FileStream("../../university.ser", FileMode.OpenOrCreate);
			BinaryFormatter format = new BinaryFormatter();
			format.Serialize(bas, university);
			bas.Close();

			bas = new FileStream("../../university.ser", FileMode.Open);

			
				
			University sharaga = (University)format.Deserialize(bas);
			Console.WriteLine(sharaga.ToString());
				
				
			
			Console.ReadLine();
		}
	}
}
