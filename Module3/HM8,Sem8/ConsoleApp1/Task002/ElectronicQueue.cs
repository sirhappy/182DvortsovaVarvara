using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task002
{
	class ElectronicQueue<T>
		where T:struct
	{
		Queue<T> queue = new Queue<T>();
		public void AddToQueue(T person)
		{
			queue.Enqueue(person);//add
		}
		public void DeleteFromQueue()
		{

			if (queue.Count == 0)
				throw new Exception("Очередь пуста");
			queue.Dequeue();//delete


		}
		public string CallFromElectronicQueue()
		{
			string output = String.Empty;
			// получаем значение первого элемента очереди
			if (queue.Count != 0)
			{
				T tmp = queue.Peek();
				output = tmp.ToString();
			}

			return output;
		}
	}
}
