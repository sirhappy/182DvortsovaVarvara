using System;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
	class Program
	{
		public class Zoo<T>
			where T : Animal, new()
		{

			public void MoveAnimal(T animal)
			{
				//animal.Move();
			}
			public T getNewAnimal()
			{
				T animal = new T();
				return animal;
			}
		}
		static void NonGenericList()
		{
			ArrayList list = new ArrayList();
			list.Add(5);
			list.Add(6);
			list.Add("5");
			
			int sum = 0;
			foreach (var item in list)
			{
				sum += (int)item;
			}
			Console.WriteLine(sum);
		}
		static void GenericList()
		{
			List<int> list = new List<int>();
			list.Add(5);
			list.Add(6);
			

			int sum = 0;
			foreach (var item in list)
			{
				sum += (int)item;
			}
			Console.WriteLine(sum);
		}
		public class Animal
		{
			//public void Move() { Console.Write("Run!"); }
		}
		public class Cat : Animal
		{

		}
		public class Dog : Animal
		{

		}
		public interface Istudent< out T>
		{
			void Move(T student);
		}
		public class Student<T>:Istudent<T>
		{
			public void Move(T student)
			{
				Console.Write("Run");
			}
		}
		
		static void Main(string[] args)
		{
			
			Istudent<Animal> student2 = new Student<Cat>();
			student2.Move(new Dog());
			
			Console.ReadLine();
		}
	}
}
