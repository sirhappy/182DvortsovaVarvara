// Проект 2. Чтение целых из двоичного потока.
// ЧИТАТЬ И ЗАПИСЫВАТЬ СТРОГО ПО ОДНОМУ ЧИСЛУ!!!
using System;
using System.IO;
class Program
{
	static void Main()
	{
		BinaryWriter fOut = new BinaryWriter(
new FileStream("../../../t.dat", FileMode.Create));
		for (int i = 0; i <= 10; i += 2)
			fOut.Write(i);
		fOut.Close();
		FileStream f = new FileStream("../../../t.dat", FileMode.Open);
		BinaryReader fIn = new BinaryReader(f);
		long n = f.Length / 4; int a;
		for (int i = 0; i < n; i++)
		{
			a = fIn.ReadInt32();
			Console.Write(a + " ");
		}
		Console.WriteLine("\nЧисла в обратном порядке:");
		//f.Position = f.Length - 4;
		// 1) TODO: Прочитать и напечатать все числа из файла в обратном порядке

		for (int i = 0; i < n; i++)
		{
			//Потому что вверху мы уже дошли до конца
			f.Position -= 4;
			a = fIn.ReadInt32();
			Console.Write(a + " ");
			f.Position -= 4;
			
		}
		Console.WriteLine();
		// 2) TODO: увеличить все числа в файле в 5 раз
		for (int i = 0; i < n; i++)
		{
			
			a = fIn.ReadInt32();
			fIn.Write(())
			Console.Write(a + " ");
			f.Position += 4;
			
		}
		// 3) TODO: Прочитать и напечатать все числа из файла в прямом порядке
		fIn.Close();
		f.Close();
		Console.ReadLine();
	}
}