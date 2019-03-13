using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTaskFor4_5
{
	public class Queue<T>
	{
		const int MaxQueue = 10;//предельный размер очереди
		T First;
		T Last;
		T[] QueueArray;
		int Capasity=0;
		public bool IsEmpty { get
			{
				if (Capasity == 0)
					return true;
				return false;
			} }
		public bool IsFull
		{
			get
			{
				if (Capasity >= MaxQueue)
					return true;
				return false;
			}
		}
	}
}
