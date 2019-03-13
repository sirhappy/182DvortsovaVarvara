using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	class MyStack<T>
	{
		const int MaxStack = 10; // предельный размер стека
		T[] StackArray; // массив для элементов
		int StackPointer = 0; // число элементов в стеке
		public MyStack() { StackArray = new T[MaxStack]; }
		bool IsStackFull { get { return StackPointer >= MaxStack; } }
		bool IsStackEmpty { get { return StackPointer <= 0; } }
		public void Push(T x)
		{ // Поместить в стек элемент
			if (!IsStackFull)
				StackArray[StackPointer++] = x;
		}
		public T Pop()
		{ // Получить элемент из стека
			return (!IsStackEmpty)
				? StackArray[--StackPointer]
				: StackArray[0];
		}
		public override string ToString()
		{
			// Распечатать элементы стека
			string res = string.Empty;
			for (int i = StackPointer - 1; i >= 0; i--)
				res+= $" Value: {StackArray[i]}";
			return res;
		}
		
	} //MyStack
	class Program
	{
		static void Main(string[] args)
		{
			var stackInt = new MyStack<int>();
			var stackString = new MyStack<string>();
			stackInt.Push(3); stackInt.Push(5); stackInt.Push(7);

			Console.WriteLine(stackInt.ToString()	); 
			stackString.Push("Generics are great!");
			stackString.Push("Hi there! ");
			Console.WriteLine(stackInt.ToString());
			Console.ReadLine();
		}
	}
}
