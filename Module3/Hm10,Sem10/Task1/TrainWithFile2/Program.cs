using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrainWithFile2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string path = @"../../попытка.txt";
				if (!File.Exists(path))
				{
					File.Create(path);
				}
				string text = "fjkesjfkesjkf";
				using (StreamWriter sw = new StreamWriter(path,true))
				{
					sw.WriteLine(text);
				}
				using(StreamReader sr =new StreamReader(path))
				{
					Console.WriteLine(sr.ReadToEnd()	); 
				}
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
			
			Console.ReadLine();
		}
	}
}
