using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Task01
{
	class Program
	{
		[Serializable]
		public class Student
		{
			public Student(string sureName, int course)
			{
				SureName = sureName;
				Course = course;
			}

			public string SureName { get; set; }
			public int Course { get; set; }

		}
		[Serializable]
		public class Group
		{
			public string GroupName{ get; set; }
			public List<Student> students = new List<Student>();

		}
		static void Main(string[] args)
		{
			Student student1 = new Student("Varya", 1);
			Student student2 = new Student("Jenya", 1);

			Group group = new Group() { GroupName = "BPI182" };
			group.students.Add(student1);
			group.students.Add(student2);

			BinaryFormatter binformater = new BinaryFormatter();
			FileStream fs = new FileStream("../../BinaryGroup.dat", FileMode.OpenOrCreate);

			//Serialize

			binformater.Serialize(fs, group);
			fs.Close();

			//Deserialise

			Stream stream = new FileStream("../../BinaryGroup.dat", FileMode.Open);
			Group Degroup = (Group)binformater.Deserialize(stream);

			Console.ReadKey();
		}
	}
}
