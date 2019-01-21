using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robots;
// у нас есть поле 
// бал к ср
//Применение массива делегатов для управления перемещением робота
namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			
			do {
				Console.WriteLine("Игра Робот");
				Console.WriteLine("Введите команды : R (Right)"+"– L(Left)"+"– F(Forward)"+" -B(Backward)");
				Console.Write("Команды : ");
				string command = Console.ReadLine();

			
				Console.ForegroundColor = ConsoleColor.White;

				Robot rob = new Robot(); // конкретный робот
				Console.WriteLine(rob.Position()); // сообщить координаты
				Steps delR = new Steps(rob.Right); // направо
				Steps delL = new Steps(rob.Left); // налево
				Steps delF = new Steps(rob.Forward); // вперед
				Steps delB = new Steps(rob.Backward); // назад
													  // шаги по диагоналям (многоадресные делегаты):
				Steps delRF = delR + delF;
				Steps delRB = delR + delB;
				Steps delLF = delL + delF;
				Steps delLB = delL + delB;
				char[] commands = command.ToCharArray();
				
				foreach (var item in commands)
				{
					switch (item)
					{
						case 'R':
							delR();
							break;
						case 'L':
							delL();
							break;

						case 'F':
							delF();
							break;
						case 'B':
							delB();
							break;

					}
					Console.SetCursorPosition(rob.x, rob.y);
					Console.Write("*");
				}
				
				
				Console.WriteLine(rob.Position()); // сообщить координаты
				Console.WriteLine("Для завершения нажмите любую клавишу.");
			} while (Console.ReadKey().Key!=ConsoleKey.Escape);
			
			Console.ReadKey();
		}
	}
}
