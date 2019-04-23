using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

/*
 Soap
	 
	 */
namespace TAsk01Soap
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
			public string GroupName { get; set; }
			public Student[] students ;

			public Group(string groupName, Student[] students)
			{
				GroupName = groupName;
				this.students = students;
			}
		}
		static void Main(string[] args)
		{

			Student student1 = new Student("Varya", 1);
			Student student2 = new Student("Jenya", 1);
			Student[] students = { student1, student2 };
			Group group = new Group("BPI182",students);

			SoapFormatter sopformater = new SoapFormatter();
			using(Stream stream = new FileStream("../../SerializeSoap.Soap", FileMode.OpenOrCreate))
			{
				sopformater.Serialize(stream, group);
				Console.WriteLine("Объект сериализован");
			}
			//Deserialise

			using(Stream stream2 = new FileStream("../../SerializeSoap.Soap", FileMode.OpenOrCreate))
			{
				Group group2 = (Group)sopformater.Deserialize(stream2);
			}
			Console.ReadLine();
		}
	}
}
