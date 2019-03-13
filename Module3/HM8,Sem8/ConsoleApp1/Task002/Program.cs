using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task002
{
	class Program
	{
		static void Main(string[] args)
		{
			ElectronicQueue<int> queue = new ElectronicQueue<int>();
			queue.AddToQueue(10);
			queue.AddToQueue(11);
			queue.AddToQueue(12);
			queue.AddToQueue(15);
			Console.Write("Add some number to queue = ");
			int n;
			int.TryParse(Console.ReadLine(), out n);
			queue.AddToQueue(n);
			Console.WriteLine("Queue start works");
			bool check = false;
			do
			{
				try
				{
					
					Console.WriteLine(queue.CallFromElectronicQueue());
					Thread.Sleep(120);
					queue.DeleteFromQueue();
				}
				catch (Exception ex)
				{

					Console.WriteLine(ex.Message);
					check = true;
				}
			} while (!check);
			Console.ReadLine();
		}
	}
}
