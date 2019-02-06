using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*событийный делегат SquareSizeChanged, 
 * представляющий методы c одним вещественным 
 * параметром и возвращающие значение void. 
класс Square – квадрат на плоскости. Квадрат 
задан координатами верхнего левого и правого нижнего углов. 
В классе разместите:
событие OnSizeChanged с типом SquareSizeChanged;
свойства доступа к координатам определяющих углов квадрата.
В коде каждого свойства после изменения значения поля
запускает событие OnSizeChanged, в качестве параметра 
передаётся новое значение длины стороны квадрата.
*/
namespace DopTask2
{
	public delegate void SquareSizeChanged(double arg);
	class Squera
	{
		double LeftVerhAngl;
		double RightNizAngl;

		public double Storona;


		public double LeftVerhAngl1
		{
			get => LeftVerhAngl;
			set
			{
				LeftVerhAngl = value;

				OnSizeChanged?.Invoke(Storona);
			}
		}
		public double RightNizAngl1
		{
			get => RightNizAngl; set
			{
				RightNizAngl = value;
				OnSizeChanged?.Invoke(Storona);

			}
		}

		public event SquareSizeChanged OnSizeChanged;

	}
}
