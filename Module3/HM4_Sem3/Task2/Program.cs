using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*В класс Input добавьте событие UserInput.
Вызывайте событие каждый раз, когда
пользователь введет текст и нажмет клавишу
ENTER. Организуйте подписку на событие.
Когда событие происходит, посылайте данные,
которые ввел пользователь, методу обратного
вызова из класса-подписчика. Организуйте
программу так, чтобы она поддерживала такой
диалог:
Type any characters or 'q' to quit end press Enter.
Добрый день!< ENTER >
You typed: Добрый день!
Type any characters or 'q' to quit end press Enter.
q< ENTER >
You typed ‘q’ to quit.*/
namespace Task2
{
	public class MyEventHandler : EventArgs
	{
		string message;

		public MyEventHandler(string message)
		{
			this.message = message;
		}
		public override string ToString()
		{
			return message;
		}
	}
	class Input
	{
		public event EventHandler<MyEventHandler> UserInput;
		public void GetUserInput()
		{
			while (true)
			{
				Console.WriteLine(
				"Type any characters or 'q' to quit end press Enter.");
				string input = Console.ReadLine();

				if (input.Trim() != "q")
				{
					UserInput?.Invoke(this, new MyEventHandler("Добрый день"));
				}

				else break;
			}
		}
	}
	class Event_Guide_2
	{
		public static void MyInput(object obj, MyEventHandler e)
		{
			Console.WriteLine("You typed: "+ e);
		}
		static void Main()
		{

			Input input = new Input();
			input.UserInput += MyInput;
			input.GetUserInput();
			Console.ReadKey();
		}
	}
}
