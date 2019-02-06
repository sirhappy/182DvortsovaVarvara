using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*событийный делегат CoordChanged, представляющий методы одним 
 * параметром типа Dot, возвращающие значение void.
класс Dot – точка на плоскости с двумя вещественными координатами. 
В классе разместите:
событие OnCoordChanged с типом CoordChanged;
метод DotFlow(), который в цикле присваивает 
координатам точки 10 раз случайные вещественные 
значения из диапазона (-10; 10). 
Если обе координаты точки отрицательные значения – 
запускать событие OnCoordChanged, и передавать в него ссылку на объект.
*/
namespace TaskDop1
{
	public delegate void CoordChanged(Dot dot);
	public class Dot
	{
		public event CoordChanged OnCoordChanged;

		public double X;
		public double Y;

		public Dot(double x, double y)
		{
			X = x;
			Y = y;
		}

		public void DotFlow()
		{
			Random rnd = new Random();
			for (int i = 0; i < 10; i++)
			{
				this.X = rnd.Next(-10, 11) + rnd.NextDouble();

				this.Y= rnd.Next(-10, 11) + rnd.NextDouble();
				if (X < 0 & Y < 0)
					OnCoordChanged?.Invoke(this);
			}
		}

	}
}
