using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			FileInfo fi = new FileInfo(@"..\..\Alphabet.txt");


			FileStream fs = fi.Open(FileMode.OpenOrCreate);
			long ln = fs.Length;
			if (ln == 26) Console.WriteLine("Done");
			else
			{
				if (ln == 0) Console.WriteLine("File is Empty");
				fs.Seek(ln, SeekOrigin.Begin);
				byte bt = (byte)((int)'A' + ln);
				fs.WriteByte(bt);
				Console.WriteLine("Add symbol to file "+(char)(bt))	;

			}
		}
	}
}
