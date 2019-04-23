using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Task01Xml
{
	[Serializable]
	public class Student
	{
		public Student()
		{
		}

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
		public Group()
		{

		}
		public string GroupName { get; set; }
		public Student[] students;

		public Group(string groupName, Student[] students)
		{
			GroupName = groupName;
			this.students = students;
		}
		public override string ToString()
		{
			string res = String.Empty;
			for (int i = 0; i < students.Length; i++)
			{
				res += $"{students[i].SureName} {students[i].Course} {Environment.NewLine}";
			}
			return res;
		}
	}
	class Program
	{
	
		static void Main(string[] args)
		{
			Student student1 = new Student("Varya", 1);
			Student student2 = new Student("Jenya", 1);
			Student[] students = { student1, student2 };
			Student student3 = new Student("Katya", 1);
			Student student4 = new Student("Tolya", 1);
			Student[] OtherStudents = { student3, student4 };
			Group group = new Group("BPI182", students);
			Group group2 = new Group("BPI181", OtherStudents);
			Group[] groups = { group, group2 };

			XmlSerializer ser = new XmlSerializer(typeof(Group[]));

			using (Stream stream = new FileStream("../../GroupXml.xml", FileMode.OpenOrCreate))
			{
				ser.Serialize(stream, groups);
				Console.WriteLine("Object was Serialize");
			}

			using (Stream stream2 = new FileStream("../../GroupXml.xml", FileMode.OpenOrCreate))
			{
				Group[] groups2 = (Group[])ser.Deserialize(stream2);
			}
			for (int i = 0; i < groups.Length; i++)
			{
				Console.WriteLine(groups[i].ToString());
			}
			
			Console.ReadKey();
		}
	}
}
