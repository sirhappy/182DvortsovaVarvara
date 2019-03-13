using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
	public class ElectronicQueue

	{
		Queue<Person> queue = new Queue<Person>();
		public void AddToQueue(Person person)
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
				Person tmp = queue.Peek();
				output = tmp.ToString();
			}

			return output;
		}

	}
}
